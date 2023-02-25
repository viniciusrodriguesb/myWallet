using Microsoft.AspNetCore.Mvc;
using MyWalletAPI.Models;
using MyWalletAPI.Repositories;
using MyWalletAPI.Repositories.Interfaces;

namespace MyWalletAPI.Controllers
{
    //URL na qual será visualizado o endpoint
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        public readonly IUsuarioRepositorio _usuarioRepositorio;

        public UsuarioController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios()
        {
            List<UsuarioModel> usuario = await _usuarioRepositorio.BuscarTodosUsuarios();
            return Ok();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarPorID(int id)
        {
            UsuarioModel usuario = await _usuarioRepositorio.BuscarUsuarioID(id);
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<List<UsuarioModel>>> Cadastrar([FromBody] UsuarioModel usuarioModel)
        {
            UsuarioModel usuario = await _usuarioRepositorio.AdicionarUsuario(usuarioModel);
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<UsuarioModel>>> Atualizar([FromBody] UsuarioModel usuarioModel, int id)
        {
            usuarioModel.Id = id;
            UsuarioModel usuario = await _usuarioRepositorio.AtualizarUsuario(usuarioModel, id);
            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<UsuarioModel>>> Apagar(int id)
        {
            bool apagado = await _usuarioRepositorio.ApagarUsuario(id);
            return Ok(apagado);
        }
    }
}
