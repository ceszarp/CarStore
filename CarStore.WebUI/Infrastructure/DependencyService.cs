using CarStore.Data.Abstract;
using CarStore.Data.Database;
using Ninject;
using Ninject.Extensions.ChildKernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace CarStore.WebUI.Infrastructure
{
    public class DependencyService : System.Web.Http.Dependencies.IDependencyResolver,System.Web.Mvc.IDependencyResolver
    {
        private IKernel kernel;
        private static IKernel staticKernel = new StandardKernel();

        static DependencyService()
        {
            AddBindings(staticKernel);
        }

        public DependencyService(IKernel kernel,bool scope = false)
        {
            this.kernel = kernel;
            if (!scope)
            {
                AddBindings(this.kernel);
            }
        }

        public DependencyService():this(new StandardKernel()) { }


        public IDependencyScope BeginScope()
        {
            return new DependencyService(AddRequestBindings(new ChildKernel(kernel)), true);
        }

        public void Dispose()
        {
            
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        public static T Get<T>()
        {
            return staticKernel.Get<T>();
        }

        private static void AddBindings(IKernel k)
        {
            k.Bind<ICarRepository>().To<CarRepository>();
        }

        private IKernel AddRequestBindings(IKernel kernel)
        {
            return kernel;
        }
    }
}