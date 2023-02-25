﻿using MyWalletAPI.Models;

namespace MyWalletAPI.Repositories.Interfaces
{
    public interface IUsuarioRepositorio
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();

        Task<UsuarioModel> BuscarUsuarioID(int id);

        Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario);

        Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, int id);

        Task<bool> ApagarUsuario(int id);
    }
}
