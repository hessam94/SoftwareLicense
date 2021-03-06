using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace LicenseGenerator
{
    // if there is any new class in the future you should implement a new class like below
    // define your properties which can be different from LicenseMay2018
    public class LicenseMay2018 : BaseLicense ,   ILicense
    {
        public LicenseMay2018()
        { }
        public byte[] _certPubicKeyData;

        public int? ManagedObjectCount;
        public int? MonitorCount;
        public int? FaultCount;
        public string LicenseName;
        public DateTime? ExpirationDate;
        public string UniqueId;
        public string LicenseSerialNumber;
        public int? AggregateMonitorCount;
        public int? UserCount;
        public int? SiteChildCount;
        public bool ExtraValidation()
        {
            // test default
            return true;
        }


        public BaseLicense GenerateLicenseModel(InputLicense model)
        {
            LicenseMay2018 license = new LicenseMay2018();
            license.ManagedObjectCount =model.ManagedObjectCount;
            license.MonitorCount = model.MonitorCount;
            license.FaultCount = model.FaultCount;
            license.LicenseName = model.LicenseName;
            license.UniqueId = model.UniqueId.Trim();
            license.LicenseSerialNumber = model.LicenseSerialNumber;
            license.AggregateMonitorCount = model.AggregateMonitorCount;
            license.SiteChildCount = model.SiteChildCount;
            license.ExpirationDate = model.ExpirationDate;
            license.UserCount = model.UserCount;
            return license as BaseLicense;
        }

        public string GenerateSignature(BaseLicense license)
        {
            try
            {
                Assembly _assembly = Assembly.GetExecutingAssembly();

                try
                {
                    MemoryStream _mem = new MemoryStream();
                    _assembly.GetManifestResourceStream("LicenseGenerator.LicenseSign.pfx").CopyTo(_mem);
                    _certPubicKeyData = _mem.ToArray();
                }
                catch (Exception ex)
                {

                }

                // exception for password
                X509Certificate2 certificate = new X509Certificate2(_certPubicKeyData, "demo");
                RSACryptoServiceProvider rsaCsp = (RSACryptoServiceProvider)certificate.PrivateKey;

                XmlDocument xmlDoc = new XmlDocument();
                // this part would be different for every type of license; LicenseMay2018,....

                XmlNode elemBody = xmlDoc.CreateElement(string.Empty, "body", string.Empty);
                xmlDoc.AppendChild(elemBody);
                XmlNode elemMain = xmlDoc.CreateElement(string.Empty, "data", string.Empty);
               
                
                using (StringWriter stream = new StringWriter())
                {
                    XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                    var settings = new XmlWriterSettings();
                    settings.Indent = true;
                    settings.OmitXmlDeclaration = true;
                    XmlWriter writer = XmlWriter.Create(stream, settings);
                    //Add an empty namespace and empty value
                    ns.Add("", "");
                    XmlSerializer serializer = new XmlSerializer(typeof(LicenseMay2018));
                    serializer.Serialize(writer, license,ns);
                    XmlText textMain = xmlDoc.CreateTextNode(stream.ToString());
                    elemMain.AppendChild(textMain);
                    elemBody.AppendChild(elemMain);

                }

                // Create a new XML document.
                
                XmlElement element = xmlDoc.CreateElement(string.Empty,"LicenseVersion",string.Empty);
                XmlText text = xmlDoc.CreateTextNode("LicenseMay2018");
                element.AppendChild(text);
                elemBody.AppendChild(element);
               // xmlDoc.AppendChild(element);
                // Sign the XML document. 
                SignXML(xmlDoc, rsaCsp);
                
                return Convert.ToBase64String(Encoding.UTF8.GetBytes(xmlDoc.OuterXml));


            }
            catch (Exception e)
            {
                //MessageBox.Show(e.Message);
                return string.Empty;
            }
        }

        private static void SignXML(XmlDocument xmlDoc, RSA Key)
        {
            // Check arguments.
            if (xmlDoc == null)
                throw new ArgumentException("xmlDoc");
            if (Key == null)
                throw new ArgumentException("Key");

            // Create a SignedXml object.
            SignedXml signedXml = new SignedXml(xmlDoc);

            // Add the key to the SignedXml document.
            signedXml.SigningKey = Key;

            // Create a reference to be signed.
            Reference reference = new Reference();
            reference.Uri = "";

            // Add an enveloped transformation to the reference.

            XmlDsigEnvelopedSignatureTransform env = new XmlDsigEnvelopedSignatureTransform();
            reference.AddTransform(env);

            // Add the reference to the SignedXml object.
            signedXml.AddReference(reference);

            // Compute the signature.
            signedXml.ComputeSignature();

            // Get the XML representation of the signature and save
            // it to an XmlElement object.
            XmlElement xmlDigitalSignature = signedXml.GetXml();

            // Append the element to the XML document.
            xmlDoc.DocumentElement.AppendChild(xmlDoc.ImportNode(xmlDigitalSignature, true));

        }
    }


    
}
