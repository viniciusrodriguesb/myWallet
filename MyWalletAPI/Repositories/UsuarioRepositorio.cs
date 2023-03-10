using Microsoft.EntityFrameworkCore;
using MyWalletAPI.Data;
using MyWalletAPI.Models;
using MyWalletAPI.Repositories.Interfaces;
using System.Linq.Expressions;

namespace MyWalletAPI.Repositories
{
    public class UsuarioRepositorio : IUsuarioRepositorio
    {
        private readonly MyWalletDBContext _dbContext;
        public UsuarioRepositorio(MyWalletDBContext myWalletDBContext)
        {
            _dbContext = myWalletDBContext;
        }

        public async Task<UsuarioModel> BuscarUsuarioID(int id)
        {
            return await _dbContext.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UsuarioModel>> BuscarTodosUsuarios()
        {
            return await _dbContext.Usuarios.ToListAsync();
        }

        public async Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario)
        {
            await _dbContext.Usuarios.AddAsync(usuario);
            await _dbContext.SaveChangesAsync();

            return usuario;
        }

        public async Task<bool> ApagarUsuario(int id)
        {
            UsuarioModel usuarioPorID = await BuscarUsuarioID(id);

            if (usuarioPorID == null)
            {
                throw new Exception($"Usuário ID: {id} não foi encontrado.");
            }

            _dbContext.Usuarios.Remove(usuarioPorID);
            await _dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, int id)
        {
            UsuarioModel usuarioPorID = await BuscarUsuarioID(id);

            if (usuarioPorID == null)
            {
                throw new Exception($"Usuário ID: {id} não foi encontrado.");
            }

            usuarioPorID.Name = usuario.Name;
            usuarioPorID.Usuario = usuario.Usuario;
            usuarioPorID.email = usuario.email;
            usuarioPorID.password = usuario.password;
            usuarioPorID.phone = usuario.phone;
            usuarioPorID.city = usuario.city;
            usuarioPorID.birth = usuario.birth;

            _dbContext.Usuarios.Update(usuarioPorID);
            await _dbContext.SaveChangesAsync();

            return usuarioPorID;
        }
    }
}
