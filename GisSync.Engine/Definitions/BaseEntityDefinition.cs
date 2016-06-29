using System;
using System.Collections.Generic;

using GisSync.Engine.Workers;

namespace GisSync.Engine.Definitions
{
	public abstract class BaseEntityDefinition<TWorker>
	{
		public Queue<TWorker> Workers;
	}
}

