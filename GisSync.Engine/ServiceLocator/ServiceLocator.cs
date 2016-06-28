using System;
using System.Collections.Generic;
using NLog;

using GisSync.Engine.Services;

namespace GisSync.Engine
{
    public class ServiceLocator : IServiceLocator
    {
        private static IServiceLocator _instance;
        private static readonly object Lock = new Object();
        private readonly Dictionary<object, object> _services;

        private ServiceLocator()
        {
            _services = new Dictionary<object, object>();
            RegisterServices();
        }

        private void RegisterServices() {
            _services.Add(typeof(ILogger), new Lazy<ILogger>(() => LogManager.GetLogger("ExceptionLogger")));
            _services.Add(typeof(ISyncSqlService), new Lazy<ISyncSqlService>(() => new SyncSqlService("", "")));
        }

        public static IServiceLocator Instance
        {
            get
            {
                lock (Lock)
                {
                    return _instance ?? (_instance = new ServiceLocator());
                }
            }
        }

        public T GetService<T>()
        {
            try
            {
                return ((Lazy<T>)_services[typeof(T)]).Value;
            }
            catch (KeyNotFoundException)
            {
                throw new ApplicationException("The requested service is not registered");
            }
        }
    }
}
