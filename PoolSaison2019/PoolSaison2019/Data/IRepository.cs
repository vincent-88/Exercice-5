﻿using PoolSaison2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolSaison2019.Data
{
    public interface IRepository<T> where T : Entity
    {
        Task<IQueryable<T>> GetAll();
        Task<T> GetById(int? id);
        Task Delete(T entity);
        Task Add(T entity);
        Task Update(T entity);
    }
}
