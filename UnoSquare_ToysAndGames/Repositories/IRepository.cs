﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnoSquare_ToysAndGames.Models;

namespace UnoSquare_ToysAndGames.Repositories
{
    public interface IRepository<T> where T :BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update (T entity);
        void Delete(int id);
    }
}
