using System;
using System.Collections.Generic;

using GisSync.Engine.Workers;

namespace GisSync.Engine.SyncDefinitions
{
	public abstract class BaseDefinition<TWorker>
	{
		public Queue<TWorker> Workers;
	}
}

