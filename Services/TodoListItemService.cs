using aspnetcore_todo.Models;
using aspnetcore_todo.Repositories;
using System.Collections.Generic;

namespace aspnetcore_todo.Services
{
    public class TodoListItemService : ITodoListItemService {

        private readonly IRepository<TodoItem> _todoItemRepository;

        public TodoListItemService(IRepository<TodoItem> todoItemRepository){
            _todoItemRepository = todoItemRepository;
        }

        public IList<TodoItem> getListItems(int listId)
        {
            var todoItems = new List<TodoItem>();
            var items = _todoItemRepository.GetAll(i => i.List.Id.Equals(listId));
            foreach (var todoItem in items)
            {
                todoItems.Add(todoItem);
            }
            return todoItems;
        }

        public TodoItem getById(int id)
        {
            return _todoItemRepository.GetById(id);
        }

        public void add(TodoItem item)
        {
            _todoItemRepository.Add(item);
        }

        public void delete(TodoItem item)
        {
            _todoItemRepository.Delete(item);
        }
    }
}