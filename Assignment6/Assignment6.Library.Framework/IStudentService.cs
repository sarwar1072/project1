using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6.Library.Framework
{
   public interface IStudentService
    {
        void AddNewStudent(Student student);

        Student getStudentById(int Id);
        void updateStuent(Student student);
        void deleteStudent(int Id);
    }
}
