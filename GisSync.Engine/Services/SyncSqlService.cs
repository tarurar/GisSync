﻿using System;
using System.Data.SqlClient;
using GisSync.Engine.Schema;
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

        public void RunSync(SyncSqlSchema syncSchema, Action<int, string> statusCallback)
        {
			if (syncSchema == null) throw new ArgumentNullException(nameof(syncSchema));
			if (statusCallback == null) throw new ArgumentException(nameof(statusCallback));

            using (var sourceConnection = CreateConnection(_sourceConnString))
            using (var destConnection = CreateConnection(_destConnString))
            {
                foreach (var def in syncSchema.Definitions)
				{
					foreach (var worker in def.Workers)
					{
                        try
                        {
                            worker.Execute(sourceConnection, destConnection, statusCallback);
                        }
                        catch (Exception ex)
                        {
                            Logger.Error(ex, string.Format(Resources.StringResources.WorkerExecutionFailedFmt, worker.GetType().FullName));
                            throw new ApplicationException(Resources.StringResources.WorkerExecutionFailed);
                        }
                    }
				}
			}
        }

        private SqlConnection CreateConnection(string connectionString)
        {
            try
            {
                return new SqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, string.Format(Resources.StringResources.ConnectionFailedFmt, connectionString));
                throw new ApplicationException(Resources.StringResources.ConnectionFailed);
            }
        }
    }
}
