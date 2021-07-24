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
       // private static List<Student> students = new List<Student>();
        private static StudentContxt contxt = new StudentContxt();
        // GET api/Student
        public IEnumerable<Student> Get()
        {
           return contxt.students.ToList();
        }

        // GET api/Student/1001
        public Student Get(int id)
        {
            return contxt.students.Where(s => s.ID == id).FirstOrDefault();
          
        }

        // POST api/Student
        public void Post([FromBody]Student student)
        {
            contxt.students.Add(student);
            contxt.SaveChanges();

        }

        // PUT api/Student/1001
        public void Put(int id, [FromBody]Student student)
        {
            var st = contxt.students.Where(s => s.ID == id).FirstOrDefault();
           
            if (st!=null)
            {
                st.Name = student.Name;
                st.Class = student.Class;

                contxt.SaveChanges();
            }

           
        }

        // DELETE api/Student/1001
        public void Delete(int id)
        {
            var st = contxt.students.Where(s => s.ID == id).FirstOrDefault();

            if (st != null)
            {
                contxt.students.Remove(st);

                contxt.SaveChanges();
            }
        }

        ~StudentController()
        {
            contxt.Dispose();
        
        }
    }
}