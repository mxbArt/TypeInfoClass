using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeInfoClass
{
    class TestClass
    {
        private string _field1;
        public string _field2 = "2";

        public int IntProp { get; set; }

        public string Field1 { get { return _field1; } set { _field1 = value; } }

        public TestClass () {}

        public TestClass (string f2)
        {
            _field2 = f2;
        }

        public void Method1 () { }

        private string Method2 (string ret)
        {
            return ret;
        }
    }
}
