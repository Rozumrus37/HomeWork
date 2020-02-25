using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClassLibrary2 
{
    public class Class1
    {
        static int[] a = new int[5];

        static void Main()
        {
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            a[4] = 5;
            foreach (int i in a.Filter(x => (x >= 3)))
            {
                Console.WriteLine(i);
            }
        }
    }

    public static class extense
    {
            public static IEnumerable<T> Filter<T>(this T [] arr, Predicate<T>fun)
            {
                foreach (T i in arr)
                {
                    if (fun(i))
                        yield return i;
                }
            }
    }
}
    
    
    
    
