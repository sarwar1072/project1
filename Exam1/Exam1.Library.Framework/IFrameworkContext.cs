using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Library.Framework
{
    public interface IFrameworkContext
    {
        DbSet<Student> Student { get; set; }
       // DbSet<Course> Course { get; set; }
    }
}
