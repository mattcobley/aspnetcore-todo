using aspnetcore_todo.Models;
using aspnetcore_todo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcore_todo.Pages
{
    public class DeleteItemModel : PageModel
    {
        private readonly ITodoListItemService _todoListItemService;

        public DeleteItemModel(ITodoListItemService todoListItemService)
        {
            _todoListItemService = todoListItemService;
        }

        [BindProperty]
        public TodoItem ItemToDelete { get; set; }

        public void OnGet(int id)
        {
            //TODO test add and delete items in list

            ItemToDelete = _todoListItemService.getById(id);
        }

        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _todoListItemService.delete(ItemToDelete);

            return RedirectToPage("Index");
        }
    }
}