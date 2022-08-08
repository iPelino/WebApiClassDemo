using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiClassDemo.Data;
using WebApiClassDemo.Models;

namespace WebApiClassDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public DepartmentController(ApplicationContext context)
        {
            _context = context;
        }
        
        // GET: api/Department
        [HttpGet]
        public async Task<List<Department>> Get()
        {
            return await _context.Departments.ToListAsync();
        }

        // GET: api/Department/5
        [HttpGet("{id}", Name = "Get")]
        public Department? Get(int id)
        {
            return _context.Departments.Find(id);
        }

        // POST: api/Department
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Department/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Department/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
