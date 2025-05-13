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
using static Parcial_Nº1___Almacen.MenuPrincipal;

namespace Parcial_Nº1___Almacen
{ 
    public partial class UcMenuAlimentos : UserControl
    {
        private DataRow alimentoSeleccionado;

        public UcMenuAlimentos()
        {
            InitializeComponent();
        }

        private void UcMenuAlimentos_Load(object sender, EventArgs e)
        {
            string cadenaConexion = "Server=localhost\\SQLEXPRESS;Database=MenuAlimentos;Trusted_Connection=True;";
            string consulta = "SELECT ID, Nombre, Precio, Stock FROM Productos_Alimentos";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    listviewAlimentos.View = View.Details;
                    listviewAlimentos.GridLines = true;
                    listviewAlimentos.FullRowSelect = true;
                    listviewAlimentos.MultiSelect = false;

                    listviewAlimentos.Columns.Add("ID", 50, HorizontalAlignment.Left);
                    listviewAlimentos.Columns.Add("Nombre", 100, HorizontalAlignment.Left);
                    listviewAlimentos.Columns.Add("Precio", 100, HorizontalAlignment.Left);
                    listviewAlimentos.Columns.Add("Stock", 100, HorizontalAlignment.Left);

                    foreach (DataRow fila in tabla.Rows)
                    {
                        ListViewItem item = new ListViewItem(fila["ID"].ToString());
                        item.SubItems.Add(fila["Nombre"].ToString());
                        item.SubItems.Add(fila["Precio"].ToString());
                        item.SubItems.Add(fila["Stock"].ToString());
                        listviewAlimentos.Items.Add(item);

                        item.Tag = fila;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
                }

            }

        }

        private void listviewAlimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listviewAlimentos.SelectedItems.Count > 0)
            {
                ListViewItem item = listviewAlimentos.SelectedItems[0];

                int id = int.Parse(item.SubItems[0].Text);
                string nombre = item.SubItems[1].Text;
                decimal precio = decimal.Parse (item.SubItems[2].Text);
                int stock = int.Parse(item.SubItems[3].Text);

                Producto producto = new Producto
                {
                    ID = id,
                    Nombre = nombre,
                    Precio = precio,
                    Stock = stock
                };

                MenuPrincipal.MiCarrito.AgregarProducto(producto);
                alimentoSeleccionado = item.Tag as DataRow;

                MessageBox.Show($"Seleccionaste : {nombre} ");
                
            }
        }

        private void VerCarrito_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm is MenuPrincipal menuPrincipal)
            {
                MenuCarrito carrito = new MenuCarrito();

                menuPrincipal.PanelContenedor.Controls.Clear();
                menuPrincipal.PanelContenedor.Controls.Add(carrito);
                carrito.Dock = DockStyle.Fill;
            }
        }

        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm is MenuPrincipal menuPrincipal)
            {
                UcPRODUCTOS menuCategorias = new UcPRODUCTOS();
                menuPrincipal.PanelContenedor.Controls.Clear();
                menuPrincipal.PanelContenedor.Controls.Add(menuCategorias);
                menuCategorias.Dock = DockStyle.Fill;
            }
        }
    }

}