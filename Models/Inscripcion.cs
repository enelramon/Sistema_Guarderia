using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Sistema_Guarderia.Models
{
#nullable disable // Para quitar el aviso de nulls

    public class Inscripcion
    {  
        
         [Key]
        public int InscripcionId { get; set; }

        public DateTime Fecha { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre")]

        public string Nombre { get; set; }

        public DateTime FechaNacimiento { get; set; }

        public string Direccion { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre de la madre.")]

        public string NombreMadre { get; set; }

        public string TelefonoMadre { get; set; }

        public string LugarDeTrabajoMadre { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre del Padre.")]

        public string NombrePadre { get; set; }

        public string TelefonoPadre { get; set; }

        public string LugarDeTrabajoPadre { get; set; }

        public string SeguroMedico { get; set; }
        [Required(ErrorMessage = "Ingrese el nombre del Pediatra.")]

        public string NombrePediatra { get; set; }

        public string LugarDeTrabajoPediatra { get; set; }

        public string CasoDeEmergencia { get; set; }

        public string Padece { get; set; }

        public bool Estado { get; set; }

    }
}