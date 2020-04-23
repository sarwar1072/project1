using Assignment6.Framework.Data;
using System;
using System.Collections.Generic;
using System.Text;
namespace Assignment6.Library.Framework
{
  public  class SRegistrationUnitOfWork : UnitofWork<FrameworkContext>,ISRegistratioinUnitOfWork
    {
        public IStudentRepository StudentRepository { set; get; }
        public ICourseRepository CourseRepository { set; get; }
        public SRegistrationUnitOfWork(string connectionString, string migrationAssemblyName)
           : base(connectionString, migrationAssemblyName)
        {
            StudentRepository = new StudentRepository(_dbContext);
            CourseRepository = new CourseRepository(_dbContext);
        }
    }
}
