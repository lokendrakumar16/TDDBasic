﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDInSingleSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10,20));
            Console.ReadLine();
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
