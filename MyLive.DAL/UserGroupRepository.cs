using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLive.Models;
using MyLive.IDAL;
namespace MyLive.DAL
{
    class UserGroupRepository : BaseRepository<T_UserGroup>, InterfaceUserGroupRepository
    {
    }
}
