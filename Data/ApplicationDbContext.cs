using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sistema_Guarderia.Models;

namespace Sistema_Guarderia.Data;

public class ApplicationDbContext : IdentityDbContext
#nullable disable // Para quitar el aviso de nulls
{ 
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Inscripcion> Inscripcion  { get; set; }
    public DbSet<Servicio> Servicio  { get; set; }

}
