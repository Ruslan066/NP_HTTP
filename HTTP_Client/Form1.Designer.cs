namespace HTTP_Client
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
            this.response = new System.Windows.Forms.TextBox();
            this.URL = new System.Windows.Forms.TextBox();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.IfProxy = new System.Windows.Forms.CheckBox();
            this.proxyAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.proxyUser = new System.Windows.Forms.TextBox();
            this.proxyPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.listLinks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // response
            // 
            this.response.Location = new System.Drawing.Point(12, 136);
            this.response.Multiline = true;
            this.response.Name = "response";
            this.response.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.response.Size = new System.Drawing.Size(663, 538);
            this.response.TabIndex = 0;
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(92, 13);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(385, 20);
            this.URL.TabIndex = 1;
            this.URL.Text = "https://obmenka24.mk.ua/";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 74);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(663, 56);
            this.inputBox.TabIndex = 2;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(483, 13);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(192, 23);
            this.sendButton.TabIndex = 3;
            this.sendButton.Text = "send";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "URL";
            // 
            // IfProxy
            // 
            this.IfProxy.AutoSize = true;
            this.IfProxy.Checked = true;
            this.IfProxy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IfProxy.Location = new System.Drawing.Point(15, 44);
            this.IfProxy.Name = "IfProxy";
            this.IfProxy.Size = new System.Drawing.Size(71, 17);
            this.IfProxy.TabIndex = 5;
            this.IfProxy.Text = "use proxy";
            this.IfProxy.UseVisualStyleBackColor = true;
            // 
            // proxyAddr
            // 
            this.proxyAddr.Location = new System.Drawing.Point(167, 45);
            this.proxyAddr.Name = "proxyAddr";
            this.proxyAddr.Size = new System.Drawing.Size(117, 20);
            this.proxyAddr.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "address proxy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "user";
            // 
            // proxyUser
            // 
            this.proxyUser.Location = new System.Drawing.Point(323, 45);
            this.proxyUser.Name = "proxyUser";
            this.proxyUser.Size = new System.Drawing.Size(100, 20);
            this.proxyUser.TabIndex = 9;
            // 
            // proxyPassword
            // 
            this.proxyPassword.Location = new System.Drawing.Point(487, 48);
            this.proxyPassword.Name = "proxyPassword";
            this.proxyPassword.PasswordChar = '&';
            this.proxyPassword.Size = new System.Drawing.Size(100, 20);
            this.proxyPassword.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "password";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(695, 12);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(152, 114);
            this.webBrowser.TabIndex = 12;
            // 
            // listLinks
            // 
            this.listLinks.FormattingEnabled = true;
            this.listLinks.Location = new System.Drawing.Point(695, 154);
            this.listLinks.Name = "listLinks";
            this.listLinks.Size = new System.Drawing.Size(314, 433);
            this.listLinks.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 675);
            this.Controls.Add(this.listLinks);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.proxyPassword);
            this.Controls.Add(this.proxyUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.proxyAddr);
            this.Controls.Add(this.IfProxy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.response);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox response;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox IfProxy;
        private System.Windows.Forms.TextBox proxyAddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox proxyUser;
        private System.Windows.Forms.TextBox proxyPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ListBox listLinks;
    }
}

