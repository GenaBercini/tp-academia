namespace FormMenu
{
    partial class FormAddUser
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
            label1 = new Label();
            txtNombreUsuario = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // ckbHabilitado
            // 
            ckbHabilitado.AutoSize = true;
            ckbHabilitado.Location = new Point(196, 203);
            ckbHabilitado.Name = "ckbHabilitado";
            ckbHabilitado.Size = new Size(81, 19);
            ckbHabilitado.TabIndex = 27;
            ckbHabilitado.Text = "Habilitado";
            ckbHabilitado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 177);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 26;
            label5.Text = "IdPersona";
            // 
            // txtIdPersona
            // 
            txtIdPersona.Location = new Point(127, 174);
            txtIdPersona.Name = "txtIdPersona";
            txtIdPersona.Size = new Size(347, 23);
            txtIdPersona.TabIndex = 25;
            txtIdPersona.KeyPress += TxtSoloNumeros_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 90);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 24;
            label6.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(127, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(347, 23);
            txtEmail.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 148);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 22;
            label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(127, 145);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(347, 23);
            txtApellido.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 119);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 20;
            label4.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(127, 116);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(347, 23);
            txtNombre.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 58);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 18;
            label2.Text = "Clave";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(127, 58);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(347, 23);
            txtClave.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 32);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 16;
            label1.Text = "Nombre de Usuario";
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(127, 29);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(347, 23);
            txtNombreUsuario.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientActiveCaption;
            button1.Location = new Point(147, 228);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 29;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += BtnAddUser_Click;
            // 
            // button2
            // 
            button2.Location = new Point(254, 228);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 30;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += BtnCancelAdd_Click;
            // 
            // FormAddUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 262);
            Controls.Add(button2);
            Controls.Add(button1);
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
            Controls.Add(label1);
            Controls.Add(txtNombreUsuario);
            Name = "FormAddUser";
            Text = "FormAddUser";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Label label1;
        private TextBox txtNombreUsuario;
        private Button button1;
        private Button button2;
    }
}