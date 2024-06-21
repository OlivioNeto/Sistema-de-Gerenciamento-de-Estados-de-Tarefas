using Microsoft.EntityFrameworkCore;
using Sistema_de_Gerenciamento_de_Estados_de_Tarefas.Model;

namespace Sistema_de_Gerenciamento_de_Estados_de_Tarefas.Data
{
    public class StateDBContext : DbContext
    {
        public StateDBContext(DbContextOptions<StateDBContext> options) : base(options) { }
        public DbSet<TaskModel> TasksModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TaskModel>().Property(t => t.State);

            base.OnModelCreating(modelBuilder);
        }
    }
}
