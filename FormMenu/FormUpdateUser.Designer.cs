namespace FormMenu
{
    partial class FormUpdateUser
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
            txtIdUserToUpdate = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnUpdate = new Button();
            ckbCambiaClave = new CheckBox();
            ckbHabilitado = new CheckBox();
            label5 = new Label();
            txtIdPersona = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtApellido = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtClave = new TextBox();
            label7 = new Label();
            txtNombreUsuario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 15);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 3;
            label1.Text = "Id de Usuario a Borrar";
            // 
            // txtIdUserToUpdate
            // 
            txtIdUserToUpdate.Location = new Point(274, 11);
            txtIdUserToUpdate.Name = "txtIdUserToUpdate";
            txtIdUserToUpdate.Size = new Size(264, 23);
            txtIdUserToUpdate.TabIndex = 2;
            txtIdUserToUpdate.KeyPress += TxtSoloNumeros_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(544, 11);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BtnSearchUserToUpdate_Click;
            // 
            // button2
            // 
            button2.Location = new Point(399, 258);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 46;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnCancelUpdate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.GradientActiveCaption;
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(292, 258);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 45;
            btnUpdate.Text = "Actualizar";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += BtnSendUpdateUser_Click;
            // 
            // ckbCambiaClave
            // 
            ckbCambiaClave.AutoSize = true;
            ckbCambiaClave.Enabled = false;
            ckbCambiaClave.Location = new Point(216, 233);
            ckbCambiaClave.Name = "ckbCambiaClave";
            ckbCambiaClave.Size = new Size(99, 19);
            ckbCambiaClave.TabIndex = 44;
            ckbCambiaClave.Text = "Cambia Clave";
            ckbCambiaClave.UseVisualStyleBackColor = true;
            // 
            // ckbHabilitado
            // 
            ckbHabilitado.AutoSize = true;
            ckbHabilitado.Enabled = false;
            ckbHabilitado.Location = new Point(465, 233);
            ckbHabilitado.Name = "ckbHabilitado";
            ckbHabilitado.Size = new Size(81, 19);
            ckbHabilitado.TabIndex = 43;
            ckbHabilitado.Text = "Habilitado";
            ckbHabilitado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(156, 207);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 42;
            label5.Text = "IdPersona";
            // 
            // txtIdPersona
            // 
            txtIdPersona.Enabled = false;
            txtIdPersona.Location = new Point(272, 204);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(347, 23);
            txtIdPersona.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(156, 120);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 40;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(272, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(347, 23);
            txtEmail.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(156, 178);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 38;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Enabled = false;
            txtApellido.Location = new Point(272, 175);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(347, 23);
            txtApellido.TabIndex = 37;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(156, 149);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 36;
            label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(272, 146);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(347, 23);
            txtNombre.TabIndex = 35;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(156, 88);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 34;
            label2.Text = "Clave";
            // 
            // txtClave
            // 
            txtClave.Enabled = false;
            txtClave.Location = new Point(272, 88);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(347, 23);
            txtClave.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(156, 62);
            label7.Name = "label7";
            label7.Size = new Size(110, 15);
            label7.TabIndex = 32;
            label7.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Enabled = false;
            txtNombreUsuario.Location = new Point(272, 59);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(347, 23);
            txtNombreUsuario.TabIndex = 31;
            // 
            // FormUpdateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 297);
            Controls.Add(button2);
            Controls.Add(btnUpdate);
            Controls.Add(ckbCambiaClave);
            Controls.Add(ckbHabilitado);
            Controls.Add(label5);
            Controls.Add(txtIdPersona);
            Controls.Add(label6);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(txtApellido);
            Controls.Add(label4);
            Controls.Add(txtNombre);
            Controls.Add(label2);
            Controls.Add(txtClave);
            Controls.Add(label7);
            Controls.Add(txtNombreUsuario);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(txtIdUserToUpdate);
            Name = "FormUpdateUser";
            Text = "FormUpdateUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdUserToUpdate;
        private Button button1;
        private Button button2;
        private Button btnUpdate;
        private CheckBox ckbCambiaClave;
        private CheckBox ckbHabilitado;
        private Label label5;
        private TextBox txtIdPersona;
        private Label label6;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtApellido;
        private Label label4;
        private TextBox txtNombre;
        private Label label2;
        private TextBox txtClave;
        private Label label7;
        private TextBox txtNombreUsuario;
    }
}