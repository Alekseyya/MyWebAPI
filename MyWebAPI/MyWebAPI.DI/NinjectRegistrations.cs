using MyWebAPI.BL.Services;
using MyWebAPI.BL.Services.Intefaces;
using Ninject;
using Ninject.Modules;
using WebAPI.DAL.Repositories;
using WebAPI.DAL.Repositories.Base;

namespace MyWebAPI.DI
{
    //public class NinjectRegistrations: NinjectModule
    //{
    //    public override void Load()
    //    {
    //        Bind<IClientService>().To<ClientService>();
    //        Bind<IUnitOfWork>().To<UnitOfWork>();
    //    }
    //}
    public class NinjectRegistrations
    {
        public static void RegisterServices(IKernel kernel)
        {
            kernel.Bind<IClientService>().To<ClientService>();
            kernel.Bind<IUnitOfWork>().To<UnitOfWork>();
        }
    }
}
