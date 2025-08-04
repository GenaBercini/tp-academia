using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormMenu
{
    public partial class FormDeleteUser : Form
    {
        public FormDeleteUser()
        {
            InitializeComponent();
        }

        private void TxtSoloNumeros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIdUserToDelete.Text))
                {
                    MessageBox.Show("Por favor ingrese un ID de usuario para borrar.",
                                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                User? user = await ApiClient.Instance.GetFromJsonAsync<User>($"users/{txtIdUserToDelete.Text}");
                if (user is not null)
                {
                    var result = MessageBox.Show("¿Está seguro que desea eliminar este usuario?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes) await ApiClient.Instance.PatchAsync($"users/{txtIdUserToDelete.Text}", null);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else MessageBox.Show($"El usuario no existe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar alumnos: {ex.Message}");
            }
        }
    }
}
