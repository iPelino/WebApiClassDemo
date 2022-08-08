using System.ComponentModel.DataAnnotations;

namespace WebApiClassDemo.Models;

public class Department
{
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(200, 
        ErrorMessage = "Name should not exceed 200 characters")]
    public string Name { get; set; }
}