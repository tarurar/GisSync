using System;
using System.Data.SqlClient;
using GisSync.Engine.Model;
using NLog;

namespace GisSync.Engine.Services
{
    public class SyncSqlService : ISyncSqlService
    {
        protected readonly string _sourceConnString;
        protected readonly string _destConnString;
        protected readonly ILogger Logger = ServiceLocator.Instance.GetService<ILogger>();
        
        public SyncSqlService(string sourceConnString, string destConnString)
        {
            if (String.IsNullOrEmpty(sourceConnString)) throw new ArgumentNullException("sourceConnString");
            if (String.IsNullOrEmpty(destConnString)) throw new ArgumentNullException("destConnString");
            _sourceConnString = sourceConnString;
            _destConnString = destConnString;
        }

        public void RunSync(SyncSqlModel syncPlan)
        {
            if (syncPlan == null) throw new ArgumentNullException("syncPlan");

            using (var sourceConnection = new SqlConnection(_sourceConnString))
            using (var destConnection = new SqlConnection(_destConnString))
            {
                // to do
            }
        }
    }
}
