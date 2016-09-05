﻿using System.Collections;
using Domain.Model.Models;
using System.Collections.Generic;

namespace Repository.Abstraction.Interfaces
{
    public interface IRepository<TEntity>
        where TEntity : Entity
    {
        IList<TEntity> Collection { get; }
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void DeleteById(long bookId);
        void Save(TEntity entity);
        TEntity GetById(long id);
    }
}
