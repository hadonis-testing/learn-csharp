using Newtonsoft.Json;

namespace CS09
{
    internal class Program
    {
        public static void Example1()
        {
            Product product = new Product();
            product.Name = "Apple";
            product.Expiry = new DateTime(2008, 12, 28);
            product.Sizes = new string[] { "Small" };

            string json = JsonConvert.SerializeObject(product);
            // {
            //   "Name": "Apple",
            //   "Expiry": "2008-12-28T00:00:00",
            //   "Sizes": [
            //     "Small"
            //   ]
            // }

            Console.WriteLine(json);
        }

        public static void Example2()
        {
            string json = @"{'Name': 'Bad Boys', 'ReleaseDate': '1995-4-7T00:00:00', 'Genres': ['Action', 'Comedy']}";

            Movie? m = JsonConvert.DeserializeObject<Movie>(json);

            string? name = m?.Name;

            Console.WriteLine(name);
        }

        static void Main(string[] args)
        {
            Example1();
            Example2();
        }
    }
}
