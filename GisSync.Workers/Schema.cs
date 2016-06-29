using GisSync.Engine.Definitions;
using GisSync.Engine.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisSync.ETEA.Schema
{
    public static class Schema
    {
        public static SyncSqlSchema Get()
        {
            return new SyncSqlSchema
            {
                Definitions = new Queue<BaseSqlEntityDefinition>(new BaseSqlEntityDefinition[]
                {
                    Definitions.Parcel,
                    Definitions.SetBack
                })
            };
        }

    }
}
