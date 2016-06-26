using System;

namespace GisSync.Engine.Workers
{
	public interface IWorker<TSource, TDest>
	{
		void Execute(TSource source, TDest dest, Action<int> statusCallback);
	}
}

