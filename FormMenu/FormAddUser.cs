using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMenu
{
    public partial class FormAddUser : Form
    {
        public FormAddUser()
        {
            InitializeComponent();
        }
        private async void BtnAddUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || 
                string.IsNullOrWhiteSpace(txtClave.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtIdPersona.Text))
            {
                MessageBox.Show("Por favor complete todos los campos antes de crear.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            User user = new(
               txtNombreUsuario.Text,
               txtClave.Text,
               ckbHabilitado.Checked,
               txtNombre.Text,
               txtApellido.Text,
               txtEmail.Text,
               int.Parse(txtIdPersona.Text)
            );
            await ApiClient.Instance.PostAsJsonAsync("users", user);
            Clean();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BtnCancelAdd_Click(object sender, EventArgs e)
        {
            Clean();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Clean()
        {
            txtNombreUsuario.Clear();
            txtClave.Clear();
            ckbHabilitado.Checked = false;
            txtNombre.Clear();
            txtApellido.Clear();
            txtEmail.Clear();
            txtIdPersona.Clear();
        }

        private void TxtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
