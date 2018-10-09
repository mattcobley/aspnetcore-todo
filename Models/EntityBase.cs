using System.ComponentModel.DataAnnotations.Schema;

namespace aspnetcore_todo.Models
{
    public abstract class EntityBase
    {
        public int Id {get; set;}
    }
}