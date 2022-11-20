using PMQ.CadastroClientes.Api.Models.Usuario;

namespace PMQ.CadastroClientes.Api.Infra.Data.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(string id);
        Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario);
        Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, string id);
        Task<bool> DeletarUsuario(string id);
    }
}
