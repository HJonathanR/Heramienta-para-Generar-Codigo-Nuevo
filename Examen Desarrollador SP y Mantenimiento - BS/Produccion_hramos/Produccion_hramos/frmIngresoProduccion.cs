using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Produccion_hramos
{
    public partial class frmIngresoProduccion : Form
    {
        public frmIngresoProduccion()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-2LD6SIT\HJONATHANR;Initial Catalog=hramos_db;Integrated Security=True");

        private void RefrescarGrid()
        {
            con.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("sp_MostrarProduccion", con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sqlDataAdapter);
            var ds = new DataSet();
            sqlDataAdapter.Fill(ds);

            ProduccionDGV.DataSource = ds.Tables[0];

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (SeccionTb.Text == "" || EstiloTb.Text == "" || TallaTb.Text == "" || ColorTb.Text == ""|| CantidadTb.Text == "")
                {
                    MessageBox.Show("Datos Incompletos. Por favor, ingrese todos los datos requeridos.");
                } else
                {
                    con.Open();
                    // Ejecutar Procedimiento Almacenado sp_InsertarProduccion ara almacenar la produccion ingresada por el usuario.
                    SqlCommand command = new SqlCommand("sp_InsertarProduccion", con);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@Fecha", FechaDTP.Text));
                    command.Parameters.Add(new SqlParameter("@CodSeccion", SeccionTb.Text));
                    command.Parameters.Add(new SqlParameter("@CantidadUnid", CantidadTb.Text));
                    command.Parameters.Add(new SqlParameter("@CodSKU", EstiloTb.Text));
                    command.Parameters.Add(new SqlParameter("@Talla", TallaTb.Text));
                    command.Parameters.Add(new SqlParameter("@Color", ColorTb.Text));
                    command.ExecuteNonQuery();

                    MessageBox.Show("Los datos han sido ingresados de manera exitosa.");

                    con.Close();
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefrescarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SeccionTb.Clear();
            EstiloTb.Clear();
            TallaTb.Clear();
            ColorTb.Clear();
            CantidadTb.Clear();
            FechaDTP.Text = "";
            ProduccionDGV.DataSource = null;
        }
    }
}
