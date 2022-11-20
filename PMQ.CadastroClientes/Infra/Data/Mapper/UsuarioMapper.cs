using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PMQ.CadastroClientes.Api.Models.Usuario;

namespace PMQ.CadastroClientes.Api.Infra.Data.Mapper
{
    public class UsuarioMappercs : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Documento).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Email).HasMaxLength(150);
            builder.Property(x => x.Telefone).IsRequired().HasMaxLength(150);
            builder.Property(x => x.Endereco).HasMaxLength(150);
        }
    }
}
