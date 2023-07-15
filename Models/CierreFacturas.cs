using System.Collections.Generic;
using Sistema_Guarderia.Models;

public class CierreFacturas
{
    #nullable disable

    // new Class
    public DateTime FechaCierre { get; set; }
    public List<Factura> FacturasCerradas { get; set; }
    public List<usuario> Usuario {get; set ;}
    public CierreFacturas()
    {
        FacturasCerradas = new List<Factura>();
    }

   /* public void CerrarFactura(Factura factura)
    {
        factura.Estado = EstadoFactura.Cerrada;
        FacturasCerradas.Add(factura);
    }

    public decimal CalcularTotalCierre()
    {
        decimal totalCierre = 0;
        foreach (var factura in FacturasCerradas)
        {
            totalCierre += factura.Total;
        }
        return totalCierre;
    }*/
}
