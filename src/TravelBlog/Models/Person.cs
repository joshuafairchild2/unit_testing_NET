using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TravelBlog.Models
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int PeopleId { get; set; }
        public string Name { get; set; }
        public int ExperienceId { get; set; }
        public virtual Experience Experience { get; set; }
    }
}
