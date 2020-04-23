using System;
using System.Collections.Generic;

namespace Assignment6.Library.Framework
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public IList<StudentRegistration> Registration { get; set; }

    }
}
