using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenU2
{
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
        {
            InitializeComponent();
        }
        private bool validarcorreo(string correo)
        {
            //funcion con ayuda de inteligencia 
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool f = Regex.IsMatch(correo, patron);
            return f;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Datos datos = new Datos();
                bool x = validarcorreo(txtCorreo.Text);
                if (!x)
                {
                    MessageBox.Show("FAVOR DE VERIFICAR EL CORREO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                bool f = datos.comando("insert into USUARIOS  values ('"+txtAPaterno.Text+"', '"+txtAMaterno.Text+"', '"+txtNombre.Text+"'," +
                    "'"+long.Parse(txtTelefono.Text)+"', '"+txtCorreo.Text+"' ) ");

                if (f)
                {
                    MessageBox.Show("USUARIO AGREGADO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    frmUsuarios usuarios = new frmUsuarios();
                    usuarios.Show();
                }
                else
                {
                    MessageBox.Show("USUARIO NO AGREGADO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {

                MessageBox.Show("FAVOR DE VERIFICAR EL TELFONO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
