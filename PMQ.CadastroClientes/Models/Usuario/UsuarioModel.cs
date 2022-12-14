using System.ComponentModel.DataAnnotations;

namespace PMQ.CadastroClientes.Api.Models.Usuario
{
    public class UsuarioModel
    {
        
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Documento { get; set; }
        public string? Email { get; set; }
        public string? Telefone { get; set; }
        public string? Endereco { get; set; }
    }
}
