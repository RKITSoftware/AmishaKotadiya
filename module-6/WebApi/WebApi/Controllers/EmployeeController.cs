using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{    public class EmployeeController : ApiController
    {
        // create list type of employee object
        public List<Employee> employees = new List<Employee>
        {
            new Employee(1,"amisha","kotadiya","Lalpur",DateTime.Today),
            new Employee(2,"dhruvi","pandya","Rajkot",DateTime.Today),
            new Employee(3,"mihir","savjani","Porbandar",DateTime.Today),
            new Employee(4,"parth","kotadiya","Ahmedabad",DateTime.Today)
        };
        
        /// <summary>
        /// get method
        /// </summary>
        /// <returns>employees detail</returns>
        [HttpGet]
        public List<Employee> Get()
        {
            return employees;
        }

        /// <summary>
        /// get method
        /// </summary>
        /// <param name="id">employee id</param>
        /// <returns>employee detail</returns>
        [HttpGet]
        public Employee Get(int id)
        {
            Employee employee = employees.Find(e => e.Id == id);
            return employee;
        }

        /// <summary>
        /// employee post method
        /// </summary>
        /// <param name="employee">for employee</param>
        /// <returns>employee detail</returns>
        [HttpPost]
        public List<Employee> Post([FromBody] Employee employee)
        {
            employees.Add(employee);
            return employees;
        }

        /// <summary>
        /// employee put method
        /// </summary>
        /// <param name="id">employee id</param>
        /// <param name="employee">employee details</param>
        /// <returns>employee detail</returns>
        [HttpPut]
        public List<Employee> Put(int id, [FromBody] Employee employee)
        {
            Employee friendToUpdate = employees.Find(f => f.Id == id);
            int index = employees.IndexOf(friendToUpdate);

            employees[index].Firstname = employee.Firstname;
            employees[index].Lastname = employee.Lastname;
            employees[index].Location = employee.Location;
            employees[index].DateOfHire = employee.DateOfHire;

            return employees;
        }

        /// <summary>
        /// delete method
        /// </summary>
        /// <param name="id">employee id</param>
        /// <returns>employee detail</returns>
        [HttpDelete]
        public List<Employee> Delete(int id)
        {
            Employee employee = employees.Find(f => f.Id == id);
            employees.Remove(employee);
            return employees;
        }
    }
}
