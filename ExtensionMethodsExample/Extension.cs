using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsExample
{
    static class Extension
    {
        public static void SendAnotherMessage(this Class1 a)
        {
            Console.WriteLine("SendAnotherMessage from Extension class");
        }
    }
}
