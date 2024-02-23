using System.ComponentModel;
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
        [DisplayName("Task name")]
        public string Name { get; set; }
        
        public string Status { get; set; }
        public DateTime Deadline { get; set; }
        public string Description { get; set; }

        public string GetDateStr()
        {
            string date="";
            for(int i=0; i<10; i++)
            {
                date += Deadline.ToString()[i];
            }

            return date;
        }
    }
}
