using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Upcasting_Downcasting
{
    class Bravo : ISupermarketable,ITestable
    {
        private int _total;
        public int Total
        {
            get => _total;
            set
            {
                _total = value;
            }
        }

        public int AboutTest { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Report()
        {
            Console.WriteLine("This is report of Bravo");
        }

        public double Salary()
        {
            return 30000.90;
        }

        public void Sell()
        {
            Console.WriteLine($"Common sell value is: {Total}");
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
