using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUpper.Model
{
    public class Earth : Transport
    {
        public override void StartEngine()
        {
            Console.WriteLine("Benzin, Dizel, Elektrik, Propan");
        }
    }
}
