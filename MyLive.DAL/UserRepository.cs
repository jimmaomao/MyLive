using MyLive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLive.IDAL;
namespace MyLive.DAL
{
    class UserRepository : BaseRepository<T_User>, InterfaceUserRepository
    {
    }
}
