using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6.Library.Framework
{
    public  interface IFrameworkContext
    {
        DbSet<Student> Student { get; set; }
        DbSet<Course> Course { get; set; }
    }
}
