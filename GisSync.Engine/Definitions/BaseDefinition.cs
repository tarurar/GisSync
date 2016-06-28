using System;
using System.Collections.Generic;

using GisSync.Engine.Workers;

namespace GisSync.Engine.Definitions
{
	public abstract class BaseDefinition<TWorker>
	{
		public Queue<TWorker> Workers;
	}
}

