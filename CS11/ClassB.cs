namespace CS11
{
    internal class ClassB : IClassB
    {
        private IClassC _classC;

        public ClassB(IClassC classC)
        {
            this._classC = classC;
        }

        public void ActionB()
        {
            Console.WriteLine("[ClassB] - Action B");

            _classC.AcctionC();
        }
    }
}
