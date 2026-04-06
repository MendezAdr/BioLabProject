using BioLabProject.Models;

public class Detalle
{
    public int Id { get; set; }
    public int OrdenId { get; set; }
    public OrdenesModel Orden { get; set; } = null!;

    public int ExamenId { get; set; }
    public ExamenModel Examen { get; set; } = null!;

    // Guardamos el precio del momento por si el examen sube de precio mañana
    public decimal PrecioMomentoDivisa { get; set; } 
}