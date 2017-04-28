using MyLive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLive.IBLL
{
    public interface InterfaceUserGroupService : InterfaceBaseService<T_UserGroup>
    {
        /// <summary>
        /// 查找用户组实体
        /// </summary>
        /// <param name="userGroupName">用户组名称</param>
        /// <returns></returns>
        T_UserGroup Find(string userGroupName);

        /// <summary>
        /// 查找用户组实体
        /// </summary>
        /// <param name="userGroupID">用户组ID</param>
        /// <returns></returns>
        T_UserGroup Find(int userGroupID);
    }
}
