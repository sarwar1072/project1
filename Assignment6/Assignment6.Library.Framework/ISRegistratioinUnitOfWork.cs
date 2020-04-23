using Assignment6.Framework.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6.Library.Framework
{
   public interface ISRegistratioinUnitOfWork:IUnitofWork<FrameworkContext>
    {
        IStudentRepository StudentRepository { set; get; }
        ICourseRepository CourseRepository { set; get; }
    }
}
