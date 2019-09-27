using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using SystemClients.ApplicationCore.Interfaces.Repository;

namespace SystemClients.Infrastructure.Repository
{
    public class DapperRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public TEntity Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
