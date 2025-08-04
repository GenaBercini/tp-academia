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
using tp_academia.Dtos;

namespace FormMenu
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
            dataUsersPanel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void UserDashboard_Load(object sender, EventArgs e)
        {
            await PreloadUsers();
        }

        private async Task PreloadUsers()
        {
            try
            {
                IEnumerable<UserGetAllDto>? users = await ApiClient.Instance.GetFromJsonAsync<IEnumerable<UserGetAllDto>>("users");
                if (users == null || !users.Any())
                {
                    dataUsersPanel.Visible = false;
                    lblNoData.Visible = true;
                }
                else
                {
                    dataUsersPanel.Visible = true;
                    lblNoData.Visible = false;
                    dataUsersPanel.DataSource = users?.ToList(); ;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar alumnos: {ex.Message}");
            }
        }

        private async void BtnNewUser_Click(object sender, EventArgs e)
        {
            using (var form = new FormAddUser())
            {
                var resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    await PreloadUsers();
                }
            }
        }

        private async void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            using (var form = new FormDeleteUser())
            {
                var resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    await PreloadUsers();
                }
            }
        }

        private async void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            using (var form = new FormUpdateUser())
            {
                var resultado = form.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    await PreloadUsers();
                }
            }
        }
    }
}
