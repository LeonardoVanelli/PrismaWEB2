using ProjetoModeloDDD.Application;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;
using ProjetoModeloDDD.Domain.Services;
using ProjetoModeloDDD.Infra.Data.Repositories;


[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(ProjetoModeloDDD.MVC.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(ProjetoModeloDDD.MVC.App_Start.NinjectWebCommon), "Stop")]

namespace ProjetoModeloDDD.MVC.App_Start
{
    using System;
    using System.Web;

    using Microsoft.Web.Infrastructure.DynamicModuleHelper;

    using Ninject;
    using Ninject.Web.Common;

    public static class NinjectWebCommon 
    {
        private static readonly Bootstrapper bootstrapper = new Bootstrapper();

        /// <summary>
        /// Starts the application
        /// </summary>
        public static void Start() 
        {
            DynamicModuleUtility.RegisterModule(typeof(OnePerRequestHttpModule));
            DynamicModuleUtility.RegisterModule(typeof(NinjectHttpModule));
            bootstrapper.Initialize(CreateKernel);
        }
        
        /// <summary>
        /// Stops the application.
        /// </summary>
        public static void Stop()
        {
            bootstrapper.ShutDown();
        }
        
        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        private static IKernel CreateKernel()
        {
            var kernell = new StandardKernel();
            try
            {
                kernell.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
                kernell.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

                RegisterServices(kernell);
                return kernell;
            }
            catch
            {
                kernell.Dispose();
                throw;
            }
        }

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            kernel.Bind<IClienteAppService>().To<ClienteAppService>();
            kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();
            kernel.Bind<IPaisAppService>().To<PaisAppService>();
            kernel.Bind<IPessoaAppService>().To<PessoaAppService>();
            kernel.Bind<ICargoAppService>().To<CargoAppService>();
            kernel.Bind<IPresidenteAppService>().To<PresidenteAppService>();
            kernel.Bind<ILeiAppService>().To<LeiAppService>();

            kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            kernel.Bind<IClienteService>().To<ClienteService>();
            kernel.Bind<IProdutoService>().To<ProdutoService>();
            kernel.Bind<IPessoaService>().To<PessoaService>();
            kernel.Bind<IPresidenteService>().To<PresidenteService>();
            kernel.Bind<ICargoService>().To<CargoService>();
            kernel.Bind<ILeiService>().To<LeiService>();

            kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
            kernel.Bind<IPaisRepository>().To<PaisRepository>();
            kernel.Bind<IPessoaRepository>().To<PessoaRepository>();
            kernel.Bind<IPresidenteRepository>().To<PresidenteRepository>();
            kernel.Bind<ICargoRepository>().To<CargoRepository>();
            kernel.Bind<ILeiRepository>().To<LeiRepository>();
        }
    }
}






