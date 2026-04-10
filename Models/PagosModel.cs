using BioLabProject.Models;

public class PagosModel
{
    /*
     * se sobre entiende que un pago es una
     * manera de "pagar" una orden, por lo tanto, cada pago
     * tendra solo un metodo de pago, un monto y una referencia (si aplica)
     */
    public int Id { get; set; }
    public int OrdenId { get; set; } // Cambiado de VentaId para consistencia
    public OrdenesModel Orden { get; set; } = null!;

    public MetodoPago Metodo { get; set; }
    public decimal Monto { get; set; } // El monto que se pagó con este método
    public string Referencia { get; set; } = string.Empty;

    public enum MetodoPago
    {
        Punto = 1, PagoMovil = 2, BioPago = 3, EfectivoBs = 4, Divisas = 5, Transferencia = 6
    }
}