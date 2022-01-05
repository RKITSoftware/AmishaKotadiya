using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class Employee
    {
        /// <summary>
        /// Constuctor of employee
        /// </summary>
        /// <param name="v1">id</param>
        /// <param name="v2">firstname</param>
        /// <param name="v3">lastname</param>
        /// <param name="v4">location</param>
        /// <param name="today">date of hire</param>
        public Employee(int v1, string v2, string v3, string v4, DateTime today)
        {
            
        }

        /// <summary>
        /// employee id method
        /// </summary>
        [Required(ErrorMessage = "employee id is required")]
        [Range(1, 150)]
        public int Id { get; set; }

        /// <summary>
        /// employee firstname method
        /// </summary>
        public string Firstname { get; set; }

        /// <summary>
        /// employee lastname method
        /// </summary>
        public string Lastname { get; set; }

        /// <summary>
        /// employee location method
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// employee date of hiring method
        /// </summary>
        [Required(ErrorMessage = "employee Hire date is required")]
        public DateTime DateOfHire { get; set; }
    }
}