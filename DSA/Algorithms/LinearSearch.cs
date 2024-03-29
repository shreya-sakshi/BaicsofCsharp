﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms
{
    class LinearSearch
    {
        static int[] array = { 59, 23, 61, 90, 33, 2, 30 };

        // T(n) => O(n)
        public static void Do()
        {
            Console.WriteLine("Please enter a number to search in array");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == num)
                {
                    Console.WriteLine("Number found at index " + i);
                    return;
                }
            }
            Console.WriteLine("Number not found in array");
        }
    }
}

