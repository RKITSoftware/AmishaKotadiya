using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrudAPI.Models;
using MySql.Data.MySqlClient;

namespace CrudAPI.Class
{
    public class BLStudent
    {
        #region public members
        // connection string
        public static string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlconnection"].ConnectionString;

        /// <summary>
        /// Retrive all data
        /// </summary>
        /// <returns>all students</returns>
        public List<Student> selectAll()
        {
            List<Student> students = new List<Student>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from student", conn);

                    //read data
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.Add(new Student()
                            {
                                StudentID = Convert.ToInt32(reader["StudentID"]),
                                StudentName = reader["StudentName"].ToString(),
                                StudentLocation = reader["StudentLocation"].ToString(),

                            });
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Can't open connection !");

                }
                // finally block always execute
                finally
                {
                    //close connection
                    conn.Close();
                }

            }
            return students;
        }

        /// <summary>
        /// retrive student using id
        /// </summary>
        /// <param name="id">student id</param>
        /// <returns>retrive particular student</returns>
        public Student getStudentById(int id)
        {
            Student students = new Student();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("select * from student where StudentID = " + id + ";", conn);

                    //read data
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            students.StudentID = Convert.ToInt32(reader["StudentID"]);
                            students.StudentName = reader["StudentName"].ToString();
                            students.StudentLocation = reader["StudentLocation"].ToString();
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Can't open connection !");

                }
                // finally block always execute
                finally
                {
                    //close connection
                    conn.Close();
                }

            }
            return students;
        }

        /// <summary>
        /// insert student record in database
        /// </summary>
        /// <param name="objStudent">student object</param>
        /// <returns>message successfull or not</returns>
        public string insertStudent(Student objStudent)
        {
            List<Student> students = new List<Student>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();

                    //add data
                    MySqlCommand cmd = new MySqlCommand("insert into student (StudentId,StudentName,StudentLocation) values('" + objStudent.StudentID + "','" + objStudent.StudentName + "','" + objStudent.StudentLocation + "';", conn);

                    int effect = cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception ex)
                {
                    return "Can't open connection with error - " + ex.Message;
                }
                // finally block always execute
                finally
                {
                    //close connection
                    conn.Close();
                }
            }
        }

        /// <summary>
        /// delete student by id
        /// </summary>
        /// <param name="id">student id</param>
        /// <returns>message successfull delete or not.</returns>
        public string deleteStudent(int id)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();

                    //delete command with id
                    MySqlCommand cmd = new MySqlCommand("delete from student where id = " + id, conn);

                    int effect = cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception e)
                {
                    return "Can't open connection with error - " + e.Message;
                }
                // finally block always execute
                finally
                {
                    //close connection
                    conn.Close();
                }

            }
        }

        /// <summary>
        /// update student record
        /// </summary>
        /// <param name="objStudent">student object</param>
        /// <returns>message successfull update or not</returns>
        public string updateStudent(Student objStudent)
        {
            List<Student> students = new List<Student>();

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    //open connection
                    conn.Open();

                    //update data
                    MySqlCommand cmd = new MySqlCommand("update countries set StudentName = '" + objStudent.StudentName + "',StudentLocation = '" + objStudent.StudentLocation + "';", conn);


                    int effect = cmd.ExecuteNonQuery();
                    if (effect > 0)
                    {
                        return "successfull";
                    }
                    return "Not successfull query";


                }
                catch (Exception e)
                {
                    return "Can't open connection with error - " + e.Message;
                }
                //finally block always execute
                finally
                {
                    //close connection
                    conn.Close();
                }

            }
        }
        #endregion public members
    }
}