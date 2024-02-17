using System.ComponentModel.DataAnnotations;
using TDL_ASP.Utilities;

namespace TDL_ASP.Models
{
    public class ToDoTask
    {
        [Key]
        public int Id { get; set; }
        public int Order { get; set; }
        public PriorityEnum Priority { get; set; }
        [Required]
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }
    }
}
