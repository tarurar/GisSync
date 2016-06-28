using System;
using System.Data.SqlClient;

namespace GisSync.Engine.Workers
{
	public class BaseSqlWorker: ISqlWorker
	{
		public virtual void Execute(SqlConnection source, SqlConnection dest, Action<int, string> statusCallback)
		{
			throw new NotImplementedException();
		}
	}
}

