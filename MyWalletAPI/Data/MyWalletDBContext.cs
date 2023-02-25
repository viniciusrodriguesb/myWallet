using Microsoft.EntityFrameworkCore;
using MyWalletAPI.Map;
using MyWalletAPI.Models;

//Trabalhando com ORM, independe de qual banco está sendo usado
//Nesta classe será a configuração das tabelas no banco
//Assim que o script for rodado, será criado a tabela

namespace MyWalletAPI.Data
{
    public class MyWalletDBContext : DbContext
    {
        public MyWalletDBContext(DbContextOptions<MyWalletDBContext> options)
       : base(options)
        {
        }
        public DbSet<UsuarioModel> Usuarios { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
