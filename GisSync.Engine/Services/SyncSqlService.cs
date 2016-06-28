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
        protected readonly static ILogger Logger = ServiceLocator.Instance.GetService<ILogger>();
        
        public SyncSqlService(string sourceConnString, string destConnString)
        {
			if (string.IsNullOrEmpty(sourceConnString)) throw new ArgumentNullException(nameof(sourceConnString));
			if (string.IsNullOrEmpty(destConnString)) throw new ArgumentNullException(nameof(destConnString));
            _sourceConnString = sourceConnString;
            _destConnString = destConnString;
        }

        public void RunSync(SyncSqlModel syncPlan, Action<int, string> statusCallback)
        {
			if (syncPlan == null) throw new ArgumentNullException(nameof(syncPlan));
			if (statusCallback == null) throw new ArgumentException(nameof(statusCallback));

			using (var sourceConnection = new SqlConnection(_sourceConnString))
			using (var destConnection = new SqlConnection(_destConnString))
			{
				foreach (var node in syncPlan.Nodes)
				{
					foreach (var worker in node.Workers)
					{
						worker.Execute(sourceConnection, destConnection, statusCallback);
					}
				}
			}
        }
    }
}
