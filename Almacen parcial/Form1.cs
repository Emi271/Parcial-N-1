using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Almacen_parcial
{
    public partial class Form1 : Form
    {
        private MenuPrincipal ucmenuPrincipal;
        private MenuEnvios ucmenuEnvios;
        private MenuProductos ucmenuProductos;
        public Form1()
        {
            InitializeComponent();
            InicializarUserControls();
            MostrarUserControl(ucmenuPrincipal);
        }

        private void InicializarUserControls()
        {
            ucmenuPrincipal = new MenuPrincipal();
            ucmenuEnvios = new MenuEnvios();
            ucmenuProductos = new MenuProductos();

            // Eventos para cambio de pantalla
            ucmenuPrincipal.CambioaMenuEnvios += () =>
            {
                MostrarUserControl(ucmenuEnvios);
            };

            ucmenuEnvios.CambioaMenuPrincipal += () =>
            {
                MostrarUserControl(ucmenuPrincipal);
            };

            ucmenuProductos.CambioaMenuPrincipalDesdeProductos += () =>
            {
                MostrarUserControl(ucmenuPrincipal);
            };

            ucmenuPrincipal.CambioaMenuProductos += () =>
            {
                MostrarUserControl(ucmenuProductos);
            };
        }
        public void MostrarUserControl(UserControl uc)
        {
            panelPrincipal.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            panelPrincipal.Controls.Add(uc);
        }
        

        private void panelPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
