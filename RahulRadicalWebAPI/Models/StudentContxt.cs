using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace RahulRadicalWebAPI.Models
{
    public class StudentContxt :DbContext
    {
        public StudentContxt()
            :base("name=constr")
        {

        }

        public DbSet<Student> students { get; set; }

    }
}