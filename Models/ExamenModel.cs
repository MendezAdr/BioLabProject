using System;

namespace BioLabProject.Models;

public class ExamenModel
{
    public int Id { get; set; }
    public string NombreExamen { get; set; } = string.Empty;
    public decimal CostoEnDivisa { get; set; }
    public decimal CostoenBolivares {get;set;}
    public string Descripcion { get; set; } = string.Empty;
}
