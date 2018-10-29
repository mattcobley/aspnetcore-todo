using aspnetcore_todo.Models;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore_todo.Database
{
    public class AppDbContext : DbContext
    {
        private DbSet<TodoList> _todoLists;
        private DbSet<TodoItem> _todoItems;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<TodoList> TodoLists { get => _todoLists; set => _todoLists = value; }
        public DbSet<TodoItem> TodoItems { get => _todoItems; set => _todoItems = value; }

    }
}