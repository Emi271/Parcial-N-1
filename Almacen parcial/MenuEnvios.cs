using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Almacen_parcial;


namespace Almacen_parcial
{
    public partial class MenuEnvios : UserControl
    {
        public event Action CambioaMenuPrincipal;
        private DataRow repartidorSeleccionado;
        private PedidoTemp pedidoActual = new PedidoTemp();

        public MenuEnvios()
        {
            InitializeComponent();
        }

        private void MenuEnvios_Load(object sender, EventArgs e)
        {
            string conectionString = "Server=localhost\\SQLEXPRESS;Database=Repartidores;Trusted_Connection=True;";
            string consulta = "SELECT PersonaID, Nombre, Apellido, Email, Celular, Localidad, TipoDeVehiculo FROM Repartidores";

            using (SqlConnection conexion = new SqlConnection(conectionString))
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    // Configurar el ListView
                    listViewRepartidores.View = View.Details; 
                    listViewRepartidores.GridLines = true; 
                    listViewRepartidores.FullRowSelect = true; 
                    listViewRepartidores.MultiSelect = false; 

                    listViewRepartidores.Columns.Add("ID", 50, HorizontalAlignment.Left);
                    listViewRepartidores.Columns.Add("Nombre", 120, HorizontalAlignment.Left);
                    listViewRepartidores.Columns.Add("Apellido", 120, HorizontalAlignment.Left);
                    listViewRepartidores.Columns.Add("Email", 150, HorizontalAlignment.Left);
                    listViewRepartidores.Columns.Add("Celular", 100, HorizontalAlignment.Left);
                    listViewRepartidores.Columns.Add("Localidad", 100, HorizontalAlignment.Left);
                    listViewRepartidores.Columns.Add("Vehículo", 100, HorizontalAlignment.Left);

                    foreach (DataRow fila in tabla.Rows)
                    {
                        ListViewItem item = new ListViewItem(fila["PersonaID"].ToString());

                        // Agregar los subítems para las columnas restantes
                        item.SubItems.Add(fila["Nombre"].ToString());
                        item.SubItems.Add(fila["Apellido"].ToString());
                        item.SubItems.Add(fila["Email"].ToString());
                        item.SubItems.Add(fila["Celular"].ToString());
                        item.SubItems.Add(fila["Localidad"].ToString());
                        item.SubItems.Add(fila["TipoDeVehiculo"].ToString());

                        item.Tag = fila.Table.NewRow();
                        item.Tag = fila;


                        listViewRepartidores.Items.Add(item);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al conectar o consultar la base de datos: " + ex.Message, "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error inesperado: " + ex.Message, "Error General", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void panelMenuEnvios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            CambioaMenuPrincipal?.Invoke();
        }

        private void Subtitulo1_Click(object sender, EventArgs e)
        {

        }

        private void Titulo3_Click(object sender, EventArgs e)
        {

        }

        private void listViewRepartidores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRepartidores.SelectedItems.Count > 0)
            {
                var item = listViewRepartidores.SelectedItems[0];


                // Por ejemplo, mostrar el nombre y apellido:
                string nombre = item.SubItems[1].Text;
                string apellido = item.SubItems[2].Text;

                repartidorSeleccionado = item.Tag as DataRow;

                MessageBox.Show($"Seleccionaste a: {nombre} {apellido}");
            }

        }

        private void buttonSeleccionarRepartidor_Click(object sender, EventArgs e)
        {
            if (repartidorSeleccionado != null)
            {
                // Aquí puedes acceder a la información del repartidor seleccionado
                int id = (int)repartidorSeleccionado["PersonaID"];
                string nombre = repartidorSeleccionado["Nombre"].ToString();
                string apellido = repartidorSeleccionado["Apellido"].ToString();
                string vehiculo = repartidorSeleccionado["TipoDeVehiculo"].ToString();

                MessageBox.Show($"Repartidor seleccionado:\nID: {id}\nNombre: {nombre} {apellido}\nVehículo: {vehiculo}", "Repartidor Seleccionado");

                // Aquí puedes realizar la acción que necesites con el repartidor seleccionado
                // Por ejemplo, podrías mostrar un formulario para asignar el envío a este repartidor.
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un repartidor de la lista.", "Advertencia");
            }
        }
    }
}
