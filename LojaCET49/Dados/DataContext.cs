using LojaCET49.Dados.Entidades;
using Microsoft.EntityFrameworkCore;

namespace LojaCET49.Dados
{
    public class DataContext : DbContext
    {

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
