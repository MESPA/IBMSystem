using System;
namespace CatalogoProductos.Models
{
    public class ImagenProducto
    {
        public int Id { get; set; }
        public string RutaImagen { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
    }
}

