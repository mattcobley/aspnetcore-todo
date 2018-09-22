using aspnetcore_todo.Models;
using aspnetcore_todo.Repositories;
using System.Collections.Generic;

namespace aspnetcore_todo.Services
{
    public class TodoListService : ITodoListService {

        private readonly IRepository<TodoList> _todoRepository;

        public TodoListService(IRepository<TodoList> todoRepository){
            _todoRepository = todoRepository;
        }

        public IList<TodoList> getAll()
        {
            var todoLists = new List<TodoList>();
            foreach(var todoList in _todoRepository.GetAll())
            {
                todoLists.Add(todoList);
            }
            return todoLists;
        }

        public void add(TodoList list)
        {
            _todoRepository.Add(list);
        }

        public void delete(TodoList list)
        {
            _todoRepository.Delete(list);
        }
    }
}