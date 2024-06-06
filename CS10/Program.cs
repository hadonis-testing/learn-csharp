namespace CS10
{
    [Mota("Chương trình chính")]
    internal class Program
    {
        [Mota("Hàm main")]
        static void Main(string[] args)
        {
            string a = "Hello World";

            var t = a.GetType();

            Console.WriteLine(t.FullName);
            t.GetMethods().ToList().ForEach(p => Console.WriteLine(p.Name));
        }
    }
}
