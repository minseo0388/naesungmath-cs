﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naesungmathcs
{
    public class calc
    {
        /// <summary>
        /// 0001 Plus
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a+b</returns>
        public double plus(double a, double b)
        {
            return a + b;
        }
        /// <summary>
        /// 0002 Minus
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a-b</returns>
        public double minus(double a, double b)
        {
            return a - b;
        }
        /// <summary>
        /// 0003 Multiply
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a*b</returns>
        public double multiply(double a, double b)
        {
            return a * b;
        }
        /// <summary>
        /// 0004 Divide
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a/b</returns>
        public double divide(double a, double b)
        {
            return a / b;
        }
        /// <summary>
        /// 0005 Caret
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a to the b power</returns>
        public double caret(double a, double b)
        {
            return (double)Math.Pow(a, b);
        }
        /// <summary>
        /// 0006 Power
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>a to the b power</returns>
        public double pow(double a, double b)
        {
            return (double)Math.Pow(a, b);
        }
        /// <summary>
        /// 0007 Square root
        /// </summary>
        /// <param name="a"></param>
        /// <returns>square root of a</returns>
        public double sqrt(double a)
        {
            return (double)Math.Sqrt(a);
        }

        public double random()
        {
            Random r = new Random();
            return r.Next();
        }
        /// <summary>
        /// 0008 Prime
        /// Determine if this number is prime. 
        /// If the number is prime, return true.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>this number is prime number returns true</returns>
        public bool prime(double a)
        {
            if (a <= 1)
                return false;
            for (double i = 2; i < Math.Sqrt(a); a++)
            {
                if ((a %= i) == 0)
                    return false;
            }
            return true;
        }
        /// <summary>
        /// 0009 DegtoRad
        /// Convert degree to radian.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>radian</returns>
        public double radian(double a)
        {
            return 2 * Math.PI * a;
        }
    }
}
