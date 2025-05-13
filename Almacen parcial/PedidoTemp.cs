using System;
using System.Collections.Generic;

namespace Almacen_parcial
{
    public class ProductoSeleccionado
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
    }

    public class PedidoTemp
    {
        public int IdRepartidor { get; set; }
        public List<ProductoSeleccionado> Productos { get; set; } = new List<ProductoSeleccionado>();
    }
}
