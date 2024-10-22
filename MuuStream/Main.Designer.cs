namespace MuuStream
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lbxChat = new ListBox();
            tabPage2 = new TabPage();
            btnReset = new Button();
            btnApply = new Button();
            cbxChannelAsUsername = new CheckBox();
            btnConnect = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtOAuth = new TextBox();
            txtUsername = new TextBox();
            txtChannel = new TextBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(913, 543);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbxChat);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(905, 509);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Chat";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbxChat
            // 
            lbxChat.BorderStyle = BorderStyle.FixedSingle;
            lbxChat.Dock = DockStyle.Fill;
            lbxChat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbxChat.FormattingEnabled = true;
            lbxChat.ItemHeight = 21;
            lbxChat.Location = new Point(3, 3);
            lbxChat.Name = "lbxChat";
            lbxChat.Size = new Size(899, 503);
            lbxChat.TabIndex = 3;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnReset);
            tabPage2.Controls.Add(btnApply);
            tabPage2.Controls.Add(cbxChannelAsUsername);
            tabPage2.Controls.Add(btnConnect);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(txtOAuth);
            tabPage2.Controls.Add(txtUsername);
            tabPage2.Controls.Add(txtChannel);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(905, 509);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Options";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Enabled = false;
            btnReset.Location = new Point(384, 118);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(182, 30);
            btnReset.TabIndex = 9;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += BtnReset_Click;
            // 
            // btnApply
            // 
            btnApply.Location = new Point(196, 118);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(182, 30);
            btnApply.TabIndex = 8;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += BtnApply_Click;
            // 
            // cbxChannelAsUsername
            // 
            cbxChannelAsUsername.AutoSize = true;
            cbxChannelAsUsername.Location = new Point(406, 85);
            cbxChannelAsUsername.Name = "cbxChannelAsUsername";
            cbxChannelAsUsername.Size = new Size(164, 25);
            cbxChannelAsUsername.TabIndex = 7;
            cbxChannelAsUsername.Text = "Same As Username";
            cbxChannelAsUsername.UseVisualStyleBackColor = true;
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(8, 118);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(182, 30);
            btnConnect.TabIndex = 6;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += BtnConnect_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 86);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 5;
            label3.Text = "Channel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 56);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 4;
            label2.Text = "OAuth Key:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 26);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 3;
            label1.Text = "Username:";
            // 
            // txtOAuth
            // 
            txtOAuth.Location = new Point(109, 53);
            txtOAuth.Name = "txtOAuth";
            txtOAuth.PasswordChar = '*';
            txtOAuth.Size = new Size(291, 29);
            txtOAuth.TabIndex = 2;
            txtOAuth.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(109, 23);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(291, 29);
            txtUsername.TabIndex = 1;
            // 
            // txtChannel
            // 
            txtChannel.Location = new Point(109, 83);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(291, 29);
            txtChannel.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 543);
            Controls.Add(tabControl1);
            Name = "Main";
            Text = "MuuStream";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ListBox lbxChat;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtOAuth;
        private TextBox txtUsername;
        private TextBox txtChannel;
        private CheckBox cbxChannelAsUsername;
        private Button btnConnect;
        private Button btnApply;
        private Button btnReset;
    }
}
