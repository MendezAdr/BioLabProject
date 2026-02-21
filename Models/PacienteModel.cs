// Models/Paciente.cs

namespace BioLabProject.Models;
public class Paciente {
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string Apellido {get; set;} = string.Empty;
    public string Cedula { get; set; } = string.Empty;
    public string Telefono {get; set;} = string.Empty;
    public string Direccion { get; set; } = string.Empty;

}