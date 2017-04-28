using MyLive.IBLL;
using MyLive.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLive.BLL
{
    /// <summary>
    /// 服务基类（抽象）
    /// </summary>
    public abstract class BaseService<T> : InterfaceBaseService<T> where T : class, new()
    {
        protected InterfaceBaseRepository<T> CurrentRepository { get; set; }

        public BaseService(InterfaceBaseRepository<T> currentRepository)
        {
            CurrentRepository = currentRepository;
        }

        public T Add(T entity)
        {
            return CurrentRepository.Add(entity);
        }

        public bool Delete(T entity)
        {
            return CurrentRepository.Delete(entity);
        }

        public bool Update(T entity)
        {
            return CurrentRepository.Update(entity);
        }
    }
}
