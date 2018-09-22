using aspnetcore_todo.Models;
using aspnetcore_todo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcore_todo.Pages
{
    public class CreateModel : PageModel
    {
        private readonly ITodoListService _todoListService;

        public CreateModel(ITodoListService todoListService)
        {
            _todoListService = todoListService;
        }

        [BindProperty]
        public TodoList TodoList { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _todoListService.add(TodoList);
            return RedirectToPage("Index");
        }
    }
}