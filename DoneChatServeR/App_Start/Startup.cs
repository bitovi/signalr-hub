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
        public void Configuration(IAppBuilder app)
        {
            var kernel = SetupNinject();

            SetupSignalR(kernel, app);
        }


        private static KernelBase SetupNinject()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IDoneChatServeRRepository>()
                .To<InMemoryRepository>()
                .InSingletonScope();


            return kernel;
        }

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