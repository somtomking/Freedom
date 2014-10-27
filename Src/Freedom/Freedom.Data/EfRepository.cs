using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Freedom.Data
{
    public class EfRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly IDbSet<TEntity> _dbSet;
        private readonly UnitOfWork _unitOfWork;
        public EfRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork as UnitOfWork;
            _dbSet = _unitOfWork.Context.Set<TEntity>();
        }
        public IQueryable<TEntity> Table
        {
            get { return _dbSet; }
        }

        public IQueryable<TEntity> TableNoTracking
        {
            get { return _dbSet.AsNoTracking(); }
        }

        public TEntity Find(object id)
        {
            return _dbSet.Find(id);
        }

        public IEnumerable<TEntity> FindAll()
        {
            return _dbSet.ToList();
        }
        
        public TEntity Create()
        {
            return _dbSet.Create();
        }

        public void Add(TEntity entity)
        {
             
            _dbSet.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(object id)
        {
            TEntity entity = _dbSet.Find(id);
            Delete(entity);
        }

        public void Delete(TEntity entity)
        {
            if (_unitOfWork.Context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

    }
}
