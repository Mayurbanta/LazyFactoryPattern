using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyFactoryPattern.Services
{
   public interface IDbContext: IDisposable
    {
        string SaveChanges();
    }
}
