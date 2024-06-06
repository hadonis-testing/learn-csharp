using Microsoft.Extensions.Options;

namespace CS14.Services
{
    internal class MyService
    {
        public string data1 { get; set; }

        public int data2 { get; set; }

        public MyService(IOptions<MyServiceOptions> options)
        {
            var _options = options.Value;

            data1 = _options.data1;
            data2 = _options.data2;
        }

        public void PrintData()
        {
            Console.WriteLine($"Data1: {data1}");
            Console.WriteLine($"Data2: {data2}");
        }
    }
}
