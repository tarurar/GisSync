using System;
using System.Collections.Generic;

using GisSync.Engine.Workers;

namespace GisSync.Engine
{
	public abstract class BaseDefinition<TWorker>
	{
		public SortedList<int, TWorker> Workers;
	}
}

