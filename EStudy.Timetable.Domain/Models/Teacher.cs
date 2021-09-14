namespace EStudy.Timetable.Domain.Models
{
    public class Teacher : BaseModel<int>
    {
        public string Name { get; set; }
        public string NameEng { get; set; }
    }
}