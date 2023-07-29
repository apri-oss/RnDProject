namespace RnDProject.Pages
{
    partial class PageWebsocket
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
            label4 = new Label();
            btn_try_websocket = new Button();
            lblDataWebsocket = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(468, 79);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 1;
            label1.Text = "Websocket Menu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 146);
            label4.Name = "label4";
            label4.Size = new Size(178, 20);
            label4.TabIndex = 8;
            label4.Text = "show websocket example";
            // 
            // btn_try_websocket
            // 
            btn_try_websocket.Location = new Point(419, 140);
            btn_try_websocket.Name = "btn_try_websocket";
            btn_try_websocket.Size = new Size(224, 32);
            btn_try_websocket.TabIndex = 10;
            btn_try_websocket.Text = "Click Here";
            btn_try_websocket.UseVisualStyleBackColor = true;
            btn_try_websocket.Click += btn_try_websocket_Click;
            // 
            // lblDataWebsocket
            // 
            lblDataWebsocket.AutoSize = true;
            lblDataWebsocket.Location = new Point(186, 212);
            lblDataWebsocket.Name = "lblDataWebsocket";
            lblDataWebsocket.Size = new Size(0, 20);
            lblDataWebsocket.TabIndex = 11;
            // 
            // PageWebsocket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblDataWebsocket);
            Controls.Add(btn_try_websocket);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "PageWebsocket";
            Size = new Size(1140, 800);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Button btn_try_websocket;
        private Label lblDataWebsocket;
    }
}
