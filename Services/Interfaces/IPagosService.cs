using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BioLabProject.Models;

namespace BioLabProject.Services.Interfaces;

public interface IPagosService
{   
    //obtencion de pagos
    Task<OperationResult> GetPagoByIdAsync(int id);
    Task<OperationResult> GetPagoByMetodoAsync(int IdMetodo);
    Task<OperationResult> GetPagoByOrdenAsync(int OrdenId);
    Task<OperationResult> GetPagoByReferenciaAsync(string ReferenciaId);
    Task<OperationResult> GetAllPagosEntreFechasAsync(DateTime? fechaInicio, DateTime? fechaFin );
    Task<OperationResult> GetAllPagosByMetodoAsync(int IdMetodo);
    
    //metodos restantes
    Task<OperationResult> CreatePagoAsync(PagosModel pago);
    Task<OperationResult> UpdatePagoAsync(PagosModel pago, int adminId);
    Task<OperationResult> DeactivatePagoAsync(int idPago, int adminId);
    Task<ListOperationResult<PagosModel>> DeactivatePagosAsync(List<int> pagos, int adminId); 
    Task<OperationResult> ActivatePagoAsync(int idPago, int adminId);
    


}