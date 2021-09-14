using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace EStudy.Timetable.Domain.Models
{
    public class Faculty : BaseModel<int>
    {
        [Required, MinLength(3), MaxLength(250)]
        public string Name { get; set; }
        [MinLength(3), MaxLength(250)]
        public string NameEng { get; set; }
        public string Description { get; set; }
        public List<Group> Groups { get; set; }
    }
}