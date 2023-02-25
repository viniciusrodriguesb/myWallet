using Microsoft.EntityFrameworkCore;
using MyWalletAPI.Models;

namespace MyWalletAPI.Data.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<UsuarioModel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.nome).IsRequired().HasMaxLength(100);
            builder.Property(x => x.usuario).IsRequired().HasMaxLength(100);
            builder.Property(x => x.email).IsRequired().HasMaxLength(100);
            builder.Property(x => x.senha).IsRequired().HasMaxLength(14);
            builder.Property(x => x.telefone).IsRequired().HasMaxLength(20);
            builder.Property(x => x.cidade).IsRequired().HasMaxLength(70);
            builder.Property(x => x.estado).IsRequired().HasMaxLength(70);
            builder.Property(x => x.aniversario).IsRequired().HasMaxLength(10);
        }
    }
}