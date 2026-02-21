using System;

namespace BioLabProject.Models;

public class Ordenes
{
    public int Id { get; set; }
    public int PacienteId { get; set; }
    public Paciente Paciente {get;set;} = null!;
    public DateTime Fecha { get; set; }
    public decimal Total { get; set; }
    public string Estado_Pago {get; set;} = string.Empty;
    
}
