using System;
using System.Data.SqlClient;

namespace GisSync.Engine.Workers
{
	public interface ISqlWorker: IWorker<SqlConnection, SqlConnection>
	{
	}
}

