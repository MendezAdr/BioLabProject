using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BioLabProject.Models;
using BioLabProject.Services.Interfaces;

namespace BioLabProject.Services.Interfaces;

public interface IExamenesService
{
    Task<OperationResult> GetExamenByIdAsync(int id);
    Task<OperationResult> GetExamenesAsync();
    Task<OperationResult> CreateExamenAsync(ExamenModel model, int AdminId);
    
    
}