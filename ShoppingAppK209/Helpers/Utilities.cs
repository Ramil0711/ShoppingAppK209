using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingAppK209.Helpers
{
    static class Utilities
    {
        public static bool IsEmpty(string [] arr1)
        {
            foreach (var a in arr1)
            {
                if (string.IsNullOrWhiteSpace(a))
                {
                    return false;
                }
            }
            return true; 
        }
    }
}
