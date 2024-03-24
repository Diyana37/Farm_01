using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalTest
{
    public static class CustomAssert
    {
        public static void AreEqual<T>(T expected, T actual)
        {
            if (!expected.Equals(actual))
            {
                throw new Exception($"Expected: {expected}, Actual: {actual}");
            }
        }
    }
}
