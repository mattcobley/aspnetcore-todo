using aspnetcore_todo.Models;
using aspnetcore_todo.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcore_todo.Pages
{
    public class TodoListModel : PageModel
    {
        private readonly ITodoListItemService _todoListItemService;
        private readonly ITodoListService _todoListService;

        public TodoList Target { get; set; }

        public TodoListModel(ITodoListItemService todoListItemService, ITodoListService todoListService){
            _todoListItemService = todoListItemService;
            _todoListService = todoListService;
        }

        public void OnGet(int id)
        {
            var list = _todoListService.getById(id);
            Target = list;
        }
    }
}