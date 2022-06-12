using System;
using System.ComponentModel.DataAnnotations;
namespace ModelBinding.Models
{
    public class Employee
    {
        [Required]
        [MinLength(3)]
        [MaxLength(15)]
        public string Name { get; set; }

        [Required]
        [Range(10, 30)]
        public int Age { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Url]
        public string Url { get; set; }
    }

    public enum Gender
    {
        Male, Female, Others
    }
}
