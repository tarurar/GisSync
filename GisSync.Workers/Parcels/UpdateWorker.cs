using System;
using System.Data.SqlClient;

using GisSync.Engine.Workers;

namespace GisSync.Workers.Parcels
{
	public class UpdateWorker: BaseSqlWorker
	{
		public override void Execute(SqlConnection source, SqlConnection dest, Action<int, string> statusCallback)
		{
			// update smth in dest
			statusCallback(33, "Updating parcels");

			// update smth in dest
			statusCallback(66, "Updating parcels");

			// update smth in dest
			statusCallback(100, "Updating parcels");
		}
	}
}

