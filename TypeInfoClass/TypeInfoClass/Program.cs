using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInfoClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TestClass test = new TestClass();

            TypeInfo.GetPupblicInfo(test);
            Console.WriteLine();
            TypeInfo.GetConstructors(test);
            Console.WriteLine();
            TypeInfo.GetPublicFields(test);
            Console.WriteLine();
            TypeInfo.GetMethods(test);
        }
    }
}
