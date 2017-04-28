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
    public class UserService : BaseService<T_User>, InterfaceUserService
    {
        public UserService() : base(RepositoryFactory.UserRepository) { }

        public bool Exsit(string userName)
        {
            return CurrentRepository.Exist(u => u.UserName == userName);
        }

        public T_User Find(string userName)
        {
            return CurrentRepository.Find(u => u.UserName == userName);
        }

        public T_User Find(int userID)
        {
            return CurrentRepository.Find(u => u.UserID == userID);
        }

        public IQueryable<T_User> FindPageList(int pageIndex, int pageSize, out int totalRecord, int order)
        {
            bool _isAsc = true;
            string _orderName = string.Empty;
            switch (order)
            {
                case 0:
                    _isAsc = true;
                    _orderName = "UserID";
                    break;
                case 1:
                    _isAsc = false;
                    _orderName = "UserID";
                    break;
                case 2:
                    _isAsc = true;
                    _orderName = "RegistrationTime";
                    break;
                case 3:
                    _isAsc = false;
                    _orderName = "RegistrationTime";
                    break;
                case 4:
                    _isAsc = true;
                    _orderName = "LoginTime";
                    break;
                case 5:
                    _isAsc = false;
                    _orderName = "LoginTime";
                    break;
                default:
                    _isAsc = false;
                    _orderName = "UserID";
                    break;
            }
            return CurrentRepository.FindPageList(pageIndex, pageSize, out totalRecord, u => true, _orderName, _isAsc);
        }
    }
}
