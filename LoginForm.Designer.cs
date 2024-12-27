namespace BF_Client
{
    partial class LoginForm
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
            label1 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            label2 = new Label();
            Ok = new Button();
            textBoxURL = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 52);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxLogin.Location = new Point(137, 49);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(405, 31);
            textBoxLogin.TabIndex = 1;
            textBoxLogin.WordWrap = false;
            textBoxLogin.KeyUp += TextBox_KeyUp;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.Location = new Point(137, 86);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(405, 31);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.WordWrap = false;
            textBoxPassword.KeyUp += TextBox_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 89);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // Ok
            // 
            Ok.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Ok.DialogResult = DialogResult.OK;
            Ok.Location = new Point(219, 137);
            Ok.Name = "Ok";
            Ok.Size = new Size(112, 34);
            Ok.TabIndex = 3;
            Ok.Text = "Ok";
            Ok.UseVisualStyleBackColor = true;
            // 
            // textBoxURL
            // 
            textBoxURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxURL.Location = new Point(137, 12);
            textBoxURL.Name = "textBoxURL";
            textBoxURL.Size = new Size(405, 31);
            textBoxURL.TabIndex = 4;
            textBoxURL.Text = "http://localhost:32770";
            textBoxURL.WordWrap = false;
            textBoxURL.KeyUp += TextBox_KeyUp;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 15);
            label3.Name = "label3";
            label3.Size = new Size(101, 25);
            label3.TabIndex = 5;
            label3.Text = "Server URL:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(554, 183);
            Controls.Add(textBoxURL);
            Controls.Add(label3);
            Controls.Add(Ok);
            Controls.Add(textBoxPassword);
            Controls.Add(label2);
            Controls.Add(textBoxLogin);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TopMost = true;
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Label label2;
        private Button Ok;
        private TextBox textBoxURL;
        private Label label3;
    }
}