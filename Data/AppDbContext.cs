using System;
using BioLabProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace BioLabProject.Data;

public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Rol> Roles { get; set; } = null!;
    public DbSet<Paciente> Pacientes { get; set; } = null!;
    public DbSet<Examen> Examenes { get; set; } = null!;
    public DbSet<Ordenes> Ordenes { get; set; } = null!;
    public DbSet<Detalle> Detalles { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source = Laboratorio.Db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Detalle>()
            .HasOne(d => d.Orden)
            .WithMany() // Una orden puede tener muchos detalles
            .HasForeignKey(d => d.OrdenId);

        // 2. Seeding de Roles (Vital para tu sistema de Login)
        modelBuilder.Entity<Rol>().HasData(
            new Rol { Id = 1, Nombre = "Administrador", Descripcion = "Acceso total" },
            new Rol { Id = 2, Nombre = "Bioanalista", Descripcion = "Registro de exámenes y resultados" }
        );

        // 3. Usuario administrador inicial (Password en texto plano solo para el ejemplo, usa hashing luego)
        modelBuilder.Entity<Usuario>().HasData(
            new Usuario { Id = 1, Nombre = "Adrian", Apellido = "Mendez", Cedula = "12345678", RolId = 1 }
        );

        base.OnModelCreating(modelBuilder);
    }

}
