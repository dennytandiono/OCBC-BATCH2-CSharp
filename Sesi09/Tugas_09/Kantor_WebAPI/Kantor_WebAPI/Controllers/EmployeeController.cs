using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Kantor_WebAPI.Models;

namespace Kantor_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;

        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        [HttpPost]
        public ActionResult<IEnumerable<EmployeeItem>> AddEmployee(EmployeeItem data)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.AddEmployee(data);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<EmployeeItem>> UpdateEmployeeItem(string id,EmployeeItem data)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            var temp = _context.UpdateEmployee(id, data);
            if (temp.Count == 0) return NotFound("Employee Not found");
            return temp;
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<EmployeeItem>> DeleteEmployeeItem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.DeleteEmployee(id);
        }

        [HttpGet(Name = "GetEmployee")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            return _context.GetAllEmployee();
        }

        [HttpGet("{id}", Name = "GetEmployeeById")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(String id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            return _context.GetEmployee(id);
        }
    }
}