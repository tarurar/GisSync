using System;
using System.Collections.Generic;

using GisSync.Model;
using GisSync.Engine.Workers;
using GisSync.Engine.SyncDefinitions;
using GisSync.Workers;

namespace GisSync.TestConsole
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var model = new SyncSqlModel
			{
				Nodes = new Queue<BaseSqlDefinition>(new BaseSqlDefinition[] 
				{
					new BaseSqlDefinition 
					{
						Workers = new Queue<ISqlWorker>(new ISqlWorker[] 
						{
							new Workers.Parcels.CreateWorker(),
				           	new Workers.Parcels.UpdateWorker(),
				           	new Workers.Parcels.DeleteWorker()           
						})
					}
				})
			};

			var n1 = model.Nodes.Dequeue();
			var w1 = n1.Workers.Dequeue();
			w1.Execute(null, null, (percent) => 
			{ 
				Console.WriteLine("Percentage: {0}", percent);
			});
		}
	}
}
