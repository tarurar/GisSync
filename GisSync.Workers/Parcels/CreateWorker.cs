using System;
using System.Data.SqlClient;

using GisSync.Engine.Workers;

namespace GisSync.Workers.Parcels
{
	public class CreateWorker: BaseSqlWorker
	{
		public override void Execute(SqlConnection source, SqlConnection dest, Action<int> statusCallback)
		{
			// insert smth to dest
			statusCallback(33);

			// insert smth to dest
			statusCallback(66);

			//insert smth to dest
			statusCallback(100);
		}
	}
}

