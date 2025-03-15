using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ExamenU2
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void actualizarUsuarios()
        {
            Datos datos = new Datos();
            DataSet ds = datos.consulta("select ID, NOMBRE, APATERNO AS " +
            "'APELLIDO PATERNO', AMATERNO AS 'APELLIDO MATERNO'," +
            " TELEFONO, CORREO FROM USUARIOS ");

            if (ds != null)
            {
                dgvUsuarios.DataSource = ds.Tables[0];

            }
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            actualizarUsuarios();

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            menu.Show();
            this.Dispose();
        }
    }
}
