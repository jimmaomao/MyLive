using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyLive.DAL
{
    /// <summary>
    /// 上下文简单工厂
    /// </summary>
    public class ContextFactory
    {
        public static MyliveDbContext GetCurrentContext()
        {
            MyliveDbContext _nContext = CallContext.GetData("MyliveContext") as MyliveDbContext;
            if (_nContext == null)
            {
                _nContext = new MyliveDbContext();
                CallContext.SetData("MyliveContext", _nContext);
            }
            return _nContext;
        }
    }
}
