using System;
using System.Data.SqlClient;

using GisSync.Engine.Workers;

namespace GisSync.ETEA.Schema.Workers.Parcels
{
	public class DeleteWorker: BaseSqlWorker
	{
		public override void Execute(SqlConnection source, SqlConnection dest, Action<int, string> statusCallback)
		{
			// delete smth from dest
			statusCallback(33, "Deleting parcels");

			// delete smth from dest
			statusCallback(66, "Deleting parcels");

			// delete smth from dest
			statusCallback(100, "Deleting parcels");
		}
	}
}

