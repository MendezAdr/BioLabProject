using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BioLabProject.Models;
using BioLabProject.Services.Interfaces;


namespace BioLabProject.Services.Interfaces;

public interface IOrdenesService
{   
    //Listados filtrados para contabilidad 
    
    
    
    Task<OperationResult> GetOrdenPorIdAsync(int id, int AdminId);
    
    //Task<ListOperationResult<OrdenesModel>> GetAllOrdenesAsync(int AdminId);
    
    Task<ListOperationResult<OrdenesModel>> GetAllOrdenesPorPacienteAsync(int idPaciente, int AdminId);
    
    Task<ListOperationResult<OrdenesModel>> GetAllOrdenesPorFechaAsync(DateTime date, int AdminId);
    
    Task<ListOperationResult<OrdenesModel>> GetAllOrdenesPorFechaEIdAsync(DateTime date, int id, int AdminId);
    
    Task<ListOperationResult<OrdenesModel>> GetAllOrdenesEntreFechasAsync(DateTime date1, DateTime date2, int AdminId);
    
    Task<ListOperationResult<OrdenesModel>> GetAllOrdenesByEstadoAsync(int state, int AdminId);

    
    //operaciones generales
    Task<OperationResult> CreateOrdenAsync(OrdenesModel orden);
    Task<OperationResult> UpdateEstadoOrdenAsync(int estado);
    Task<OperationResult> DeactivateOrdenAsync(int id,  int AdminId);

}