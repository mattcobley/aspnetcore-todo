using aspnetcore_todo.Dtos;
using aspnetcore_todo.Models;
using aspnetcore_todo.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspnetcore_todo.Pages
{
    public class CreateItemModel : PageModel
    {
        private readonly ITodoListItemService _todoListItemService;
        private readonly ITodoListService _todoListService;

        public CreateItemModel(ITodoListItemService todoListItemService, ITodoListService todoListService)
        {
            _todoListItemService = todoListItemService;
            _todoListService = todoListService;
        }

        public IActionResult OnPost(TodoItemDto itemDto)
        {
            //Coming through without parameters filled in
            if (!ModelState.IsValid || itemDto.Name == null || itemDto.ListId == null)
            {
                return RedirectToPage("Index");
            }
            var listId = itemDto.ListId;
            var list = _todoListService.getById(listId);
            var item = new TodoItem { Name= itemDto.Name, IsComplete= false, List=list};
            _todoListItemService.add(item);

            return RedirectToPage("./TodoList", new {id = listId});
        }
    }
}