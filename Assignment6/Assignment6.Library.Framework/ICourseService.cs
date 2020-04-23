using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6.Library.Framework
{
   public interface ICourseService
    {
        void AddNewCourse(Course course);
        //void EditCourse(Course course);
        Course getCourseById(int Id);
        void updateCourse(Course course);
        void deleteCourse(int Id);
    }
}
