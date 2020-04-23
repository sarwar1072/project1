using System;
using System.Collections.Generic;
using System.Text;
namespace Assignment6.Library.Framework
{
    public class CourseService : ICourseService
    {
        private ISRegistratioinUnitOfWork _sRegistratioinUnitOfWork;
        public CourseService(ISRegistratioinUnitOfWork sRegistratioinUnitOfWork)
        {
            _sRegistratioinUnitOfWork = sRegistratioinUnitOfWork;
        }
        public void AddNewCourse(Course course)
        {
            _sRegistratioinUnitOfWork.CourseRepository.Add(course);
            _sRegistratioinUnitOfWork.Save();
        }
        public void deleteCourse(int Id)
        {
            _sRegistratioinUnitOfWork.CourseRepository.Remove(Id);
            _sRegistratioinUnitOfWork.Save();
        }

        public Course getCourseById(int Id)
        {
            return _sRegistratioinUnitOfWork.CourseRepository.GetById(Id);
        }

        public void updateCourse(Course course)
        {
            _sRegistratioinUnitOfWork.CourseRepository.Edit(course);
            _sRegistratioinUnitOfWork.Save();
        }

    }
}
