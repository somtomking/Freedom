using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Infrastructure.Paging
{
    public class PagedResult<TEntity>
    {
        public PagedResult(int count, IEnumerable<TEntity> data)
        {
            this.Count = count;
            this.Data = data;
        }
        public int Count { get; private set; }
        public IEnumerable<TEntity> Data { get; private set; }

    }
}
