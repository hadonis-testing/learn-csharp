﻿using CS13.Interface;

namespace CS13.Class
{
    internal class ClassA
    {
        private IClassB _classB;

        public ClassA(IClassB classB)
        {
            _classB = classB;

            Console.WriteLine("[ClassA] - Constructor");
        }

        public void ActionA()
        {
            Console.WriteLine("[ClassA] - Action A");

            _classB.ActionB();
        }
    }
}
