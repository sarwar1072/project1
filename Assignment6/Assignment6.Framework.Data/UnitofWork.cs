﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace Assignment6.Framework.Data
{
   public class UnitofWork<T>:IUnitofWork<T> where T:DbContext
    {
        protected readonly T _dbContext;
        public UnitofWork(string connectionString, string migrationAssemblyName)
            => _dbContext = (T)Activator.CreateInstance(typeof(T), connectionString, migrationAssemblyName);

        public void Dispose() => _dbContext?.Dispose();

        public void Save() => _dbContext?.SaveChanges();
    }
}
