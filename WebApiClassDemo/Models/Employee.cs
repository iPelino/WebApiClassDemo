using System.ComponentModel.DataAnnotations;

namespace WebApiClassDemo.Models;

public class Employee
{
    [Required]
    public int Id { get; set; }
    
    [Required]
    [StringLength(100)]
    public string FirstName { get; set; }
    
}