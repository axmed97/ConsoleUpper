using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUpper.Model
{
    public class Water : Transport
    {
        public override void StartEngine()
        {
            Console.WriteLine("Komur");
        }
    }
}
