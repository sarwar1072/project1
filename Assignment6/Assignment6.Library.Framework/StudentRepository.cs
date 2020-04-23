using Assignment6.Framework.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6.Library.Framework
{
    public class StudentRepository: Repository<Student>,IStudentRepository
    {
        public StudentRepository(DbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
