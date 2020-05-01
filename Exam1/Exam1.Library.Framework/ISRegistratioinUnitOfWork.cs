using Exam1.Framework.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Library.Framework
{
    public interface ISRegistratioinUnitOfWork : IUnitOfWork<FrameworkContext>
    {
        IStudentRepository StudentRepository { set; get; }
       // ICourseRepository CourseRepository { set; get; }
    }
}
