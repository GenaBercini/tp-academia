using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using tp_academia.Dtos;

namespace FormMenu
{
    public partial class FormUpdateUser : Form
    {
        public FormUpdateUser()
        {
            InitializeComponent();
        }

        private UserGetAllDto? _currentUser;

        private async void BtnSearchUserToUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdUserToUpdate.Text))
            {
                MessageBox.Show("Por favor ingrese un ID de usuario antes de buscar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            _currentUser = await ApiClient.Instance.GetFromJsonAsync<UserGetAllDto>($"users/{txtIdUserToUpdate.Text}");
            if (_currentUser is not null)
            {
                btnUpdate.Enabled = true;
                txtNombreUsuario.Enabled = true;
                txtClave.Enabled = true;
                ckbHabilitado.Enabled = true;
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtEmail.Enabled = true;
                ckbCambiaClave.Enabled = true;
                txtIdPersona.Enabled = true;
                txtNombreUsuario.Text = _currentUser.NombreUsuario;
                txtClave.Text = _currentUser.Clave;
                ckbHabilitado.Checked = _currentUser.Habilitado;
                txtNombre.Text = _currentUser.Nombre;
                txtApellido.Text = _currentUser.Apellido;
                txtEmail.Text = _currentUser.Email;
                ckbCambiaClave.Checked = _currentUser.CambiaClave;
                txtIdPersona.Text = $"{_currentUser.IdPersona}";
            }
        }

        private async void BtnSendUpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text) || 
                string.IsNullOrWhiteSpace(txtClave.Text) ||
                string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtIdPersona.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Porfavor ingrese datos en todos los campos para actualizar.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (_currentUser is not null)
            {
                var userUpdateDto = new UserUpdateDto
                {
                    NombreUsuario = txtNombreUsuario.Text,
                    Clave = txtClave.Text,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Email = txtEmail.Text,
                    Habilitado = ckbHabilitado.Checked,
                    CambiaClave = ckbCambiaClave.Checked,
                    IdPersona = int.Parse(txtIdPersona.Text)
                };
                await ApiClient.Instance.PutAsJsonAsync($"users/{_currentUser.IdUsuario}", userUpdateDto);
                Clean();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void BtnCancelUpdate_Click(object sender, EventArgs e)
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
            ckbCambiaClave.Checked = false;
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
