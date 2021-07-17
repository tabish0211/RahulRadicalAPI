using RahulRadicalWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RahulRadicalWebAPI.Controllers
{
    public class StudentController : ApiController
    {
        private static List<Student> students = new List<Student>();
        // GET api/Student
        public IEnumerable<Student> Get()
        {
            return students;
        }

        // GET api/Student/1001
        public Student Get(int id)
        {
            return students.Where(s => s.ID == id).FirstOrDefault();
        }

        // POST api/Student
        public void Post([FromBody]Student student)
        {
            students.Add(student);

        }

        // PUT api/Student/1001
        public void Put(int id, [FromBody]Student student)
        {
            var st = students.Where(s => s.ID == id).FirstOrDefault();

            if (st !=null)
            {
                st.Name = student.Name;
                st.Class = student.Class;
            }

            students.Remove(students.Where(s => s.ID == id).FirstOrDefault());
            students.Add(st);
        }

        // DELETE api/Student/1001
        public void Delete(int id)
        {
            var st = students.Where(s => s.ID == id).FirstOrDefault();

            if (st !=null)
            {
                students.Remove(st);
            }
        }
    }
}