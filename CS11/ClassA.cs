namespace CS11
{
    internal class ClassA
    {
        private IClassB _classB;

        public ClassA(IClassB classB)
        {
            _classB = classB;
        }

        public void ActionA()
        {
            Console.WriteLine("[ClassA] - Action A");
            _classB.ActionB();
        }
    }
}
