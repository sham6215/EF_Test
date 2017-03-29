using Queries.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Challenger.DB.Repository
{
    abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext Context;
        protected readonly DbSet<TEntity> _Entities;

        public Repository(DbContext context)
        {
            Context = context;
            _Entities = Context.Set<TEntity>();
        }

        public TEntity Get(int id)
        {
            // Here we are working with a DbContext, not PlutoContext. So we don't have DbSets 
            // such as Courses or Authors, and we need to use the generic Set() method to access them.
            return Context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _Entities.ToList();
        }

        abstract public IEnumerable<TEntity> GetAllFull();

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _Entities.Where(predicate);
        }

        public TEntity SingleOrDefault(Expression<Func<TEntity, bool>> predicate)
        {
            return _Entities.SingleOrDefault(predicate);
        }

        public void Add(TEntity entity)
        {
            _Entities.Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _Entities.AddRange(entities);
        }

        public void Remove(TEntity entity)
        {
            _Entities.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _Entities.RemoveRange(entities);
        }
    }
}
