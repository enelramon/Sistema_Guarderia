public class CierreMensual
{

    public int Dia { get; set; }
    public int Mes { get; set; }
    public int Año { get; set; }

    public bool Visible {get; set;}
   // public List<Factura> FacturasCerradas { get; set; }

/*    public CierreMensual(int dia,int mes, int año)
    {   Dia = dia;
        Mes = mes;
        Año = año;
        FacturasCerradas = new List<Factura>();
    }

    public void CerrarFacturas(List<Factura> facturas)
    {
        FacturasCerradas.AddRange(facturas);
        foreach (var factura in facturas)
        {
            factura.Estado = EstadoFactura.Cerrada;
        }
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
