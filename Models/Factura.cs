using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Guarderia.Models
{
    public class Factura
    {
        public int FacturaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public List<ItemFactura> Items { get; set; }

        public Factura()
        {
            Items = new List<ItemFactura>();
        }

        public decimal CalcularTotal()
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                total += item.Precio * item.Cantidad;
            }
            return total;
        }
    }

    public class ItemFactura
    {
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
    }
}