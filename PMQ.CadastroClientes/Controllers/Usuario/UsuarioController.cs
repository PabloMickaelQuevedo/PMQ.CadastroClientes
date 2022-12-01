using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMQ.CadastroClientes.Api.Infra.Data.Repositories.Interfaces;
using PMQ.CadastroClientes.Api.Models.Usuario;

namespace PMQ.CadastroClientes.Api.Controllers.Usuario
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> BuscarTodosUsuarios()
        {
            List<UsuarioModel> usuarios = await _usuarioRepository.BuscarTodosUsuarios();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioModel>> BuscarPorId(int id)
        {
            UsuarioModel usuario = await _usuarioRepository.BuscarPorId(id);
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<UsuarioModel>> Cadastrar([FromBody] UsuarioModel usuarioModel)
        {
            UsuarioModel usuario = await _usuarioRepository.AdicionarUsuario(usuarioModel);

            return Ok(usuario);

        }

        [HttpPut("{id}")]
        public async Task<ActionResult<UsuarioModel>> Atualizar([FromBody] UsuarioModel usuarioModel, int id)
        {
            usuarioModel.Id = id;
            UsuarioModel usuario = await _usuarioRepository.AtualizarUsuario(usuarioModel, id);

            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<UsuarioModel>> Deletar(int id)
        {
            bool deletado = await _usuarioRepository.DeletarUsuario(id);

            return Ok(deletado);
        }
    }
}
