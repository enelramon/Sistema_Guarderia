using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable // Para quitar el aviso de nulls
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
        public double PrecioServicio { get; set; }
        public bool Estado { get; set; }


    }
}