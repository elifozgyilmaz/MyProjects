﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SaglikUrunleri.BLL.Repository
{
    public interface IRepository<T> where T:class            /* bu T sınıflarımızdan gelen veriyi temsil eder, generic liste, classtan geliyorsa kabul et demek where t:class */
    {
        IList<T> GetAll(); /* o class la ilgili bütün veriyi getirir getall */

        IList<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, params Expression<Func<T, object>>[] includes);

        T Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderby = null, params Expression<Func<T, object>>[] includes);

        T GetById(int Id);

        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        bool Delet(int Id);

    }
}
