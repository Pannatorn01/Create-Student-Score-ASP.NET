using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The student name field is empty.")] //ห้ามเป็นค่าว่าง
        [DisplayName("Student Name")]
        public string Name { get; set; }

        [DisplayName("Test Score")]
        [Range(0,100,ErrorMessage = "The test scores must be in the range 0-100.")]
        public int Score { get; set; }
    }
}
