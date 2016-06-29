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
            if (source == null) throw new ArgumentNullException(nameof(source));
            if (dest == null) throw new ArgumentNullException(nameof(dest));
            if (statusCallback == null) throw new ArgumentNullException(nameof(statusCallback));
        }
	}
}

