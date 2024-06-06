using CS12.Class;
using CS12.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CS12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceCollection();

            // Dang ky dich vu


            // Singleton
            service.AddScoped<IClassC, ClassC1>();


            // Build provider
            var provider = service.BuildServiceProvider();


            // Lay service ra su dung
            /*var classC = provider.GetService<IClassC>();
            classC?.ActionC();*/

            for (int i = 0; i < 10; i++)
            {
                var classC = provider.GetService<IClassC>();
                Console.WriteLine(classC?.GetHashCode());
            }
        }
    }
}
