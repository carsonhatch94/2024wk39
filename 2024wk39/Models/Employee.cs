using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace _2024wk39.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string? EmailAddress { get; set; }
        public string? Message { get; set; }
        public DateTime DateTime { get; set; }
    }
}
