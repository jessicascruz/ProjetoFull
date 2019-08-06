using Microsoft.EntityFrameworkCore;
using Projeto.API.model;

namespace Projeto.API.Data
{
    public class DataContext : DbContext
    {
        
        public DataContext(DbContextOptions<DataContext> options) :base (options) {}
        public DbSet<Evento> Eventos { get; set; }

    }
}