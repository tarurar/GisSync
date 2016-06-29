using GisSync.Engine.Workers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace GisSync.ETEA.Schema.Workers
{
    public class ETEABaseWorker: BaseSqlWorker
    {
        public override void Execute(SqlConnection source, SqlConnection dest, Action<int, string> statusCallback)
        {
            base.Execute(source, dest, statusCallback);
        }
    }
}
