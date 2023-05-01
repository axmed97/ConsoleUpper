using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppUpper
{
    // Generics TYpe
    public static class SomeMethods
    {
        public static int Length<T>(this T[] array)
        {
            int counter = 0;
            foreach (var item in array)
            {
                return counter++;
            }

            return counter;
        }
        public static int Length(string sentence)
        {
            int counter = 0;
            foreach (var item in sentence)
            {
                counter++;
            }

            return counter;
        }
        

    }
}
