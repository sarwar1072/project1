using Assignment6.Framework.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6.Library.Framework
{
   public class CourseRepository :Repository<Course>,ICourseRepository
    {
        public CourseRepository(DbContext dbContext)
           : base(dbContext)
        {

        }
    }
}
