using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Data
{
    internal class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly EfObjectContext _context;

        public UnitOfWork()
        {
            _context = new EfObjectContext("FreedomConnectionString");
        }

        public EfObjectContext Context
        {
            get { return _context; }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing)
            {
                _context.Dispose();
            }
        }
    }
}
