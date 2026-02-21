using System;

namespace BioLabProject.Models;

public class Examen
{
    public int Id { get; set; }
    public string Nombre_Examen { get; set; } = string.Empty;
    public decimal Costo_en_Divisa { get; set; }
    public decimal Costo_en_Bolivares {get;set;}
    public string Descripcion { get; set; } = string.Empty;
}
