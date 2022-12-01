using PMQ.CadastroClientes.Api.Models.Usuario;

namespace PMQ.CadastroClientes.Api.Infra.Data.Repositories.Interfaces
{
    public interface IUsuarioRepository
    {
        Task<List<UsuarioModel>> BuscarTodosUsuarios();
        Task<UsuarioModel> BuscarPorId(int id);
        Task<UsuarioModel> AdicionarUsuario(UsuarioModel usuario);
        Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, int id);
        Task<bool> DeletarUsuario(int id);
    }
}
