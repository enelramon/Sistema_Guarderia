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

        [Required(ErrorMessage = "Ingrese la fecha")]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese la fecha de nacimiento")]
        public DateTime FechaNacimiento { get; set; }

        [Required(ErrorMessage = "Ingrese la dirección")]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre de la madre.")]
        public string NombreMadre { get; set; }

        [RegularExpression(@"^[0-9-]+$", ErrorMessage = "Ingrese un número de teléfono válido para la madre (solo números y guiones).")]
        public string TelefonoMadre { get; set; }

        [Required(ErrorMessage = "Ingrese el lugar de trabajo de la madre.")]
        public string LugarDeTrabajoMadre { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del padre.")]
        public string NombrePadre { get; set; }

        [RegularExpression(@"^[0-9-]+$", ErrorMessage = "Ingrese un número de teléfono válido para el padre (solo números y guiones).")]
        public string TelefonoPadre { get; set; }

        [Required(ErrorMessage = "Ingrese el lugar de trabajo del padre.")]
        public string LugarDeTrabajoPadre { get; set; }

        [Required(ErrorMessage = "Ingrese el seguro médico.")]
        public string SeguroMedico { get; set; }

        [Required(ErrorMessage = "Ingrese el nombre del pediatra.")]
        public string NombrePediatra { get; set; }

        [Required(ErrorMessage = "Ingrese el lugar de trabajo del pediatra.")]
        public string LugarDeTrabajoPediatra { get; set; }

        [Required(ErrorMessage = "Ingrese el caso de emergencia.")]
        public string CasoDeEmergencia { get; set; }

        [Required(ErrorMessage = "Ingrese los padecimientos.")]
        public string Padece { get; set; }

        public bool Estado { get; set; }
    }
}
