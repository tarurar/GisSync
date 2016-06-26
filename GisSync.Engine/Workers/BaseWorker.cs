using System;
using System.Data.SqlClient;

namespace GisSync.Engine.Workers
{
	public class BaseWorker: ISqlWorker
	{
		public virtual void Execute(SqlConnection source, SqlConnection dest, Action<int> statusCallback)
		{
			throw new NotImplementedException();
		}
	}
}

