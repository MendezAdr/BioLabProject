using System;
using System.Collections.Generic;

namespace BioLabProject.Models;

public class OrdenesModel
{
    /*
     * Una orden representa una venta realizada a un paciente, 
     * que puede incluir múltiples exámenes (a través de Detalle)
     * y múltiples pagos (Multimoneda/Multitotal).
     */

    public int Id { get; set; }
    public string NumeroFactura { get; set; } = string.Empty; 
    public DateTime Fecha { get; set; } = DateTime.Now;
    
    // Relación con Paciente
    public int PacienteId { get; set; }
    public Paciente Paciente { get; set; } = null!;

    // Totales de la Orden
    public decimal TotalDivisa { get; set; }
    public decimal TasaBcv { get; set; } // La tasa del día de la venta
    public decimal TotalBs => TotalDivisa * TasaBcv; // Propiedad calculada

    // 1. Una Orden tiene muchos Exámenes (a través de Detalle)
    public List<Detalle> Detalles { get; set; } = new();

    // 2. Una Orden tiene muchos Pagos (Multimoneda/Multitotal)
    public List<PagosModel> Pagos { get; set; } = new();

    public string EstadoPago { get; set; } = "Pendiente"; // Pagado, Parcial, Pendiente
}