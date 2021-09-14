using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EStudy.Timetable.Domain.Models
{
    public class BaseCreateModel
    {
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedFromIP { get; set; }
    }

    public class BaseEditModel : BaseCreateModel
    {
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedFromIP { get; set; }
    }

    public class BaseModel : BaseEditModel { }
    public class BaseModel<T> : BaseModel
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T Id { get; set; }
    }
}