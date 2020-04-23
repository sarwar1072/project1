using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6.Library.Framework
{
   public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SeatCount { get; set; }
        public float Fee { get; set; }
        public IList<StudentRegistration> Registration { get; set; }
    }
}
