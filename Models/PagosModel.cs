using System;

namespace BioLabProject.Models;

public enum Moneda { Bolivares, Divisa }

public enum MetodoPago { Efectivo, PagoMovil, Transferencia, PuntoDeVenta }

public class Pago
{
    public int Id { get; set; }
    
    // Relación con la Orden
    public int OrdenId { get; set; }
    public Ordenes Orden { get; set; } = null!;

    public Moneda Moneda { get; set; }
    public MetodoPago Metodo { get; set; }
    
    public decimal Monto { get; set; }
    
    public string Referencia { get; set; } = string.Empty;
}
