using CS13.Interface;

namespace CS13.Class
{
    internal class ClassB3 : IClassB
    {
        private IClassC _classC;
        private string _msg;

        public ClassB3(IClassC classC, string msg)
        {
            _classC = classC;
            _msg = msg;

            Console.WriteLine("[ClassB3] - Consturctor");
        }

        public void ActionB()
        {
            Console.WriteLine("[ClassB2] - Action B");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(_msg);
            Console.ResetColor();

            _classC.ActionC();
        }
    }
}
