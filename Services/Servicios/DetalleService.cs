using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using BioLabProject.Models;
using BioLabProject.Services;
using BioLabProject.Data;
using BioLabProject.Helpers;
using Microsoft.Extensions.DependencyInjection;
using BioLabProject.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BioLabProject.Services.Servicios;


public class DetalleService : IDetalleService
{
private readonly AppDbContext _context:

    public DetalleService(AppDbContext context) 
    { 
        _context = context;   
    }

    // metodos generales

    // obtener el detalle por ID
    public async Task<ObjectOperationResult> GetDetalleByIdAsync(int id)
    {
        try
        {
            var Detalle = _context.Detalles.AsNoTracking().FirstOrDefaultAsync(e => e.Id == id);
            if (Detalle == null) return new ObjectOperationResult(false, "El detalle asociado al Id no existe", null);
            return new ObjectOperationResult(true, "", Detalle);
                    
        }
        catch (Exception ex)
        {
            return new ObjectOperationResult(false, $"Error: {ex.Message}", null);
        }

    }

    // Obtener una lista de detalles por el id de la orden
    public async Task<ListOperationResult<DetalleModel>> GetDetallesByOrdenIdAsync(int oid)
    {
        try
        {
            var DetalleList = _context.Detalles
                .AsNoTracking()
                .Where(e => e.OrdenId == oid)
                .ToListAsync();


            if (DetalleList == null) return new ListOperationResult<DetalleModel>(false, "No existe ningun detalle asociado a esa orden", null);

            return new ListOperationResult<DetalleModel>(true, "", DetalleList);

        }
        catch (Exception ex) 
        {
            return new ListOperationResult<DetalleModel>(false, $"Error: {ex.Message}", null);

        }

    }

    // obtener un detalle por el id del examen relacionado
    public async Task<ObjectOperationResult> GetDetalleByExamenIdAsync(int Eid)
    {
        try
        {
            var DetalleList = _context.Detalles
                .AsNoTracking()
                .FirstOrDefaultAsync(d => d.ExamenId == Eid);


            if (DetalleList == null) return new ListOperationResult<DetalleModel>(false, "No existe ningun detalle asociado a ese Examen", null);

            return new ListOperationResult<DetalleModel>(true, "", DetalleList);

        }
        catch (Exception ex)
        {
            return new ListOperationResult<DetalleModel>(false, $"Error: {ex.Message}", null);

        } 
    }
    
    // crear un detalle
    public async Task<OperationResult> CreateDetalleAsync(DetalleModel detalle)
    {

    }

    // actualiza un detalle
    public async Task<OperationResult> UpdateDetalleAsync(DetalleModel detalle, int AdminId)
    {

    }

    //metodos auxiliares.


}