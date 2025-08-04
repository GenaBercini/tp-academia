namespace FormMenu
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
            Panel = new Panel();
            button1 = new Button();
            btnUsers = new Button();
            userPanel = new Panel();
            Panel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel
            // 
            Panel.BackColor = SystemColors.ActiveCaption;
            Panel.Controls.Add(button1);
            Panel.Controls.Add(btnUsers);
            Panel.Dock = DockStyle.Left;
            Panel.Location = new Point(0, 0);
            Panel.Name = "Panel";
            Panel.Size = new Size(110, 543);
            Panel.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(0, 95);
            button1.Name = "button1";
            button1.Size = new Size(110, 35);
            button1.TabIndex = 1;
            button1.Text = "Otro";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOtros_Click;
            // 
            // btnUsers
            // 
            btnUsers.Location = new Point(0, 41);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(110, 35);
            btnUsers.TabIndex = 0;
            btnUsers.Text = "Usuarios";
            btnUsers.UseVisualStyleBackColor = true;
            btnUsers.Click += btnUsuarios_Click;
            // 
            // userPanel
            // 
            userPanel.Dock = DockStyle.Fill;
            userPanel.Location = new Point(110, 0);
            userPanel.Name = "userPanel";
            userPanel.Size = new Size(1024, 543);
            userPanel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 543);
            Controls.Add(userPanel);
            Controls.Add(Panel);
            IsMdiContainer = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel;
        private Button button1;
        private Button btnUsers;
        private Panel userPanel;
    }
}
