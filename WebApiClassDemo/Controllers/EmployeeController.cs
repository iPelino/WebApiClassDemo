using Microsoft.AspNetCore.Mvc;

namespace WebApiClassDemo.Controllers;

[ApiController]
[Route("{controller}")]   //employee
public class EmployeeController:ControllerBase
{
    [Route("all")]
    [HttpGet]
    public string GetEmployees()
    {
        return "Hello World";
    }

    [Route("employees/{name}")]
    public string SingleEmployee(string name)
    {
        return name;
    }
}