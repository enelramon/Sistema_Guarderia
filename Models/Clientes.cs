public class Cliente
{ 
    #nullable disable

    public int ClienteId { get; set; }

    public string Nombre { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
    public string LugarTrabajo { get; set; }
    public DateTime Fecha_Registro { get; set; }

    public bool Visible { get; set; }


}