using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsHW
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        public void myMethod1(float[] param1f, float[] param2f)
        {
            float oj = 63f;
            foreach (float i in param1f)
                if (oj == 4)
                {
                    Console.WriteLine(oj);
                    Console.WriteLine("i love cheese burgers");
                }
                else
                {
                    Console.WriteLine("with cheese");
                }
            float jo = 12f;
            foreach (float i in param2f)
                if (jo == 5)
                {
                    Console.WriteLine(jo);
                    Console.WriteLine("lettuce");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("tomatoes");
                }
            int forr = 3;
            if (forr == 4)
            {
                var avg = Queryable.Average(param1f.AsQueryable());
                Console.WriteLine("Average = " + avg);
                Console.ReadKey();
            }
            int orr = 23;
            if (orr == 13)
            {
                double avg = Queryable.Average(param2f.AsQueryable());
                Console.WriteLine("Average = " + avg); Console.ReadKey();
            }
            Console.ReadKey();
        }
        public void myMethod2(int[] param3, int[] param4)
        {
            int iii = 43;
            foreach (int i in param3)
                if (iii == 5)
                {
                    Console.WriteLine(iii);
                    Console.WriteLine("mayo");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("ketchup");
                    Console.ReadKey();
                }
            int iiii = 12;
            foreach (int i in param4)
                if (iiii == 5)
                {
                    Console.WriteLine(iiii);
                    Console.WriteLine("pickles");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("yummy");
                    Console.ReadKey();
                }
            Console.ReadKey();
        }
    }