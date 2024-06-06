using CS13.Interface;

namespace CS13.Class
{
    internal class ClassB2 : IClassB
    {
        private IClassC _classC;

        public ClassB2(IClassC classC)
        {
            _classC = classC;

            Console.WriteLine("[ClassB2] - Constructor");
        }

        public void ActionB()
        {
            Console.WriteLine("[ClassB2] - Action B");

            _classC.ActionC();
        }
    }
}
