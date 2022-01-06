using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Web.Mvc;
using CrudAPI.Class;
using CrudAPI.Models;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace CrudAPI.Controllers
{
    public class StudentController : Controller
    {
            #region Public members
            //object of BLClass
            BLStudent objdatabase = new BLStudent();

            /// <summary>
            /// Get all student
            /// </summary>
            /// <returns>retrive all student</returns>
            [System.Web.Http.Route("api/Getall")]
            public List<Student> GetAll()
            {
                return objdatabase.selectAll();
            }

            /// <summary>
            /// retrive student by id
            /// </summary>
            /// <param name="id">student id</param>
            /// <returns>particular student</returns>
            [System.Web.Http.Route("api/Get/{id}")]
            public Student Get(int id)
            {
                return (objdatabase.getStudentById(id));
            }

            /// <summary>
            /// insert student record iin database
            /// </summary>
            /// <param name="objStudent">student object</param>
            /// <returns>message successfull delete or not</returns>
            [HttpPost]
            [System.Web.Http.Route("api/Insert")]
            public string Insert([FromBody] Student objStudent)
            {
                return objdatabase.insertStudent(objStudent);
            }

            /// <summary>
            /// update student record iin database
            /// </summary>
            /// <param name="objStudent">student object</param>
            /// <returns>message successfull delete or not</returns>
            [HttpPost]
            [System.Web.Http.Route("api/Update")]
            public string Update([FromBody] Student objStudent)
            {
                return objdatabase.updateStudent(objStudent);
            }

            /// <summary>
            /// delete student record in database using id
            /// </summary>
            /// <param name="id">student id</param>
            /// <returns>message successfull delete or not</returns>
            [System.Web.Http.Route("api/Delete/{id}")]
            public string Delete(int id)
            {
                return objdatabase.deleteStudent(id);
            }
            #endregion Public members
    }
}