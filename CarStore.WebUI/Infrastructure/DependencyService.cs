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
        public DependencyService(IKernel kernel,bool scope = false)
        {
            this.kernel = kernel;
            if (!scope)
            {
                AddBindings();
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

        private void AddBindings()
        {
            //Bindings go here
        }

        private IKernel AddRequestBindings(IKernel kernel)
        {
            return kernel;
        }
    }
}