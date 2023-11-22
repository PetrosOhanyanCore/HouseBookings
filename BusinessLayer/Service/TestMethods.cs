using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Service
{
    public class TestMethods
    {
        public int TestMuliply(int a, int b)
        {
            var result = a * b;
            return result;
        }

        public float TestDivide(int a, int b)
        {
            var result = a / b;
            return result;
        }
    }
}
