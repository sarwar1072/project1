using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6.Framework.Data
{
    public interface IUnitofWork<T>:IDisposable where T:DbContext
    {
        //IUnitOfWork<T> : IDisposable where T : DbContext
        void Save();
    }
}
