// modelo de usuario

using System;

namespace BioLabProject.Models;
public class Usuario
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido { get; set; } = string.Empty;
    public string Cedula { get; set; } = string.Empty;

    // Relación explícita
    public int RolId { get; set; } 
    public Rol Rol { get; set; } = null!;

}