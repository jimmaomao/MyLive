﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLive.IBLL
{
    /// <summary>
    /// 接口基类
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface InterfaceBaseService<T> where T : class, new()
    {
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>添加后的数据实体</returns>
        T Add(T entity);

        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>是否成功</returns>
        bool Update(T entity);

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity">数据实体</param>
        /// <returns>是否成功</returns>
        bool Delete(T entity);
    }
}
