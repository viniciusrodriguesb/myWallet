using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyWalletAPI.Models;

namespace MyWalletAPI.Map
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioModel>
    {
        public void Configure(EntityTypeBuilder<UsuarioModel> builder)
        {
            //Chave primária = Id
            builder.HasKey("Id");
            //Coluna no banco, e quanto de tamanho (caso de String)
            builder.Property(x => x.Name).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Usuario).IsRequired().HasMaxLength(255);
            builder.Property(x => x.email).IsRequired().HasMaxLength(255);
            builder.Property(x => x.password).IsRequired().HasMaxLength(255);
            builder.Property(x => x.phone).IsRequired().HasMaxLength(13);
            builder.Property(x => x.city).IsRequired().HasMaxLength(255);
            builder.Property(x => x.state).IsRequired().HasMaxLength(255);
            builder.Property(x => x.birth).IsRequired().HasMaxLength(255);
        }
    }
}
