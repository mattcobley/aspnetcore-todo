using aspnetcore_todo.Models;
using aspnetcore_todo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcore_todo.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly ITodoListService _todoListService;

        public DeleteModel(ITodoListService todoListService)
        {
            _todoListService = todoListService;
        }

        [BindProperty]
        public TodoList ListToDelete { get; set; }

        public void OnGet(int id)
        {
            ListToDelete = _todoListService.getById(id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _todoListService.delete(ListToDelete);

            return RedirectToPage("Index");
        }
    }
}