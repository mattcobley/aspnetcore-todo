using aspnetcore_todo.Models;
using System.Collections.Generic;

namespace aspnetcore_todo.Services
{
    public interface ITodoListItemService
    {
        IList<TodoItem> getListItems(int listId);
        TodoItem getById(int id);
        void add(TodoItem item);
        void delete(TodoItem item);
    }
}