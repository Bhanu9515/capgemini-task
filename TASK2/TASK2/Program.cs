﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace TASK2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 100, 15, 20, 40, 64, 30, 50, 70, 85, 90 };
            int[] array2 = new int[] { 3, 97, 40, 43, 37, 30, 85, 69, 20, 87 };

            Console.WriteLine("--union--");
            var query1 = (from i in array1 select i).Union(from j in array2 select j);

            foreach (int i in query1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----intersect-------");

            var query2 = (from i in array1 select i).Intersect(from j in array2 select j);

            foreach (int i in query2)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("------except-----------");

            var query3 = (from i in array1 select i).Except(from j in array2 select j);

            foreach (int i in query3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----concat--------");

            var query4 = (from i in array1 select i).Concat(from j in array2 select j);

            foreach (int i in query4)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("-----------------------");

            Console.WriteLine("Aggregate Functions:-");

            Console.WriteLine("-----------------------");

            Console.WriteLine("Sum:-");

            int sum1 = (from i in array1 select i).Sum();
            int sum2 = (from i in array2 select i).Sum();

            Console.WriteLine("Total Sum of two arrays:-" + (sum1 + sum2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Max:-");

            int max1 = (from i in array1 select i).Max();
            int max2 = (from i in array2 select i).Max();

            Console.WriteLine("Maximum number in both arrays:-" + (max1, max2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Min:-");

            int min1 = (from i in array1 select i).Min();
            int min2 = (from i in array2 select i).Min();

            Console.WriteLine("Minimum number in both arrays:-" + (min1, min2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Average:-");

            double avg1 = (from i in array1 select i).Average();
            double avg2 = (from i in array2 select i).Average();

            Console.WriteLine("Average of arrays:-" + (avg1, avg2));

            Console.WriteLine("-----------------------");
            Console.WriteLine("Count:-");

            int count1 = (from i in array1 select i).Count();
            int count2 = (from i in array2 select i).Count();

            Console.WriteLine("Total number of elements in two arrays:-" + (count1, count2));

        }
    }
}
