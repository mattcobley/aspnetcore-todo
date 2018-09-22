using aspnetcore_todo.Models;
using aspnetcore_todo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace aspnetcore_todo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ITodoListService _todoListService;

        public IndexModel(ITodoListService todoListService)
        {
            _todoListService = todoListService;
        }

        [BindProperty]
        public IList<TodoList> TodoLists { get; set; }
        
        public void OnGet()
        {
            SetTodoLists();
        }

        private void SetTodoLists()
        {
            TodoLists = _todoListService.getAll();
        }
    }
}
