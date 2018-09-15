using aspnetcore_todo.Models;
using System.Collections.Generic;

namespace aspnetcore_todo.Services
{
    public interface ITodoListService
    {
        IList<TodoList> getAll();
    }
}