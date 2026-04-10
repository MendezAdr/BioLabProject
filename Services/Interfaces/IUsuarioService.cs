using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BioLabProject.Models;
using BioLabProject.Services.Interfaces;


namespace BioLabProject.Services.Interfaces;

public interface IUsuarioService
{
    Task<OperationResult?> LoginAsync(string cedula);

    Task<OperationResult> CreateUsuarioAsync(UsuarioModel usuario, int adminId);

    Task<OperationResult> UpdateUsuarioAsync(UsuarioModel usuario, int adminId);

    Task<OperationResult> ChangePasswordAsync(int usuarioId, string newPassword, int adminId);

    Task<OperationResult> DeactivateUsuarioAsync(int Id, int adminId);

    Task<OperationResult> ActivateUsuarioAsync(int Id, int adminId);

    Task<OperationResult> GetUserAsync(int id, int adminId);

    Task<ListOperationResult<UsuarioModel>> GetAllUsuariosAsync(int adminId);


}