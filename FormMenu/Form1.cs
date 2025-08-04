namespace FormMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenUsersForm(Form userForm)
        {
            userPanel.Controls.Clear();
            userForm.TopLevel = false;
            userForm.FormBorderStyle = FormBorderStyle.None;
            userForm.Dock = DockStyle.Fill;
            userPanel.Controls.Add(userForm);
            userForm.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            OpenUsersForm(new UserDashboard());
        }

        private void OpenOtroForm(Form otroForm)
        {
            userPanel.Controls.Clear();
            otroForm.TopLevel = false;
            otroForm.FormBorderStyle = FormBorderStyle.None;
            otroForm.Dock = DockStyle.Fill;
            userPanel.Controls.Add(otroForm);
            otroForm.Show();
        }

        private void btnOtros_Click(object sender, EventArgs e)
        {
            OpenOtroForm(new OtroDashboard());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenUsersForm(new UserDashboard());
        }
    }
}
