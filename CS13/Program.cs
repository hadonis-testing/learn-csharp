using CS13.Class;
using CS13.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace CS13
{
    internal class Program
    {
        public static IClassB CreateB3(IServiceProvider provider)
        {
            return new ClassB3(provider.GetService<IClassC>()!, "Hello from ClassB3");
        }

        static void Main(string[] args)
        {
            var service = new ServiceCollection();

            // Dang ky dich vu


            // Singleton
            service.AddSingleton<ClassA, ClassA>();
            service.AddSingleton<IClassB>(CreateB3);
            service.AddSingleton<IClassC, ClassC1>();


            // Build provider
            var provider = service.BuildServiceProvider();


            // Lay service ra su dung

            ClassA? a = provider.GetService<ClassA>();
            a?.ActionA();
        }
    }
}
