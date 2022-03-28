using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Upcasting_Downcasting
{
    interface ISupermarketable
    {
        public int Total { get; set; }

        void Sell();
        void Report();
        double Salary();
        void methodWithBody()
        {
            Console.WriteLine("Method with body");
        }
    }
}
