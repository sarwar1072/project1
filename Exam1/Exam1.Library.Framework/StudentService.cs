﻿using System;
using System.Collections.Generic;
using System.Text;
namespace Exam1.Library.Framework
{
    public class StudentService : IStudentService
    {
        private ISRegistratioinUnitOfWork _sRegistratioinUnitOfWork;
        public StudentService(ISRegistratioinUnitOfWork sRegistratioinUnitOfWork)
        {
            _sRegistratioinUnitOfWork = sRegistratioinUnitOfWork;
        }
        public void AddNewStudent(Student student)
        {
            _sRegistratioinUnitOfWork.StudentRepository.Add(student);
            _sRegistratioinUnitOfWork.Save();
        }

        public Student getStudentById(int Id)
        {
            return _sRegistratioinUnitOfWork.StudentRepository.GetById(Id);
        }

    }
}
