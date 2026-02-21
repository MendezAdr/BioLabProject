using System;
using System.Collections.Generic;

namespace BioLabProject.Models;

public class Ordenes
{
    public int Id { get; set; }

    public string NumeroFactura { get; set; } = string.Empty; // Ej: "000001"
    public string NumeroControl { get; set; } = string.Empty; // Ej: "00-000001"

    public int PacienteId { get; set; }
    public Paciente Paciente {get;set;} = null!;
    public DateTime Fecha { get; set; }
    public List<Pago> Pagos { get; set; } = new();
    public decimal Total { get; set; }
    public string Estado_Pago {get; set;} = string.Empty; //pagado, pendiente, parcial
    
}
