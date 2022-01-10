using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrudAPI.Models
{
    public class Student
    {
        // validation
        [Required(ErrorMessage = "This field is Required")]
        [StringLength(100, ErrorMessage = "string length can't be more than 100")]

        /// <summary>
        /// Student id
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// Student name
        /// </summary>
        public string StudentName { get; set; }

        /// <summary>
        /// Student Location
        /// </summary>
        public string StudentLocation { get; set; }
    }
}