using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;


namespace ExamenU2
{
    internal class Datos
    {
        String cadenaConexion = "Data Source = GP;" + "integrated security=true; initial catalog= agenda; encrypt=false";
        SqlConnection conexion;

        private SqlConnection abrirConexion()
        {
            try
            {
                conexion = new SqlConnection(cadenaConexion);
                conexion.Open(); // abrir conexion a bd
                return conexion;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eror al abrir conexion: " + ex.Message);
                return null;
            }
        }

        public bool prueba()
        {
            try
            {
                abrirConexion();
                return true;
            }
            catch (Exception ex)
            {

                Console.WriteLine("Eror al abrir conexion: " + ex.Message);
                return false;
            }

        }
        //el dataset ayuda a taer informacion de la 
        public DataSet consulta(string consulta)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(consulta, abrirConexion());
                da.Fill(ds);

                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public bool comando(string consulta)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(consulta, abrirConexion());
                cmd.ExecuteNonQuery();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        //private void frmInsertarEmpelados_Load(object sender, EventArgs e)
        //{
        //    Datos obj = new Datos();

        //    // Llenar el combo box de pubs
        //    DataSet ds = obj.Consulta("SELECT pub_id, pub_name FROM publishers");
        //    if (ds != null)
        //    {
        //        cbPubId.DataSource = ds.Tables[0];
        //        cbPubId.DisplayMember = "pub_name";
        //        cbPubId.ValueMember = "pub_id";
        //    }

        //    // Llenar el combo box de job_id
        //    DataSet ds2 = obj.Consulta("SELECT job_id, job_desc FROM jobs");
        //    if (ds2 != null)
        //    {
        //        cbJobId.DataSource = ds2.Tables[0];
        //        cbJobId.DisplayMember = "job_desc";
        //        cbJobId.ValueMember = "job_id";
        //    }
        //}

        //string selectedJobId = cbJobId.SelectedValue.ToString();
        //int jobId = int.Parse(selectedJobId);
        //string selectedPubId = cbPubId.SelectedValue.ToString();

        //        recargar el frame
        //        Datos obj = new Datos();
        //        DataSet ds = obj.consulta("Select au_id as ID,au_lname as [Last Name],au_fname as [Firts Name],phone as Phone,authors.address as Address,city as City,state as State,zip as Zip,contract as Contract From authors");

        //            if (ds != null)
        //            {
        //                dgvAutors.DataSource = ds.Tables[0];
        //            }
        //        boton para cuando seleccione una celda

        //            frmActualizarAutor actualiza = new frmActualizarAutor(dgvAutors[0, e.RowIndex].Value.ToString(), dgvAutors[1, e.RowIndex].Value.ToString(),
        //                                              dgvAutors[2, e.RowIndex].Value.ToString(), dgvAutors[3, e.RowIndex].Value.ToString(),
        //                                              dgvAutors[4, e.RowIndex].Value.ToString(), dgvAutors[5, e.RowIndex].Value.ToString(),
        //                                              dgvAutors[6, e.RowIndex].Value.ToString(), dgvAutors[7, e.RowIndex].Value.ToString(),
        //                                              Convert.ToBoolean(dgvAutors[8, e.RowIndex].Value));
        //            actualiza.Show();

        //}

        //Para el frm actualizar
        //     public frmActualizarAutor(string id, string lname, string fname,
        //    string phone, string address, string city, string state, string zip,
        //    bool contract)
        //{
        //    InitializeComponent();
        //    txtID.Text = id;
        //    txtNombre.Text = fname;
        //    txtLastName.Text = lname;
        //    txtPhone.Text = phone;
        //    txtAddress.Text = address;
        //    txtCity.Text = city;
        //    txtState.Text = state;
        //    txtZip.Text = zip;
        //    chbContract.Checked = contract;
        //}

        //    Para actualizaar 
        //    Datos datos = new Datos();
        //    bool f = datos.comando("update authors set " +
        //                           "au_fname = '" + txtNombre.Text.Replace("'", "''") +
        //                           "', au_lname = '" + txtLastName.Text.Replace("'", "''") +
        //                           "', phone = '" + txtPhone.Text +
        //                           "', address = '" + txtAddress.Text.Replace("'", "''") +
        //                           "', city = '" + txtCity.Text.Replace("'", "''") +
        //                           "', state = '" + txtState.Text +
        //                           "', zip = '" + txtZip.Text +
        //                           "', contract = " + (chbContract.Checked ? 1 : 0) +
        //                           " where au_id = '" + txtID.Text + "'");

        //        if (f)
        //        {
        //            MessageBox.Show("AUTOR ACTUALIZADO", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.Close();
        //}
        //        else
        //        {
        //            MessageBox.Show("AUTOR NO ACTUALIZADO", "ACTUALIZACION", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //}
        //    frmInsertar nuevos registros
        //    Datos datos = new Datos();
        //    bool f = datos.comando("insert into authors values('" +
        //            txtID.Text + " '," + "'" + txtLastName.Text.Replace("'", "''") + "'," +
        //            "'" + txtNombre.Text.Replace("'", "''") + "'," + "'" + txtPhone.Text + "',"
        //            + "'" + txtAddress.Text.Replace("'", "''") + "'," + "'" + txtCity.Text + "'," +
        //            "'" + txtState.Text + "'," + "'" + txtZip.Text + "'," +
        //            +(chbContract.Checked ? 1 : 0) + ")");
        //        if (f)
        //        {
        //            MessageBox.Show("Autor dado de alta correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            this.Close();
        //}
        //        else
        //        {
        //            MessageBox.Show("Autor no dado de alta correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //string tex = txtBuscar.Text;


        //            for (int i = 0; i<dgvMostrar.RowCount - 1; i++)
        //            {
        //                if (dgvMostrar.Rows[i].Cells[0].Value.ToString().Contains(tex))
        //                    dgvMostrar.Rows[i].Visible = true;
        //                else
        //                    dgvMostrar.Rows[i].Visible = false;
        //            }

    }
}
