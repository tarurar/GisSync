using System;
using System.Data.SqlClient;

using GisSync.Engine.Workers;

namespace GisSync.Workers.Parcels
{
	public class UpdateWorker: BaseSqlWorker
	{
		public override void Execute(SqlConnection source, SqlConnection dest, Action<int> statusCallback)
		{
			// update smth in dest
			statusCallback(33);

			// update smth in dest
			statusCallback(66);

			// update smth in dest
			statusCallback(100);
		}
	}
}

