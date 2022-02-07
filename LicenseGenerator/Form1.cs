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

namespace LicenseGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combo_licenseType.SelectedIndex = 0;
        }

        private void bt_generate_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(tx_HardwareCode.Text) || string.IsNullOrEmpty(tx_name.Text))
                {
                    MessageBox.Show("شناسه سیستم و نام مجوز نمی توانند خالی باشد");
                }
                else
                {
                    string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

                    // select type of the derived class and instantiate a new object of it
                    var className = GetLicenseType(combo_licenseType.SelectedItem.ToString());
                    var handle = Activator.CreateInstance(assemblyName, className);
                    var instance = (ILicense)handle.Unwrap();

                    var model = instance.GenerateLicenseModel(SetControls());
                    var str = instance.GenerateSignature(model);
                    //richTextBox1.Text = str;
                    //. this name, license.lic, MUST not be changed , because the NMS read and get 
                    // from the exact file by name of licence.lic
                    if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                    {
                        string path = folderBrowserDialog1.SelectedPath;
                        File.WriteAllText(path + "\\license.lic", str);
                    }
                    MessageBox.Show("مجوز با موفقیت تولید شد");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در تولید مجوز");
            }

        }
        // set all of hte controls, but use contorls which you need 
        // because we do not know which type of license will be used at runtime
        private InputLicense SetControls()
        {
            InputLicense inputLicense = new InputLicense();
            inputLicense.ManagedObjectCount = ch_device.Checked ? (int?)nm_device.Value : null;
            inputLicense.MonitorCount = ch_monitor.Checked ? (int?)nm_monitor.Value : null;
            inputLicense.FaultCount = ch_fault.Checked ? (int?)nm_fault.Value : null;
            inputLicense.LicenseName = tx_name.Text;
            inputLicense.UniqueId = tx_HardwareCode.Text.Trim();
            inputLicense.LicenseSerialNumber = tx_serial.Text;
            inputLicense.AggregateMonitorCount = ch_aggMonitor.Checked ? (int?)nm_aggMonitor.Value : null;
            inputLicense.UserCount = ch_user.Checked ? (int?)nm_user.Value : null;
            inputLicense.SiteChildCount = ch_SiteChild.Checked ? (int?)nm_SiteChild.Value : null;
            inputLicense.ExpirationDate = dateTimePicker1.Value;
            return inputLicense;
        }

        private string GetLicenseType(string name)
        {
            switch (name)
            {
                case "LicenseMay2018":
                    return typeof(LicenseMay2018).AssemblyQualifiedName.Split(',')[0];
                case "LicenseTest2019":
                    return typeof(LicenseTest2019).AssemblyQualifiedName.Split(',')[0];
                default:
                    return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LicenseTest2019 license = new LicenseTest2019
            {
                x = 15
            };
            using (StringWriter stream = new StringWriter())
            {

                var settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.OmitXmlDeclaration = true;
                XmlWriter writer = XmlWriter.Create(stream, settings);

                XmlDocument xmlDoc = new XmlDocument();
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();

                //Add an empty namespace and empty value
                ns.Add("", "");
                XmlSerializer serializer = new XmlSerializer(typeof(LicenseTest2019));
                // serializer.Serialize(wrt, license, ns);
                serializer.Serialize(writer, license, ns);
                XmlText textMain = xmlDoc.CreateTextNode(stream.ToString());

            }
        }

        private void ch_device_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_device.Checked)
                nm_device.Enabled = true;
            else
                nm_device.Enabled = false;
        }

        private void ch_monitor_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_monitor.Checked)
                nm_monitor.Enabled = true;
            else
                nm_monitor.Enabled = false;
        }

        private void ch_fault_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_fault.Checked)
                nm_fault.Enabled = true;
            else
                nm_fault.Enabled = false;
        }

        private void ch_aggMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_aggMonitor.Checked)
                nm_aggMonitor.Enabled = true;
            else
                nm_aggMonitor.Enabled = false;
        }

        private void ch_user_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_user.Checked)
                nm_user.Enabled = true;
            else
                nm_user.Enabled = false;
        }

        private void ch_SiteChild_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_SiteChild.Checked)
                nm_SiteChild.Enabled = true;
            else
                nm_SiteChild.Enabled = false;
        }


    }
}
