﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sqrt_abs_x__pow_y_2__
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("√|x| + y^2\n");
            Console.WriteLine("Adad x ra vared konid : ");
            int X = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Adad y ra vared konid : ");
            int Y = Convert.ToInt32(Console.ReadLine());
            calc(X, Y);
        }
        private static void calc(int x, int y)
        {
            double Result = Math.Sqrt(Math.Abs(x) + Math.Pow(y, 2));
            Console.WriteLine("\n" + Result);
        }
    }
}
