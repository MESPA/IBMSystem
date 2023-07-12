using System;
namespace CatalogoProductos.Models
{
    public class OrdenProductoViewModel
    {
        public DateTime Fecha { get; set; }
        public int ProductoId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string Estatus { get; set; }
        public Producto Producto { get; set; }
        public int TotalOrdenes { get; set; }
    }
}

