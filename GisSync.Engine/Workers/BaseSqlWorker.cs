using System;
using System.Data.SqlClient;
using GisSync.Engine;
using NLog;

namespace GisSync.Engine.Workers
{
	public class BaseSqlWorker: ISqlWorker
	{
		protected static readonly ILogger Logger = ServiceLocator.Instance.GetService<ILogger>();

		public virtual void Execute(SqlConnection source, SqlConnection dest, Action<int, string> statusCallback)
		{
			throw new NotImplementedException();
		}
	}
}

