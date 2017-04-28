using MyLive.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLive.DAL
{
    /// <summary>
    /// 简单工厂
    /// </summary>
    public static class RepositoryFactory
    {

        /// <summary>
        /// 用户
        /// </summary>
        public static InterfaceUserRepository UserRepository
        {
            get
            {
                return new UserRepository();
            }
        }

        /// <summary>
        /// 用户组
        /// </summary>
        public static InterfaceUserGroupRepository UserGroupRepository
        {
            get
            {
                return new UserGroupRepository();
            }
        }

        /// <summary>
        /// 用户配置
        /// </summary>
        public static InterfaceUserConfigRepository UserConfigRepository
        {
            get
            {
                return new UserConfigRepository();
            }
        }
    }
}
