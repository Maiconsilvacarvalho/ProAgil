

using Microsoft.EntityFrameworkCore;
using ProAgil.API22.model;

namespace ProAgil.API22.Data{
    public class DataContext : DbContext{
        public DataContext(DbContextOptions<DataContext> options) : base (options){}

        public DbSet<Evento> Eventos { get; set; }
    }
}