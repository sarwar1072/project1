using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
namespace Assignment6.Library.Framework
{
    public class FrameworkModule:Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;
        public FrameworkModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }
        protected override void Load(ContainerBuilder builder)
        {         
            builder.RegisterType<FrameworkContext>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();
				   
            builder.RegisterType<FrameworkContext>().As<IFrameworkContext>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<SRegistrationUnitOfWork>().As<ISRegistratioinUnitOfWork>()
                   .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                   .InstancePerLifetimeScope();

            builder.RegisterType<StudentRepository>().As<IStudentRepository>()
                .WithParameter("connectionString", _connectionString)
                   .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<CourseRepository>().As<ICourseRepository>()              
                .InstancePerLifetimeScope();

           builder.RegisterType<StudentService>().As<IStudentService>()            
                .InstancePerLifetimeScope();
            builder.RegisterType<CourseService>().As<ICourseService>()
                      .InstancePerLifetimeScope();
            base.Load(builder);
        }
        
    }
}
