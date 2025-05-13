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
    public partial class MenuPrincipal : UserControl
    {
        public event Action CambioaMenuEnvios;
        public event Action CambioaMenuProductos;
        public MenuPrincipal()
        {
            InitializeComponent();
        }


        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MenuProductos_Click(object sender, EventArgs e)
        {
            CambioaMenuProductos?.Invoke();
        }

        private void MenuEnvios_Click(object sender, EventArgs e)
        {
            CambioaMenuEnvios?.Invoke();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {

        }
    }
}
