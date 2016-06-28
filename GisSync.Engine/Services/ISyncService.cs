using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisSync.Engine.Services
{
    public interface ISyncService<T>
    {
        void RunSync(T syncPlan);
    }
}
