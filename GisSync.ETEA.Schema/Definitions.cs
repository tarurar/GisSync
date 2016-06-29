using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GisSync.Engine.Definitions;

namespace GisSync.ETEA.Schema
{
    public static class Definitions
    {
        public static BaseSqlEntityDefinition Parcel = new BaseSqlEntityDefinition
        {
            Workers = new Queue<Engine.Workers.ISqlWorker>(new Engine.Workers.ISqlWorker[]
            {
                new Workers.Parcels.CreateWorker(),
                new Workers.Parcels.UpdateWorker(),
                new Workers.Parcels.DeleteWorker()
            })
        };

        public static BaseSqlEntityDefinition SetBack = new BaseSqlEntityDefinition
        {
            Workers = new Queue<Engine.Workers.ISqlWorker>(new Engine.Workers.ISqlWorker[]
            {
                new Workers.SetBacks.CreateWorker(),
                new Workers.SetBacks.UpdateWorker()
            })
        };
    }
}
