using System;

using GisSync.Engine;
using GisSync.Engine.Services;
using ETEASyncShema = GisSync.ETEA.Schema.Schema;

namespace GisSync.TestConsole
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			var syncService = ServiceLocator.Instance.GetService<ISyncSqlService>();
            syncService.RunSync(ETEASyncShema.Get(), (percentage, comment) =>
			{
				Console.WriteLine("{0}: {1}%", comment, percentage);
			});
        }
	}
}
