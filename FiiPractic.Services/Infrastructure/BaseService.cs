﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using FiiPractic.Data.Infrastructure;

namespace FiiPractic.Services.Infrastructure
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IRepository<T> repo;
        private readonly IUnitOfWork unitOfWork;

        public BaseService(IRepository<T> repo, IUnitOfWork unitOfWork)
        {
            this.repo = repo;
            this.unitOfWork = unitOfWork;
        }

        public void Add(T entity)
        {
            //add the entity to the context
            repo.Add(entity);

            //submit to database
            unitOfWork.Commit();
        }

        public int Count()
        {
            return repo.Count();
        }

        public List<T> Get(Expression<Func<T, bool>> where, string includeProperty = "")
        {
            return repo.Get(where, includeProperty);
        }

        public void Update(T entity)
        {
            repo.Update(entity);
            unitOfWork.Commit();
        }

        public void Delete(T entity)
        {
            repo.Delete(entity);
            unitOfWork.Commit();
        }
    }
}
