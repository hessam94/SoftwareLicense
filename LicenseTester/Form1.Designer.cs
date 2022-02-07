namespace LicenseTester
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
            this.tx_ActivationCode = new System.Windows.Forms.RichTextBox();
            this.tx_HardwareCode = new System.Windows.Forms.TextBox();
            this.bt_verify = new System.Windows.Forms.Button();
            this.bt_byte = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tx_ActivationCode
            // 
            this.tx_ActivationCode.Location = new System.Drawing.Point(46, 171);
            this.tx_ActivationCode.Name = "tx_ActivationCode";
            this.tx_ActivationCode.Size = new System.Drawing.Size(589, 291);
            this.tx_ActivationCode.TabIndex = 0;
            this.tx_ActivationCode.Text = "";
            // 
            // tx_HardwareCode
            // 
            this.tx_HardwareCode.Location = new System.Drawing.Point(56, 60);
            this.tx_HardwareCode.Name = "tx_HardwareCode";
            this.tx_HardwareCode.Size = new System.Drawing.Size(446, 20);
            this.tx_HardwareCode.TabIndex = 1;
            // 
            // bt_verify
            // 
            this.bt_verify.Location = new System.Drawing.Point(56, 104);
            this.bt_verify.Name = "bt_verify";
            this.bt_verify.Size = new System.Drawing.Size(162, 38);
            this.bt_verify.TabIndex = 2;
            this.bt_verify.Text = "Verify";
            this.bt_verify.UseVisualStyleBackColor = true;
            this.bt_verify.Click += new System.EventHandler(this.bt_verify_Click);
            // 
            // bt_byte
            // 
            this.bt_byte.Location = new System.Drawing.Point(343, 104);
            this.bt_byte.Name = "bt_byte";
            this.bt_byte.Size = new System.Drawing.Size(113, 37);
            this.bt_byte.TabIndex = 3;
            this.bt_byte.Text = "fileToByte";
            this.bt_byte.UseVisualStyleBackColor = true;
            this.bt_byte.Click += new System.EventHandler(this.bt_byte_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 503);
            this.Controls.Add(this.bt_byte);
            this.Controls.Add(this.bt_verify);
            this.Controls.Add(this.tx_HardwareCode);
            this.Controls.Add(this.tx_ActivationCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tx_ActivationCode;
        private System.Windows.Forms.TextBox tx_HardwareCode;
        private System.Windows.Forms.Button bt_verify;
        private System.Windows.Forms.Button bt_byte;
    }
}

