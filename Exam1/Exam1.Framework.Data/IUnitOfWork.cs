using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam1.Framework.Data
{
   public interface IUnitOfWork<T> : IDisposable where T : DbContext
    {
        void Save();
    }
}
