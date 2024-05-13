using Microsoft.EntityFrameworkCore;
using TO_DO.Domain.SubTask;
using TO_DO.Domain.TO_DOs;
using TO_DO.Domain.Userss;



namespace TO_DO.Persistence.Context
{
    public class TO_DOContext : DbContext
    {
        public TO_DOContext(DbContextOptions<TO_DOContext> options) :base(options) 
        {
            
        }

        public DbSet<Userss> users { get; set; }
        public DbSet<ToDos> ToDos { get; set; }
        public DbSet<Subtask> subtasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(TO_DOContext).Assembly);
        }
    }
}
