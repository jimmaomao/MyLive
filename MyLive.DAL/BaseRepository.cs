﻿using MyLive.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace MyLive.DAL
{
    public class BaseRepository<T> : InterfaceBaseRepository<T> where T : class, new()
    {
        protected MyliveDbContext nContext = ContextFactory.GetCurrentContext();

        public T Add(T entity)
        {
            nContext.Entry<T>(entity).State = EntityState.Added;
            nContext.SaveChanges();
            return entity;
        }

        public int Count(Expression<Func<T, bool>> Predicate)
        {
            return nContext.Set<T>().Count(Predicate);
        }

        public bool Delete(T entity)
        {
            nContext.Set<T>().Attach(entity);
            nContext.Entry<T>(entity).State = EntityState.Deleted;
            return nContext.SaveChanges() > 0;
        }

        public bool Exist(Expression<Func<T, bool>> anyLambda)
        {
            return nContext.Set<T>().Any(anyLambda);
        }

        public T Find(Expression<Func<T, bool>> whereLambda)
        {
            T _entity = nContext.Set<T>().FirstOrDefault<T>(whereLambda);
            return _entity;
        }

        public IQueryable<T> FindList(Expression<Func<T, bool>> whereLambda, string orderName, bool isAsc)
        {
            var _list = nContext.Set<T>().Where<T>(whereLambda);
            _list = OrderBy(_list, orderName, isAsc);
            return _list;
        }

        public IQueryable<T> FindPageList(int pageIndex, int pageSize, out int totalRecord, Expression<Func<T, bool>> wherLambda, string orderName, bool isAsc)
        {
            var _list = nContext.Set<T>().Where<T>(wherLambda);
            totalRecord = _list.Count();
            _list = OrderBy(_list, orderName, isAsc).Skip<T>((pageIndex - 1) * pageSize).Take<T>(pageSize);
            return _list;
        }

        public bool Update(T entity)
        {
            nContext.Set<T>().Attach(entity);
            nContext.Entry<T>(entity).State = EntityState.Modified;
            return nContext.SaveChanges() > 0;
        }

        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="source">原IQueryable</param>
        /// <param name="propertyName">排序属性名</param>
        /// <param name="isAsc">是否正序</param>
        /// <returns>排序后的IQueryable</returns>
        private IQueryable<T> OrderBy(IQueryable<T> source, string propertyName, bool isAsc)
        {
            if (source == null) throw new ArgumentException("source", "不能为空");
            if (string.IsNullOrEmpty(propertyName)) return source;
            var _parameter = Expression.Parameter(source.ElementType);
            var _property = Expression.Property(_parameter, propertyName);
            if (_property == null) throw new ArgumentNullException("propertyName", "属性不存在");
            var _lambda = Expression.Lambda(_property, _parameter);
            var _methodName = isAsc ? "OrderBy" : "OrderByDescending";
            var _resultExpression = Expression.Call(typeof(Queryable), _methodName, new Type[] { source.ElementType, _property.Type }, source.Expression, Expression.Quote(_lambda));
            return source.Provider.CreateQuery<T>(_resultExpression);

        }
    }
}