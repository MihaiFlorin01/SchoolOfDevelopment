﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolOf.Data.Abstraction
{
    public interface IRepository<T> where T : BaseEntityModel
    {
        Task<T> GetByIdAsync(long id);

        T Add(T entity);

        Task<bool> DeleteByIdAsync(long id);

        T Update(T entity);

        IEnumerable<T> Find(Func<T, bool> searchCriteria);

        IEnumerable<T> Find(Func<T, bool> searchCriteria, int skip, int take);
    }
}
