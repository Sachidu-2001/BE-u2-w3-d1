using System.ComponentModel.DataAnnotations;

namespace ApiStudent.Models
{
    public class Student
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Cognome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
