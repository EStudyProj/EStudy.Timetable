using System.ComponentModel.DataAnnotations;
namespace EStudy.Timetable.Domain.Models
{
    public class Group : BaseModel<int>
    {
        [Required, MinLength(3), MaxLength(250)]
        public string Name { get; set; }
        public string NameEng { get; set; }
        public int Course { get; set; }
        public int FacultyId { get; set; }
        public Faculty Faculty { get; set; }
    }
}