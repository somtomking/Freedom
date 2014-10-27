using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom
{
    public partial interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
