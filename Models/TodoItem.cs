namespace aspnetcore_todo.Models
{
    public class TodoItem : EntityBase
    {
        public bool IsComplete { get; set; }
        public string Name { get; set; }
        public virtual TodoList List {get; set;}
    }
}