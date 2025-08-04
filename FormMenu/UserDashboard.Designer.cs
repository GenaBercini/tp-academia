namespace FormMenu
{
    partial class UserDashboard
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
            dataUsersPanel = new DataGridView();
            btnAddUser = new Button();
            button1 = new Button();
            button2 = new Button();
            lblNoData = new Label();
            ((System.ComponentModel.ISupportInitialize)dataUsersPanel).BeginInit();
            SuspendLayout();
            // 
            // dataUsersPanel
            // 
            dataUsersPanel.AllowUserToAddRows = false;
            dataUsersPanel.AllowUserToDeleteRows = false;
            dataUsersPanel.AllowUserToResizeColumns = false;
            dataUsersPanel.AllowUserToResizeRows = false;
            dataUsersPanel.BackgroundColor = SystemColors.Control;
            dataUsersPanel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataUsersPanel.Dock = DockStyle.Bottom;
            dataUsersPanel.GridColor = SystemColors.InactiveBorder;
            dataUsersPanel.ImeMode = ImeMode.On;
            dataUsersPanel.Location = new Point(0, 53);
            dataUsersPanel.MultiSelect = false;
            dataUsersPanel.Name = "dataUsersPanel";
            dataUsersPanel.ReadOnly = true;
            dataUsersPanel.RowHeadersVisible = false;
            dataUsersPanel.Size = new Size(1133, 492);
            dataUsersPanel.TabIndex = 0;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(12, 6);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(100, 29);
            btnAddUser.TabIndex = 1;
            btnAddUser.Text = "Agregar";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += BtnNewUser_Click;
            // 
            // button1
            // 
            button1.Location = new Point(118, 6);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 2;
            button1.Text = "Borrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnDeleteUser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(224, 6);
            button2.Name = "button2";
            button2.Size = new Size(100, 29);
            button2.TabIndex = 3;
            button2.Text = "Actualizar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnUpdateUser_Click;
            // 
            // lblNoData
            // 
            lblNoData.AutoSize = true;
            lblNoData.Location = new Point(490, 268);
            lblNoData.Name = "lblNoData";
            lblNoData.Size = new Size(155, 15);
            lblNoData.TabIndex = 4;
            lblNoData.Text = "No hay usuarios disponibles";
            lblNoData.TextAlign = ContentAlignment.MiddleCenter;
            lblNoData.Visible = false;
            // 
            // UserDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1133, 545);
            Controls.Add(lblNoData);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnAddUser);
            Controls.Add(dataUsersPanel);
            Name = "UserDashboard";
            Text = "UserDashboard";
            Load += UserDashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataUsersPanel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataUsersPanel;
        private Button btnAddUser;
        private Button button1;
        private Button button2;
        private Label lblNoData;
    }
}