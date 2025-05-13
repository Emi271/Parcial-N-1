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
    public partial class MenuProductos : UserControl
    {
        public event Action CambioaMenuPrincipalDesdeProductos;
        public MenuProductos()
        {
            InitializeComponent();
        }

        private void Titulo2_Click(object sender, EventArgs e)
        {

        }

        private void MenuProductos_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            CambioaMenuPrincipalDesdeProductos?.Invoke();
        }
    }
}
