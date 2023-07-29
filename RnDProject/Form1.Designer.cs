namespace RnDProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btn_menu_get = new Guna.UI2.WinForms.Guna2Button();
            btn_menu_post = new Guna.UI2.WinForms.Guna2Button();
            btn_menu_websocket = new Guna.UI2.WinForms.Guna2Button();
            btn_menu_home = new Guna.UI2.WinForms.Guna2Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 81);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(121, 21);
            label1.Name = "label1";
            label1.Size = new Size(201, 38);
            label1.TabIndex = 1;
            label1.Text = "#Explore Now";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Highlight;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btn_menu_get);
            panel2.Controls.Add(btn_menu_post);
            panel2.Controls.Add(btn_menu_websocket);
            panel2.Controls.Add(btn_menu_home);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new Size(1122, 52);
            panel2.TabIndex = 1;
            // 
            // btn_menu_get
            // 
            btn_menu_get.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn_menu_get.CheckedState.CustomBorderColor = Color.Red;
            btn_menu_get.CustomBorderColor = Color.White;
            btn_menu_get.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btn_menu_get.CustomizableEdges = customizableEdges1;
            btn_menu_get.DisabledState.BorderColor = Color.DarkGray;
            btn_menu_get.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_menu_get.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_menu_get.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_menu_get.FillColor = Color.White;
            btn_menu_get.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_menu_get.ForeColor = Color.Black;
            btn_menu_get.HoverState.CustomBorderColor = Color.Red;
            btn_menu_get.Location = new Point(561, 3);
            btn_menu_get.Name = "btn_menu_get";
            btn_menu_get.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btn_menu_get.Size = new Size(180, 45);
            btn_menu_get.TabIndex = 3;
            btn_menu_get.Text = "Get";
            btn_menu_get.Click += btn_menu_get_Click;
            // 
            // btn_menu_post
            // 
            btn_menu_post.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn_menu_post.CheckedState.CustomBorderColor = Color.Red;
            btn_menu_post.CustomBorderColor = Color.White;
            btn_menu_post.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btn_menu_post.CustomizableEdges = customizableEdges3;
            btn_menu_post.DisabledState.BorderColor = Color.DarkGray;
            btn_menu_post.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_menu_post.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_menu_post.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_menu_post.FillColor = Color.White;
            btn_menu_post.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_menu_post.ForeColor = Color.Black;
            btn_menu_post.HoverState.CustomBorderColor = Color.Red;
            btn_menu_post.Location = new Point(375, 2);
            btn_menu_post.Name = "btn_menu_post";
            btn_menu_post.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btn_menu_post.Size = new Size(180, 45);
            btn_menu_post.TabIndex = 2;
            btn_menu_post.Text = "Post";
            btn_menu_post.Click += btn_menu_post_Click;
            // 
            // btn_menu_websocket
            // 
            btn_menu_websocket.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn_menu_websocket.CheckedState.CustomBorderColor = Color.Red;
            btn_menu_websocket.CustomBorderColor = Color.White;
            btn_menu_websocket.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btn_menu_websocket.CustomizableEdges = customizableEdges5;
            btn_menu_websocket.DisabledState.BorderColor = Color.DarkGray;
            btn_menu_websocket.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_menu_websocket.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_menu_websocket.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_menu_websocket.FillColor = Color.White;
            btn_menu_websocket.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_menu_websocket.ForeColor = Color.Black;
            btn_menu_websocket.HoverState.CustomBorderColor = Color.Red;
            btn_menu_websocket.Location = new Point(189, 2);
            btn_menu_websocket.Name = "btn_menu_websocket";
            btn_menu_websocket.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btn_menu_websocket.Size = new Size(180, 45);
            btn_menu_websocket.TabIndex = 1;
            btn_menu_websocket.Text = "Websocket";
            btn_menu_websocket.Click += btn_menu_websocket_Click;
            // 
            // btn_menu_home
            // 
            btn_menu_home.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            btn_menu_home.Checked = true;
            btn_menu_home.CheckedState.CustomBorderColor = Color.Red;
            btn_menu_home.CustomBorderColor = Color.White;
            btn_menu_home.CustomBorderThickness = new Padding(0, 0, 0, 3);
            btn_menu_home.CustomizableEdges = customizableEdges7;
            btn_menu_home.DisabledState.BorderColor = Color.DarkGray;
            btn_menu_home.DisabledState.CustomBorderColor = Color.DarkGray;
            btn_menu_home.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btn_menu_home.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btn_menu_home.FillColor = Color.White;
            btn_menu_home.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_menu_home.ForeColor = Color.Black;
            btn_menu_home.HoverState.CustomBorderColor = Color.Red;
            btn_menu_home.Location = new Point(3, 4);
            btn_menu_home.Name = "btn_menu_home";
            btn_menu_home.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btn_menu_home.Size = new Size(180, 45);
            btn_menu_home.TabIndex = 0;
            btn_menu_home.Text = "Home";
            btn_menu_home.Click += btn_menu_home_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = Color.White;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 133);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1122, 620);
            panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 753);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RndProject";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelContainer;
        private PictureBox pictureBox1;
        private Label label1;
        private Guna.UI2.WinForms.Guna2Button btn_menu_home;
        private Guna.UI2.WinForms.Guna2Button btn_menu_post;
        private Guna.UI2.WinForms.Guna2Button btn_menu_websocket;
        private Guna.UI2.WinForms.Guna2Button btn_menu_get;
    }
}