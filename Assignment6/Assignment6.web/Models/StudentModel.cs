using Assignment6.Library.Framework;
using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
namespace Assignment6.web.Models
{
    public class StudentModel
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public DateTime date{ get; set; }
        public void AddStudent()
        {
            var st = new Student
            {
               // Id=this.Id,
                Name=this.Name,
                date=this.date
            };           
           var service = Startup.AutofacContainer.Resolve<IStudentService>();
            service.AddNewStudent(st);
            
        }
        public void editStudent()
        {
            var editService = Startup.AutofacContainer.Resolve<IStudentService>();
            var student = editService.getStudentById(this.Id);
            student.Name = this.Name;
            student.date = this.date;
            editService.updateStuent(student);
        }
        internal void deleteStudent()
        {
            var editService = Startup.AutofacContainer.Resolve<IStudentService>();
            editService.deleteStudent(this.Id);
        }

    }
}
