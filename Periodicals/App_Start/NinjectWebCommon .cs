using Microsoft.Web.Infrastructure.DynamicModuleHelper;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using Ninject.Web.Common.WebHost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

[assembly: WebActivatorEx.PreApplicationStartMethod(typeof(Periodicals.Web.App_Start.NinjectWebCommon), "Start")]
[assembly: WebActivatorEx.ApplicationShutdownMethodAttribute(typeof(Periodicals.Web.App_Start.NinjectWebCommon), "Stop")]

namespace Periodicals.Web.App_Start
{
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

        private static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
            kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

            RegisterServices(kernel);
            return kernel;
        }

        /// <summary>
        /// Creates the kernel that will manage your application.
        /// </summary>
        /// <returns>The created kernel.</returns>
        //private static IKernel CreateKernel()
        //{
        //    // set the connection string
        //    //var modules = new INinjectModule[] { new ServiceModule("DefaultConnection") };
        //    var kernel = new StandardKernel(modules);
        //    try
        //    {
        //        kernel.Bind<Func<IKernel>>().ToMethod(ctx => () => new Bootstrapper().Kernel);
        //        kernel.Bind<IHttpModule>().To<HttpApplicationInitializationHttpModule>();

        //        RegisterServices(kernel);
        //        return kernel;
        //    }
        //    catch
        //    {
        //        kernel.Dispose();
        //        throw;
        //    }
        //}

        /// <summary>
        /// Load your modules or register your services here!
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        private static void RegisterServices(IKernel kernel)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(
                new Periodicals.Web.Infrastructure.NinjectDependencyResolver(kernel));
        }
    }
}