using MyLive.IBLL;
using MyLive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLive.IDAL;
using MyLive.DAL;

namespace MyLive.BLL
{
    public class UserGroupService : BaseService<T_UserGroup>, InterfaceUserGroupService
    {
        public UserGroupService() : base(RepositoryFactory.UserGroupRepository)
        {
        }

        public T_UserGroup Find(int userGroupID)
        {
            return CurrentRepository.Find(u => u.GroupID == userGroupID);
        }

        public T_UserGroup Find(string userGroupName)
        {
            return CurrentRepository.Find(u => u.Name == userGroupName);
        }
    }
}
