using Microsoft.EntityFrameworkCore;
using PMQ.CadastroClientes.Api.Infra.Data.Repositories.Interfaces;
using PMQ.CadastroClientes.Api.Models.Usuario;

namespace PMQ.CadastroClientes.Api.Infra.Data.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly CadastroClientesDbContext _dbContext;
        public UsuarioRepository(CadastroClientesDbContext cadastroClientesDbContext)
        {
            _dbContext = cadastroClientesDbContext;
        }
        public async Task<UsuarioModel> BuscarPorId(string id)
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

            return (usuario);
        }

        public async Task<UsuarioModel> AtualizarUsuario(UsuarioModel usuario, string id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário com o ID: {id} não foi encontrado na base de dados.");
            }

            usuarioPorId.Nome = usuario.Nome;
            usuarioPorId.Documento = usuario.Documento;
            usuarioPorId.Email = usuario.Email;
            usuarioPorId.Telefone = usuario.Telefone;
            usuarioPorId.Endereco = usuario.Endereco;

            _dbContext.Usuarios.Update(usuario);
            await _dbContext.SaveChangesAsync();

            return (usuarioPorId);
        }


        public async Task<bool> DeletarUsuario(string id)
        {
            UsuarioModel usuarioPorId = await BuscarPorId(id);

            if (usuarioPorId == null)
            {
                throw new Exception($"Usuário com o ID: {id} não foi encontrado na base de dados.");
            }

            _dbContext.Usuarios.Remove(usuarioPorId);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
