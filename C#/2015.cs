using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 2015
{
    class Program
    {
        delegate TResult SelfApplicable<T1, TResult>(SelfApplicable<T1, TResult> self, T1 arg1);
        static Func<T1, TResult> Make<T1, TResult>(SelfApplicable<T1, TResult> self){ return (x) => self(self, x);}
        static void Main(string[] args)
        {
            System.Console.WriteLine((Make<long, String>((__, ___) => (___ > 0) ? ((char)(___ % 256) + __(__, ___ >> (0x10 >> 1))) : ""))((((3 << 5) + 1) << ((7 << 3))) + (((((1 << 4) - 1) << 2) - 1) << ((3 << 4) + 1)) + (((3 << 4) + 1) << ((5 << 3) + 1)) - (((((3 << 2) - 1) << 2) + 1) << ((1 << 5) + (1 << 1))) - (((1 << 4) - 1) << ((7 << 2) + 1)) + (((7 << 2) + 1) << ((9 << 1))) + (7 << ((3 << 2))) - ((((3 << 2) - 1)) << 4) - (1 << 1)));
        }
    }
}
