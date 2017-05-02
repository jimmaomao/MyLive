using MyLive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLive.IBLL
{
    public interface InterfaceRoleService : InterfaceBaseService<T_Role>
    {
        /// <summary>
        /// 查找角色实体
        /// </summary>
        /// <param name="RoleName">用户组名称</param>
        /// <returns></returns>
        T_Role Find(string RoleName);

        /// <summary>
        /// 查找角色实体
        /// </summary>
        /// <param name="userGroupID">用户组ID</param>
        /// <returns></returns>
        T_Role Find(int RoleID);
    }
}
