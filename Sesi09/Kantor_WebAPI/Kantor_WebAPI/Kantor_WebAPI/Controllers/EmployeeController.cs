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
        public ActionResult<IEnumerable<EmployeeItem>> AddEmployee(string nama, string jenisKelamin, string alamat)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;

            return _context.AddEmployee(nama, jenisKelamin,alamat);
        }

        [HttpPut("{id}")]
        public ActionResult<IEnumerable<EmployeeItem>> UpdateEmployeeItem(string id, string nama, string jenisKelamin, string alamat)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.UpdateEmployee(id, nama, jenisKelamin, alamat);
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