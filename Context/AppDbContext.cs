using Microsoft.EntityFrameworkCore;

namespace aspnetcore_todo.database
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {

        }
        
        //public DbSet<TodoList> TodoLists { get; set; }
    }
}