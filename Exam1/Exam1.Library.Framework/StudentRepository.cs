using Exam1.Framework.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Library.Framework
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
