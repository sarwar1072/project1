using Exam1.Framework.Data;
using System;
using System.Collections.Generic;
using System.Text;
namespace Exam1.Library.Framework
{
    public class SRegistrationUnitOfWork : UnitOfWork<FrameworkContext>, ISRegistratioinUnitOfWork
    {
        public IStudentRepository StudentRepository { set; get; }
       
        public SRegistrationUnitOfWork(string connectionString, string migrationAssemblyName)
           : base(connectionString, migrationAssemblyName)
        {
            StudentRepository = new StudentRepository(_dbContext);
          
        }
    }
}
