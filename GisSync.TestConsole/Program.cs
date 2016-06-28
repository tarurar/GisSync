using System;
using System.Collections.Generic;

using GisSync.Engine.Workers;
using GisSync.Engine.Definitions;
using GisSync.Engine.Model;
using GisSync.Engine;
using GisSync.Engine.Services;

namespace GisSync.TestConsole
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var syncService = ServiceLocator.Instance.GetService<ISyncSqlService>();
			var syncPlan = new SyncSqlModel
			{
				Nodes = new Queue<BaseSqlDefinition>(new BaseSqlDefinition[]
				{
					new BaseSqlDefinition
					{
						Workers = new Queue<ISqlWorker>(new ISqlWorker[]
						{
							new Workers.Parcels.CreateWorker(),
				           	new Workers.Parcels.UpdateWorker(),
				           	new Workers.Parcels.DeleteWorker(),
						})
					}
				})
			};

			syncService.RunSync(syncPlan, (percentage, comment) =>
			{
				Console.WriteLine("{0}: {1}%", comment, percentage);
			});
        }
	}
}
