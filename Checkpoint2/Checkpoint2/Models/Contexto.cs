using Microsoft.EntityFrameworkCore;

namespace Checkpoint2.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        //Criando os DBSet responsáveis por criar e executar as consultas de CRUD com banco, sendo Select, Update, Insert e Delete
        public DbSet<Receita> Receita { get; set; }
        public DbSet<Categoria> Categoria { get; set; }
    }
}
