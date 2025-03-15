namespace ExamenU2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUsuarios usuarios  = new frmUsuarios();
            usuarios.Show();
        }
    }
}
