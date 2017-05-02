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
    public class RoleService : BaseService<T_Role>, InterfaceRoleService
    {
        public RoleService() : base(RepositoryFactory.RoleRepository)
        {
        }

        public T_Role Find(int RoleID)
        {
            return CurrentRepository.Find(u => u.RoleID == RoleID);
        }

        public T_Role Find(string RoleName)
        {
            return CurrentRepository.Find(u => u.Name == RoleName);
        }
    }
}
