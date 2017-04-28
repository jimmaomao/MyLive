using MyLive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLive.IBLL
{
    public interface InterfaceUserService : InterfaceBaseService<T_User>
    {
        /// <summary>
        /// 用户是否存在
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>布尔值</returns>
        bool Exsit(string userName);

        /// <summary>
        /// 查找用户
        /// </summary>
        /// <param name="userID">用户ID</param>
        /// <returns></returns>
        T_User Find(int userID);

        /// <summary>
        /// 查找用户
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        T_User Find(string userName);

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <param name="pageIndex">页码数</param>
        /// <param name="pageSize">每页记录数</param>
        /// <param name="totalRecord">总记录数</param>
        /// <param name="order">排序：0-ID升序（默认），1-ID降序，2-注册时间升序，3-注册时间降序
        /// 4-登陆时间升序，5-登陆时间降序</param>
        /// <returns></returns>
        IQueryable<T_User> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order);
    }
}
