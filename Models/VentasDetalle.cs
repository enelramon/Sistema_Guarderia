using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
 
#nullable disable // Para quitar el aviso de nulls

namespace Sistema_Guarderia.Models
{
    public class VentasDetalle // Detalles de la venta
    {
        [Key]
       
        public int Id { get; set; }
      
        public int VentaId { get; set; }
     
        public int ClienteId { get; set; }

        public int PagoId { get; set; }        

        public int ServicioId { get; set; }
        
        public double Cantidad { get; set; }
        public int PrecioArticuloComprado { get; }
        public decimal PrecioServicioComprado { get; set; }  

        public string Descripcion { get; set; }

        public decimal Importe { get; set; }

        public virtual Servicio servicio {get; set;}

        public Ventas venta { get; set; } = new Ventas();


        //-------------------------------------------------------------------------------------


        public VentasDetalle()
        {
            Id = 0;
            VentaId = 0;
            ClienteId = 0;        
            
           ServicioId = 0;
            PagoId = 0;
            Cantidad = 0; 
             PrecioArticuloComprado = 0;   
            Descripcion = string.Empty;  
        }

        public VentasDetalle(int id, int ventaId, int clienteId,  int servicioId, int pagoid, int cantidad,decimal precioArticuloComprado,  string descripcion)
        {
            Id = id;
            VentaId = ventaId;
            ClienteId = clienteId;        
            ServicioId = servicioId; 
            
            PagoId = pagoid;
            Cantidad = cantidad;
        
            Descripcion = descripcion;
        }
    }
}