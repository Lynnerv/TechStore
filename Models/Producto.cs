using System;

namespace TechStore.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public decimal IGV { get; set; }

        // Calcula el precio con impuesto (IGV)
        public decimal PrecioConIGV
        {
            get
            {
                return Precio + IGV;
            }
        }
    }
}

