using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sistema_Guarderia.Models
{
    public class Servicio //Entidad
    {
        [Key]
        public int ServicioId { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre")]
        public string NombreServicio { get; set; }
        public DateTime FechaServicio { get; set; }

        [Required(ErrorMessage = "Ingrese el monto a pagar.")]
        public decimal PrecioServicio { get; set; }
        public double? Descuento { get; set; }
        public bool Estado { get; set; }
    }
}