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
    public partial class frmActualizarUsuario : Form
    {
        public frmActualizarUsuario(string id, string nombre, string aPaterno, string aMaterno, string telfono, string correo)
        {
            InitializeComponent();
            txtID.Text = id;
            txtNombre.Text = nombre;
            txtAPaterno.Text = aPaterno;
            txtAMaterno.Text = aMaterno;
            txtCorreo.Text = correo;
            txtTelefono.Text = telfono;

        }

        private void frmActualizarUsuario_Load(object sender, EventArgs e)
        {

        }

        private bool validarcorreo(string correo)
        {
            //funcion con ayuda de inteligencia 
            string patron = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            bool f = Regex.IsMatch(correo, patron);
            return f;

        }

        private void btnActualizar_Click(object sender, EventArgs e)
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
                bool f = datos.comando("update USUARIOS set NOMBRE = '" + txtNombre.Text + "" +
                    "', APATERNO = '" + txtAPaterno.Text + "', AMATERNO = '" + txtAMaterno.Text + "'," +
                    " TELEFONO = '" + long.Parse(txtTelefono.Text) + "', CORREO = '" + txtCorreo.Text + "' where ID = " + txtID.Text + " ");

                if (f)
                {
                    MessageBox.Show("USUARIO ACTUALIZADO", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("USUARIO NO ACTUALIZADO", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Estas seguro de eliminar el registro?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Datos datos = new Datos();
                bool f = datos.comando("delete from usuarios where id = " + txtID.Text + "");
                if (f)
                {
                    MessageBox.Show("USUARIO ELIMINADO", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error De Sistema", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
