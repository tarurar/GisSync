using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisSync.Engine
{
    public interface IServiceLocator
    {
        T GetService<T>();
    }
}
