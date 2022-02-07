using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace LicenseTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           var str = HardwareInfo.GenerateUID();
            tx_HardwareCode.Text = str;
        }

        private void bt_verify_Click(object sender, EventArgs e)
        {
            RSACryptoServiceProvider rsaKey = new RSACryptoServiceProvider();
            try
            {

                rsaKey = GetPublicKey();
               // rsaKey = GetPublicKeyFromFile();
                // Create a new XML document.
                XmlDocument xmlDoc = new XmlDocument();

                // Load an XML file into the XmlDocument object.
                xmlDoc.PreserveWhitespace = true;

                // Load an XML file into the XmlDocument object.
                xmlDoc.PreserveWhitespace = true;
                var activeCode = Encoding.UTF8.GetString(Convert.FromBase64String(tx_ActivationCode.Text));
                xmlDoc.LoadXml(activeCode);

                bool result = VerifyXml(xmlDoc, rsaKey);

                // Display the results of the signature verification to 
                // the console.
                if (result)
                {


                    XmlNodeList nodeSign = xmlDoc.GetElementsByTagName("Signature");
                    XmlNodeList nodeVersion = xmlDoc.GetElementsByTagName("LicenseVersion");
                    XmlNodeList nodeData = xmlDoc.GetElementsByTagName("data");

                    string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                    var className = GetLicenseType(nodeVersion[0].InnerText);
                    var handle = Activator.CreateInstance(assemblyName, className);
                    var instance = (ILicense)handle.Unwrap();

                    xmlDoc.DocumentElement.RemoveChild(nodeSign[0]);
                    xmlDoc.DocumentElement.RemoveChild(nodeVersion[0]);

                    ILicense licenseVerified;
                    var licXML = nodeData[0].InnerText;
                    //Deserialize license
                    XmlSerializer _serializer = new XmlSerializer(instance.GetType());
                    using (StringReader _reader = new StringReader(licXML))
                    {
                        licenseVerified = (ILicense)_serializer.Deserialize(_reader);
                    }

                    if (licenseVerified.ExtraValidation())
                    {
                        
                        MessageBox.Show(licXML);
                        // set the parameters
                    }
                    else
                        MessageBox.Show("hardware Id is wrong");
        
                    //licStatus = licenseVerified.DoExtraValidation(out validationMsg);
                }
                else
                {
                    MessageBox.Show("The XML signature is not valid.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetLicenseType(string name)
        {
            switch (name)
            {
                case "LicenseMay2018":
                    return typeof(LicenseMay2018).AssemblyQualifiedName.Split(',')[0];
                default:
                    return null;
            }
        }

        public RSACryptoServiceProvider GetPublicKey()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            MemoryStream mem = new MemoryStream();
            assembly.GetManifestResourceStream("LicenseTester.LicenseVerify.cer")?.CopyTo(mem);

            var certPubicKeyData = mem.ToArray();
            X509Certificate2 cert = new X509Certificate2(certPubicKeyData);
            RSACryptoServiceProvider rsaKey = (RSACryptoServiceProvider)cert.PublicKey.Key;

            return rsaKey;
        }

        public RSACryptoServiceProvider GetPublicKeyFromFile()
        {
            string Certificate = "LicenseVerify.cer";
            X509Certificate2 cert = new X509Certificate2(Certificate);
            RSACryptoServiceProvider rsaKey = (RSACryptoServiceProvider)cert.PublicKey.Key;

            return rsaKey;
        }


        public static Boolean VerifyXml(XmlDocument Doc, RSA Key)
        {
            // Check arguments.
            if (Doc == null)
                throw new ArgumentException("Doc");
            if (Key == null)
                throw new ArgumentException("Key");

            // Create a new SignedXml object and pass it
            // the XML document class.
            SignedXml signedXml = new SignedXml(Doc);

            // Find the "Signature" node and create a new
            // XmlNodeList object.
            XmlNodeList nodeList = Doc.GetElementsByTagName("Signature");

            // Throw an exception if no signature was found.
            if (nodeList.Count <= 0)
            {
                throw new CryptographicException("Verification failed: No Signature was found in the document.");
            }

            // This example only supports one signature for
            // the entire XML document.  Throw an exception 
            // if more than one signature was found.
            if (nodeList.Count >= 2)
            {
                throw new CryptographicException("Verification failed: More that one signature was found for the document.");
            }

            // Load the first <signature> node.  
            signedXml.LoadXml((XmlElement)nodeList[0]);

            // Check the signature and return the result.
            return signedXml.CheckSignature(Key);
        }

        private void bt_byte_Click(object sender, EventArgs e)
        {
            var str = Encoding.UTF8.GetBytes(tx_ActivationCode.Text);
            string hex = BitConverter.ToString(str);
            tx_ActivationCode.Text= hex.Replace("-", "");
        }
    }
}
