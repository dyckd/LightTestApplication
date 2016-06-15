namespace Daniels_LightTestApplication
{
    partial class MainForm
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
            this.btn_runtest = new System.Windows.Forms.Button();
            this.label_lightsensor_baudrate = new System.Windows.Forms.Label();
            this.lightsensor_baudrate_db = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lightsensor_databits_db = new System.Windows.Forms.ComboBox();
            this.lightsensor_parity_label = new System.Windows.Forms.Label();
            this.lightsensor_parity_db = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_runtest
            // 
            this.btn_runtest.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_runtest.Location = new System.Drawing.Point(12, 12);
            this.btn_runtest.Name = "btn_runtest";
            this.btn_runtest.Size = new System.Drawing.Size(75, 23);
            this.btn_runtest.TabIndex = 0;
            this.btn_runtest.Text = "&Run Test";
            this.btn_runtest.UseVisualStyleBackColor = false;
            this.btn_runtest.Click += new System.EventHandler(this.btn_runtest_Click);
            // 
            // label_lightsensor_baudrate
            // 
            this.label_lightsensor_baudrate.AutoSize = true;
            this.label_lightsensor_baudrate.Location = new System.Drawing.Point(12, 39);
            this.label_lightsensor_baudrate.Name = "label_lightsensor_baudrate";
            this.label_lightsensor_baudrate.Size = new System.Drawing.Size(112, 13);
            this.label_lightsensor_baudrate.TabIndex = 1;
            this.label_lightsensor_baudrate.Text = "Light Sensor Baudrate";
            // 
            // lightsensor_baudrate_db
            // 
            this.lightsensor_baudrate_db.AllowDrop = true;
            this.lightsensor_baudrate_db.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lightsensor_baudrate_db.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightsensor_baudrate_db.FormattingEnabled = true;
            this.lightsensor_baudrate_db.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.lightsensor_baudrate_db.Location = new System.Drawing.Point(130, 36);
            this.lightsensor_baudrate_db.Name = "lightsensor_baudrate_db";
            this.lightsensor_baudrate_db.Size = new System.Drawing.Size(84, 21);
            this.lightsensor_baudrate_db.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Light Sensor Databits";
            // 
            // lightsensor_databits_db
            // 
            this.lightsensor_databits_db.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lightsensor_databits_db.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightsensor_databits_db.FormattingEnabled = true;
            this.lightsensor_databits_db.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.lightsensor_databits_db.Location = new System.Drawing.Point(130, 63);
            this.lightsensor_databits_db.Name = "lightsensor_databits_db";
            this.lightsensor_databits_db.Size = new System.Drawing.Size(84, 21);
            this.lightsensor_databits_db.TabIndex = 4;
            // 
            // lightsensor_parity_label
            // 
            this.lightsensor_parity_label.AutoSize = true;
            this.lightsensor_parity_label.Location = new System.Drawing.Point(12, 93);
            this.lightsensor_parity_label.Name = "lightsensor_parity_label";
            this.lightsensor_parity_label.Size = new System.Drawing.Size(95, 13);
            this.lightsensor_parity_label.TabIndex = 6;
            this.lightsensor_parity_label.Text = "Light Sensor Parity";
            // 
            // lightsensor_parity_db
            // 
            this.lightsensor_parity_db.AllowDrop = true;
            this.lightsensor_parity_db.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lightsensor_parity_db.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightsensor_parity_db.FormattingEnabled = true;
            this.lightsensor_parity_db.Items.AddRange(new object[] {
            "Even",
            "Odd",
            "None"});
            this.lightsensor_parity_db.Location = new System.Drawing.Point(130, 90);
            this.lightsensor_parity_db.Name = "lightsensor_parity_db";
            this.lightsensor_parity_db.Size = new System.Drawing.Size(84, 21);
            this.lightsensor_parity_db.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 183);
            this.Controls.Add(this.lightsensor_parity_db);
            this.Controls.Add(this.lightsensor_parity_label);
            this.Controls.Add(this.lightsensor_databits_db);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lightsensor_baudrate_db);
            this.Controls.Add(this.label_lightsensor_baudrate);
            this.Controls.Add(this.btn_runtest);
            this.Name = "MainForm";
            this.Text = "Light Test Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_runtest;
        private System.Windows.Forms.Label label_lightsensor_baudrate;
        private System.Windows.Forms.ComboBox lightsensor_baudrate_db;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lightsensor_databits_db;
        private System.Windows.Forms.Label lightsensor_parity_label;
        private System.Windows.Forms.ComboBox lightsensor_parity_db;
    }
}

