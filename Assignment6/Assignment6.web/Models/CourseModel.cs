﻿using Assignment6.Library.Framework;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment6.web.Models
{
    public class CourseModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int SeatCount { get; set; }
        public float Fee { get; set; }
        public void AddCourse()
        {
            var cr = new Course
            {
                Title = this.Title,
                SeatCount = this.SeatCount,
                Fee = this.Fee
            };
            var cService=Startup.AutofacContainer.Resolve<ICourseService>();
            cService.AddNewCourse(cr);
        }
        public void editCourse()
        {
            var editService = Startup.AutofacContainer.Resolve<ICourseService>();
            var course = editService.getCourseById(this.Id);

            course.Title = this.Title;
            course.SeatCount = this.SeatCount;
            course.Fee = this.Fee;

            editService.updateCourse(course);
        }

        internal void deleteCourse()
        {
            var deleteService = Startup.AutofacContainer.Resolve<ICourseService>();
            deleteService.deleteCourse(this.Id);
        }
    }
}
