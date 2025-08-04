namespace FormMenu
{
    partial class FormDeleteUser
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
            txtIdUserToDelete = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtIdUserToDelete
            // 
            txtIdUserToDelete.Location = new Point(173, 10);
            txtIdUserToDelete.Name = "txtIdUserToDelete";
            txtIdUserToDelete.Size = new Size(264, 23);
            txtIdUserToDelete.TabIndex = 0;
            txtIdUserToDelete.KeyPress += TxtSoloNumeros_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 1;
            label1.Text = "Id de Usuario a Borrar";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Red;
            button1.Location = new Point(163, 52);
            button1.Name = "button1";
            button1.Size = new Size(155, 32);
            button1.TabIndex = 2;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnDelete_Click;
            // 
            // FormDeleteUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 96);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtIdUserToDelete);
            Name = "FormDeleteUser";
            Text = "FormDeleteUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIdUserToDelete;
        private Label label1;
        private Button button1;
    }
}