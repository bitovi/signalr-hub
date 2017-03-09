using DoneChatServeR.Infrastructure;
using DoneChatServeR.Services;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Ninject;
using Owin;

namespace DoneChatServeR
{
    public partial class Startup
    {
        /// <summary>
        /// Configures the application.
        /// </summary>
        /// <param name="app">The application builder.</param>
        public void Configuration(IAppBuilder app)
        {
            var kernel = SetupNinject();

            SetupSignalR(kernel, app);
        }


        /// <summary>
        /// Sets Up the ninject IOC.
        /// </summary>
        /// <returns>StandardKernel</returns>
        private static KernelBase SetupNinject()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IDoneChatServeRRepository>()
                .To<InMemoryRepository>()
                .InSingletonScope();

            return kernel;
        }

        /// <summary>
        /// Setups the SignalR.
        /// </summary>
        /// <param name="kernel">The kernel.</param>
        /// <param name="app">The application.</param>
        public void SetupSignalR(IKernel kernel, IAppBuilder app)
        {
            var resolver = new NinjectSignalRDependencyResolver(kernel);

            var config = new HubConfiguration
            {
                Resolver = resolver,
                EnableDetailedErrors = true
            };

            app.Map("/signalr", map =>
            {
                map.UseCors(CorsOptions.AllowAll);

                map.RunSignalR(config);
            });
        }
    }
}