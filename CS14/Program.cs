using CS14.Class;
using CS14.Interface;
using CS14.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CS14
{
    internal class Program
    {
        public static IClassB CreateB3(IServiceProvider provider)
        {
            return new ClassB3(provider.GetService<IClassC>()!, "Hello from ClassB3");
        }

        static void Main(string[] args)
        {
            ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.SetBasePath(Directory.GetCurrentDirectory());
            configurationBuilder.AddJsonFile("cauhinh.json");

            IConfigurationRoot configurationRoot = configurationBuilder.Build();

            var sectionMyServiceOptions = configurationRoot.GetSection("MyServiceOptions");

            var service = new ServiceCollection();

            // Dang ky dich vu
            service.AddSingleton<MyService>();

            service.Configure<MyServiceOptions>(sectionMyServiceOptions);

            // Build provider
            var provider = service.BuildServiceProvider();

            // Lay service ra su dung
            var myService = provider.GetService<MyService>();
            myService.PrintData();
        }
    }
}
