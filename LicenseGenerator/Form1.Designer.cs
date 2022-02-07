namespace LicenseGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.ch_SiteChild = new System.Windows.Forms.CheckBox();
            this.ch_user = new System.Windows.Forms.CheckBox();
            this.ch_aggMonitor = new System.Windows.Forms.CheckBox();
            this.ch_fault = new System.Windows.Forms.CheckBox();
            this.ch_monitor = new System.Windows.Forms.CheckBox();
            this.ch_device = new System.Windows.Forms.CheckBox();
            this.nm_SiteChild = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nm_user = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.combo_licenseType = new System.Windows.Forms.ComboBox();
            this.nm_aggMonitor = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tx_HardwareCode = new System.Windows.Forms.RichTextBox();
            this.bt_generate = new System.Windows.Forms.Button();
            this.tx_serial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tx_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nm_fault = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nm_monitor = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nm_device = new System.Windows.Forms.NumericUpDown();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SiteChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_user)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_aggMonitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_fault)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_monitor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_device)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.ch_SiteChild);
            this.panel1.Controls.Add(this.ch_user);
            this.panel1.Controls.Add(this.ch_aggMonitor);
            this.panel1.Controls.Add(this.ch_fault);
            this.panel1.Controls.Add(this.ch_monitor);
            this.panel1.Controls.Add(this.ch_device);
            this.panel1.Controls.Add(this.nm_SiteChild);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.nm_user);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.combo_licenseType);
            this.panel1.Controls.Add(this.nm_aggMonitor);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tx_HardwareCode);
            this.panel1.Controls.Add(this.bt_generate);
            this.panel1.Controls.Add(this.tx_serial);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tx_name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nm_fault);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.nm_monitor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.nm_device);
            this.panel1.Location = new System.Drawing.Point(36, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 795);
            this.panel1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(654, 697);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(298, 26);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1180, 703);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "ExpirationDate";
            // 
            // ch_SiteChild
            // 
            this.ch_SiteChild.AutoSize = true;
            this.ch_SiteChild.Location = new System.Drawing.Point(963, 366);
            this.ch_SiteChild.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_SiteChild.Name = "ch_SiteChild";
            this.ch_SiteChild.Size = new System.Drawing.Size(22, 21);
            this.ch_SiteChild.TabIndex = 27;
            this.ch_SiteChild.UseVisualStyleBackColor = true;
            this.ch_SiteChild.CheckedChanged += new System.EventHandler(this.ch_SiteChild_CheckedChanged);
            // 
            // ch_user
            // 
            this.ch_user.AutoSize = true;
            this.ch_user.Location = new System.Drawing.Point(963, 308);
            this.ch_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_user.Name = "ch_user";
            this.ch_user.Size = new System.Drawing.Size(22, 21);
            this.ch_user.TabIndex = 26;
            this.ch_user.UseVisualStyleBackColor = true;
            this.ch_user.CheckedChanged += new System.EventHandler(this.ch_user_CheckedChanged);
            // 
            // ch_aggMonitor
            // 
            this.ch_aggMonitor.AutoSize = true;
            this.ch_aggMonitor.Location = new System.Drawing.Point(963, 248);
            this.ch_aggMonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_aggMonitor.Name = "ch_aggMonitor";
            this.ch_aggMonitor.Size = new System.Drawing.Size(22, 21);
            this.ch_aggMonitor.TabIndex = 25;
            this.ch_aggMonitor.UseVisualStyleBackColor = true;
            this.ch_aggMonitor.CheckedChanged += new System.EventHandler(this.ch_aggMonitor_CheckedChanged);
            // 
            // ch_fault
            // 
            this.ch_fault.AutoSize = true;
            this.ch_fault.Location = new System.Drawing.Point(963, 183);
            this.ch_fault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_fault.Name = "ch_fault";
            this.ch_fault.Size = new System.Drawing.Size(22, 21);
            this.ch_fault.TabIndex = 24;
            this.ch_fault.UseVisualStyleBackColor = true;
            this.ch_fault.CheckedChanged += new System.EventHandler(this.ch_fault_CheckedChanged);
            // 
            // ch_monitor
            // 
            this.ch_monitor.AutoSize = true;
            this.ch_monitor.Location = new System.Drawing.Point(963, 131);
            this.ch_monitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_monitor.Name = "ch_monitor";
            this.ch_monitor.Size = new System.Drawing.Size(22, 21);
            this.ch_monitor.TabIndex = 23;
            this.ch_monitor.UseVisualStyleBackColor = true;
            this.ch_monitor.CheckedChanged += new System.EventHandler(this.ch_monitor_CheckedChanged);
            // 
            // ch_device
            // 
            this.ch_device.AutoSize = true;
            this.ch_device.Location = new System.Drawing.Point(963, 68);
            this.ch_device.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_device.Name = "ch_device";
            this.ch_device.Size = new System.Drawing.Size(22, 21);
            this.ch_device.TabIndex = 22;
            this.ch_device.UseVisualStyleBackColor = true;
            this.ch_device.CheckedChanged += new System.EventHandler(this.ch_device_CheckedChanged);
            // 
            // nm_SiteChild
            // 
            this.nm_SiteChild.Enabled = false;
            this.nm_SiteChild.Location = new System.Drawing.Point(858, 357);
            this.nm_SiteChild.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nm_SiteChild.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nm_SiteChild.Name = "nm_SiteChild";
            this.nm_SiteChild.Size = new System.Drawing.Size(96, 26);
            this.nm_SiteChild.TabIndex = 21;
            this.nm_SiteChild.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1257, 359);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Site";
            // 
            // nm_user
            // 
            this.nm_user.Enabled = false;
            this.nm_user.Location = new System.Drawing.Point(858, 297);
            this.nm_user.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nm_user.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nm_user.Name = "nm_user";
            this.nm_user.Size = new System.Drawing.Size(96, 26);
            this.nm_user.TabIndex = 19;
            this.nm_user.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1251, 307);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1196, 502);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "LicenseType";
            // 
            // combo_licenseType
            // 
            this.combo_licenseType.FormattingEnabled = true;
            this.combo_licenseType.Items.AddRange(new object[] {
            "LicenseMay2018",
            "LicenseTest2019"});
            this.combo_licenseType.Location = new System.Drawing.Point(772, 494);
            this.combo_licenseType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.combo_licenseType.Name = "combo_licenseType";
            this.combo_licenseType.Size = new System.Drawing.Size(180, 28);
            this.combo_licenseType.TabIndex = 14;
            // 
            // nm_aggMonitor
            // 
            this.nm_aggMonitor.Enabled = false;
            this.nm_aggMonitor.Location = new System.Drawing.Point(858, 238);
            this.nm_aggMonitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nm_aggMonitor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nm_aggMonitor.Name = "nm_aggMonitor";
            this.nm_aggMonitor.Size = new System.Drawing.Size(96, 26);
            this.nm_aggMonitor.TabIndex = 13;
            this.nm_aggMonitor.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1153, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "IntergratedMonitor";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1167, 589);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "SystemUniqueId";
            // 
            // tx_HardwareCode
            // 
            this.tx_HardwareCode.Location = new System.Drawing.Point(452, 589);
            this.tx_HardwareCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tx_HardwareCode.Name = "tx_HardwareCode";
            this.tx_HardwareCode.Size = new System.Drawing.Size(500, 62);
            this.tx_HardwareCode.TabIndex = 2;
            this.tx_HardwareCode.Text = "";
            // 
            // bt_generate
            // 
            this.bt_generate.Location = new System.Drawing.Point(20, 595);
            this.bt_generate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_generate.Name = "bt_generate";
            this.bt_generate.Size = new System.Drawing.Size(168, 58);
            this.bt_generate.TabIndex = 3;
            this.bt_generate.Text = "Generate License";
            this.bt_generate.UseVisualStyleBackColor = true;
            this.bt_generate.Click += new System.EventHandler(this.bt_generate_Click);
            // 
            // tx_serial
            // 
            this.tx_serial.Location = new System.Drawing.Point(698, 426);
            this.tx_serial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tx_serial.Name = "tx_serial";
            this.tx_serial.Size = new System.Drawing.Size(254, 26);
            this.tx_serial.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1189, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "SerialNumber";
            // 
            // tx_name
            // 
            this.tx_name.Location = new System.Drawing.Point(698, 12);
            this.tx_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tx_name.Name = "tx_name";
            this.tx_name.Size = new System.Drawing.Size(254, 26);
            this.tx_name.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1184, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "License Name";
            // 
            // nm_fault
            // 
            this.nm_fault.Enabled = false;
            this.nm_fault.Location = new System.Drawing.Point(858, 174);
            this.nm_fault.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nm_fault.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nm_fault.Name = "nm_fault";
            this.nm_fault.Size = new System.Drawing.Size(96, 26);
            this.nm_fault.TabIndex = 6;
            this.nm_fault.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1185, 184);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "WarningRules";
            // 
            // nm_monitor
            // 
            this.nm_monitor.Enabled = false;
            this.nm_monitor.Location = new System.Drawing.Point(858, 120);
            this.nm_monitor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nm_monitor.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nm_monitor.Name = "nm_monitor";
            this.nm_monitor.Size = new System.Drawing.Size(96, 26);
            this.nm_monitor.TabIndex = 4;
            this.nm_monitor.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1232, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mointor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1153, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "SupervisoinedItem";
            // 
            // nm_device
            // 
            this.nm_device.Enabled = false;
            this.nm_device.Location = new System.Drawing.Point(858, 63);
            this.nm_device.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nm_device.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nm_device.Name = "nm_device";
            this.nm_device.Size = new System.Drawing.Size(96, 26);
            this.nm_device.TabIndex = 1;
            this.nm_device.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "licence.lic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 862);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "NMS Lic Generator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SiteChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_user)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_aggMonitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_fault)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_monitor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_device)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nm_monitor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nm_device;
        private System.Windows.Forms.RichTextBox tx_HardwareCode;
        private System.Windows.Forms.Button bt_generate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tx_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nm_fault;
        private System.Windows.Forms.TextBox tx_serial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nm_aggMonitor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox combo_licenseType;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NumericUpDown nm_user;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nm_SiteChild;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ch_SiteChild;
        private System.Windows.Forms.CheckBox ch_user;
        private System.Windows.Forms.CheckBox ch_aggMonitor;
        private System.Windows.Forms.CheckBox ch_fault;
        private System.Windows.Forms.CheckBox ch_monitor;
        private System.Windows.Forms.CheckBox ch_device;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
    }
}

