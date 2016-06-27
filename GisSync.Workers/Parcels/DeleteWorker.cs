using System;
using System.Data.SqlClient;

using GisSync.Engine.Workers;

namespace GisSync.Workers.Parcels
{
	public class DeleteWorker: BaseSqlWorker
	{
		public override void Execute(SqlConnection source, SqlConnection dest, Action<int> statusCallback)
		{
			// delete smth from dest
			statusCallback(33);

			// delete smth from dest
			statusCallback(66);

			// delete smth from dest
			statusCallback(100);
		}
	}
}

