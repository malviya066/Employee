using Employee.Modal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Controllers
{

    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        [HttpGet("get.{format}"), FormatFilter]
        public IEnumerable<Employees> Get()
        {
            List<Employees> employees = new List<Employees>
            {
                new Employees { Id = 1, Name = "Sarath Lal",City="Cochin" },
                new Employees { Id = 2, Name = "Anil Kumar",City="Bangalore"}
            };
            return employees;
        }

        [HttpPost("post.{format}"), FormatFilter]
        public Employees Post([FromBody] Employees employee)
        {
            if (ModelState.IsValid)
            {
                return employee;
            }
            else
            {
                return null;
            }
        }

    }
}
