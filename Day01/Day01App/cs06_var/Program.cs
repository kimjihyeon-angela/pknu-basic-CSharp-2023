﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs06_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 4000000;
            Console.WriteLine("type = {0}, value = {1}", a.GetType(), a);

            var b = 3.141592f; // f여부에 따라 double/ float 변경
            Console.WriteLine("type = {0}, value = {1}", b.GetType(), b);

            var c = "basic C#";
            Console.WriteLine("type = {0}, value = {1}", c.GetType(), c);

        }
    }
}
