using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatGenerics
{
    internal class Car
    {
        public DateTime Date { get; set; }
        public void Wash(DateTime Date)
        {
            Console.WriteLine($"Washing start at: {Date}");
        }
        public void Finish(DateTime Date)
        {
            Console.WriteLine($"It will be finished at: {Date.Hour}:{Date.Minute+15}");
        }
    }
    public delegate void CarDelegate(DateTime Date);
}
