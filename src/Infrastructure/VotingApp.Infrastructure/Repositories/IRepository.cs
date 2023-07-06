﻿using System.Linq.Expressions;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public interface IRepository<T> where T : class, IEntity, new()
    {
        T? Get(int id);
        Task<T?> GetAsync(int id);
        IList<T?> GetAll();
        Task<IList<T?>> GetAllAsync();

        IList<T> GetAllWithPredicate(Expression<Func<T, bool>> predicate);

        Task CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAync(int id);
    }
}