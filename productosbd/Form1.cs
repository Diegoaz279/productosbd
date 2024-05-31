using System;
using System.Data;
using System.Data.SqlClient;


namespace productosbd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Server=.; database = basica; integrated security = true");
            conexion.Open();
            string descripcion = txtdescripcion.Text;
            string precio = txtprecio.Text;
            string cadena = "insert into producto(descripcion,precio) values ( '" + descripcion + "' , " + precio + ")";
            SqlCommand comando = new SqlCommand(cadena, conexion);
            comando.ExecuteNonQuery();
            MessageBox.Show("Los Dtatos Fueron Guardados Correctamente");
            txtdescripcion.Text = "";
            txtprecio.Text = "";
            conexion.Close();



        }
    }
}
