namespace HostedDomains_Spoofer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sitenameTextBox = new System.Windows.Forms.TextBox();
            this.hostIpTextBox = new System.Windows.Forms.TextBox();
            this.sitenameRadioButton = new System.Windows.Forms.RadioButton();
            this.hostIpRadioButton = new System.Windows.Forms.RadioButton();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultsCountLabel = new System.Windows.Forms.Label();
            this.exportButton = new System.Windows.Forms.Button();
            this.keepDomainNamesOnlyButton = new System.Windows.Forms.Button();
            this.removeDuplicatesButton = new System.Windows.Forms.Button();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sitenameTextBox);
            this.groupBox1.Controls.Add(this.hostIpTextBox);
            this.groupBox1.Controls.Add(this.sitenameRadioButton);
            this.groupBox1.Controls.Add(this.hostIpRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 73);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server info";
            // 
            // sitenameTextBox
            // 
            this.sitenameTextBox.Enabled = false;
            this.sitenameTextBox.Location = new System.Drawing.Point(88, 41);
            this.sitenameTextBox.Name = "sitenameTextBox";
            this.sitenameTextBox.Size = new System.Drawing.Size(358, 20);
            this.sitenameTextBox.TabIndex = 3;
            // 
            // hostIpTextBox
            // 
            this.hostIpTextBox.Enabled = false;
            this.hostIpTextBox.Location = new System.Drawing.Point(88, 16);
            this.hostIpTextBox.Name = "hostIpTextBox";
            this.hostIpTextBox.Size = new System.Drawing.Size(358, 20);
            this.hostIpTextBox.TabIndex = 2;
            // 
            // sitenameRadioButton
            // 
            this.sitenameRadioButton.AutoSize = true;
            this.sitenameRadioButton.Location = new System.Drawing.Point(6, 42);
            this.sitenameRadioButton.Name = "sitenameRadioButton";
            this.sitenameRadioButton.Size = new System.Drawing.Size(72, 17);
            this.sitenameRadioButton.TabIndex = 1;
            this.sitenameRadioButton.Text = "Sitename:";
            this.sitenameRadioButton.UseVisualStyleBackColor = true;
            this.sitenameRadioButton.CheckedChanged += new System.EventHandler(this.sitenameRadioButton_CheckedChanged);
            // 
            // hostIpRadioButton
            // 
            this.hostIpRadioButton.AutoSize = true;
            this.hostIpRadioButton.Location = new System.Drawing.Point(6, 19);
            this.hostIpRadioButton.Name = "hostIpRadioButton";
            this.hostIpRadioButton.Size = new System.Drawing.Size(61, 17);
            this.hostIpRadioButton.TabIndex = 0;
            this.hostIpRadioButton.Text = "Host ip:";
            this.hostIpRadioButton.UseVisualStyleBackColor = true;
            this.hostIpRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(100, 91);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(124, 23);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "Submit Query";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultsCountLabel);
            this.groupBox2.Controls.Add(this.exportButton);
            this.groupBox2.Controls.Add(this.keepDomainNamesOnlyButton);
            this.groupBox2.Controls.Add(this.removeDuplicatesButton);
            this.groupBox2.Controls.Add(this.resultBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 335);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results";
            // 
            // resultsCountLabel
            // 
            this.resultsCountLabel.AutoSize = true;
            this.resultsCountLabel.Location = new System.Drawing.Point(7, 316);
            this.resultsCountLabel.Name = "resultsCountLabel";
            this.resultsCountLabel.Size = new System.Drawing.Size(54, 13);
            this.resultsCountLabel.TabIndex = 4;
            this.resultsCountLabel.Text = "Results: 0";
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(295, 286);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(151, 23);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // keepDomainNamesOnlyButton
            // 
            this.keepDomainNamesOnlyButton.Location = new System.Drawing.Point(152, 286);
            this.keepDomainNamesOnlyButton.Name = "keepDomainNamesOnlyButton";
            this.keepDomainNamesOnlyButton.Size = new System.Drawing.Size(137, 23);
            this.keepDomainNamesOnlyButton.TabIndex = 2;
            this.keepDomainNamesOnlyButton.Text = "Keep only domain names";
            this.keepDomainNamesOnlyButton.UseVisualStyleBackColor = true;
            this.keepDomainNamesOnlyButton.Click += new System.EventHandler(this.keepDomainNamesOnlyButton_Click);
            // 
            // removeDuplicatesButton
            // 
            this.removeDuplicatesButton.Location = new System.Drawing.Point(6, 286);
            this.removeDuplicatesButton.Name = "removeDuplicatesButton";
            this.removeDuplicatesButton.Size = new System.Drawing.Size(140, 23);
            this.removeDuplicatesButton.TabIndex = 1;
            this.removeDuplicatesButton.Text = "Remove duplicate";
            this.removeDuplicatesButton.UseVisualStyleBackColor = true;
            this.removeDuplicatesButton.Click += new System.EventHandler(this.removeDuplicatesButton_Click);
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(6, 19);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(440, 261);
            this.resultBox.TabIndex = 0;
            this.resultBox.Text = "";
            this.resultBox.TextChanged += new System.EventHandler(this.resultBox_TextChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(230, 91);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(124, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 509);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(470, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Green;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(15, 484);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(298, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.yougetsignal.com/tools/web-sites-on-web-server/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 531);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hosted Domains on Server Spoofer - Powered by bing engine";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox sitenameTextBox;
        private System.Windows.Forms.TextBox hostIpTextBox;
        private System.Windows.Forms.RadioButton sitenameRadioButton;
        private System.Windows.Forms.RadioButton hostIpRadioButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Button keepDomainNamesOnlyButton;
        private System.Windows.Forms.Button removeDuplicatesButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label resultsCountLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

