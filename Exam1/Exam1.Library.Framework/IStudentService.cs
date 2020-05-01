using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Library.Framework
{
    public interface IStudentService
    {
        void AddNewStudent(Student student);

        Student getStudentById(int Id);
       // void updateStuent(Student student);
       
    }
}
