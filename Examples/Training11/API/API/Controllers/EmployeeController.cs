using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using API.Models;

namespace API.Controllers
{
    //[Route("api/v1/Employee")]
    public class EmployeeController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<Employee> Get()
        {
            return GetEmployees();
        }

        // GET api/<controller>/5
        public Employee Get(int id)
        {
            return GetEmployees().Where(emp => emp.EmployeeID == id).FirstOrDefault();
        }

        // POST api/<controller>
        public void Post([FromBody]Employee value)
        {
            List<Employee> employees = GetEmployees().ToList();
            employees.Add(value);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]Employee value)
        {
            Employee employee = GetEmployees().Where(emp => emp.EmployeeID == id).FirstOrDefault();
            employee.FirstName = value.FirstName;
            employee.LastName = value.LastName;
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            List<Employee> employees = GetEmployees().ToList();
            employees.Remove(employees.Where(emp => emp.EmployeeID == id).FirstOrDefault());
        }

        private IEnumerable<Employee> GetEmployees()
        {
            return new Employee[]
            {
                new Employee() { EmployeeID=1, FirstName="first1", LastName="last1" }
                ,new Employee() { EmployeeID=2, FirstName="first2", LastName="last2" }
                ,new Employee() { EmployeeID=3, FirstName="first3", LastName="last3" }
                ,new Employee() { EmployeeID=4, FirstName="first4", LastName="last4" }
            };
        }
    }
}