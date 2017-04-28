using MyLive.IBLL;
using MyLive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLive.DAL;

namespace MyLive.BLL
{
    public class UserConfigService : BaseService<T_UserConfig>, InterfaceUserConfigService
    {
        public UserConfigService() : base(RepositoryFactory.UserConfigRepository) { }
    }
}
