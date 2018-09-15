using System.Collections.Generic;

namespace aspnetcore_todo.Models {
    public class TodoList : EntityBase
    {
        public string Name { get; set; }
        public List<TodoItem> Items { get; set; }
    }
}