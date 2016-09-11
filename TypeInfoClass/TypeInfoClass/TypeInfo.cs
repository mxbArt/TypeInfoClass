using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TypeInfoClass
{
    static class TypeInfo
    {
        public static void GetPupblicInfo(object obj)
        {
            MemberInfo[] members = obj.GetType().GetMembers();
            
            Console.WriteLine("Public members:");
            foreach (MemberInfo m in members)
            {
                Console.WriteLine(m);
            }
            
        }

        public static void GetConstructors(object obj)
        {
            ConstructorInfo[] constr = obj.GetType().GetConstructors();

            Console.WriteLine("Constructors:");
            foreach (ConstructorInfo c in constr)
            {
                Console.WriteLine(c);
            }
        }

        public static void GetPublicFields(object obj)
        {
            FieldInfo[] fields = obj.GetType().GetFields();

            Console.WriteLine("Public Fields:");
            foreach (FieldInfo f in fields)
            {
                Console.WriteLine(f + ", value: " + f.GetValue(obj));
            }
        }

        public static void GetMethods(object obj)
        {
            MethodInfo[] methods = obj.GetType().GetMethods();

            Console.WriteLine("Available methods:");
            foreach (MethodInfo m in methods)
            {
                Console.WriteLine(m);
            }
        }
    }
}
