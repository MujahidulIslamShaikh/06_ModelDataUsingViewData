using System.ComponentModel.DataAnnotations;

namespace ModelDataUsingViewData.Models
{
    public class Student
    {
        //public int StudId { get; set; }
        [Required] // validation attribite / data annotation
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
        public string Married { get; set; }
        public string Description { get; set; }
    }
    public enum Gender
    {
        Male,Female
    }
}
