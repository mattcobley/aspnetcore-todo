namespace aspnetcore_todo.Models
{
    public class TodoItem : EntityBase
    {
        public bool IsComplete { get; set; }
        public string Name { get; set; }
    }
}