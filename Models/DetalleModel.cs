using System;

namespace BioLabProject.Models;

public class Detalle
{
    public int Id { get; set; }
    
    public int OrdenId { get; set; }
    public Ordenes Orden { get; set; } = null!;

    public int ExamenId { get; set; }
    public Examen Examen { get; set; } = null!;

    public decimal PrecioVentaDivisa { get; set; }
    public decimal PrecioVentaBolivares { get; set; }

    public string Metodo_pago { get; set; } = string.Empty;
}
