using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using WebAPI.DAL.Repositories;
using WebAPI.DAL.Repositories.Base;

namespace MyWebAPI.DI
{
    public static class DependencyContainer
    {
        //private static IKernel _kernel;

        //static DependencyContainer()
        //{
        //    _kernel = new StandardKernel();
        //    _kernel.Bind<IUnitOfWork>().To<UnitOfWork>().InTransientScope();
        //    //_kernel.bind.to.....

        //}
        //public static T Get<T>()
        //{
        //    return _kernel.Get<T>();
        //}
    }
}
