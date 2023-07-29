namespace RnDProject.Pages
{
    partial class PagePost
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textUsername = new TextBox();
            textPassword = new TextBox();
            btn_login = new Button();
            label4 = new Label();
            lbUserData = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(478, 53);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 0;
            label1.Text = "Login Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 164);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 241);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // textUsername
            // 
            textUsername.Location = new Point(436, 164);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(252, 27);
            textUsername.TabIndex = 3;
            // 
            // textPassword
            // 
            textPassword.Location = new Point(436, 238);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(252, 27);
            textPassword.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(441, 316);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(232, 47);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(127, 445);
            label4.Name = "label4";
            label4.Size = new Size(189, 20);
            label4.TabIndex = 6;
            label4.Text = "Response Login Show Here";
            // 
            // lbUserData
            // 
            lbUserData.AutoSize = true;
            lbUserData.Location = new Point(127, 479);
            lbUserData.Name = "lbUserData";
            lbUserData.Size = new Size(0, 20);
            lbUserData.TabIndex = 7;
            // 
            // PagePost
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(lbUserData);
            Controls.Add(label4);
            Controls.Add(btn_login);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PagePost";
            Size = new Size(1140, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textUsername;
        private TextBox textPassword;
        private Button btn_login;
        private Label label4;
        private Label lbUserData;
    }
}
