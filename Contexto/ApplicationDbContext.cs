﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sistema_Guarderia.Models;

namespace Sistema_Guarderia.Contexto;

public class ApplicationDbContext : IdentityDbContext
#nullable disable // Para quitar el aviso de nulls
{ 
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Inscripcion> Inscripcion  { get; set; }
    public DbSet<Servicio> Servicio  { get; set; }
    public DbSet<Cliente> Cliente  { get; set; }
    public DbSet<Ventas> Ventas  { get; set; }
    public DbSet<Pago> Pago  { get; set; }
    public DbSet<VentasDetalle> VentasDetalle  { get; set; }

}
