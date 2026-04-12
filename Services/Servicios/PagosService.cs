using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BioLabProject.Models;
using BioLabProject.Services.Interfaces;


namespace BioLabProject.Services.Servicios;

public class PagosService : IPagosService
{
    public async Task<OperationResult> GetPagoByIdAsync(int id)
    {
        
    }

    public async Task<OperationResult> GetPagoByMetodoAsync(int IdMetodo)
    {
        
    }

    public async Task<OperationResult> GetPagoByOrdenAsync(int OrdenId)
    {
        
    }

    public async Task<OperationResult> GetPagoByReferenciaAsync(string ReferenciaId)
    {
        
    }

    public async Task<OperationResult> GetAllPagosEntreFechasAsync(DateTime? fechaInicio, DateTime? fechaFin)
    {
        
    }

    public async Task<OperationResult> GetAllPagosByMetodoAsync(int IdMetodo)
    {
        
    }
    
    
    
    
    //metodos restantes
    public async Task<OperationResult> CreatePagoAsync(PagosModel pago)
    {
        
    }

    public async Task<OperationResult> UpdatePagoAsync(PagosModel pago, int adminId)
    {
        
    }

    public async Task<OperationResult> DeactivatePagoAsync(int idPago, int adminId)
    {
        
    }

    public async Task<ListOperationResult<PagosModel>> DeactivatePagosAsync(List<int> pagos, int adminId)
    {
        
    }

    public async Task<OperationResult> ActivatePagoAsync(int idPago, int adminId)
    {
        
    }

    
}