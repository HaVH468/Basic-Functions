﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Programming_Language_Lab_1
{
    class ArrayUnit
    {
        public static int[] Zip(int[] arr1, int[] arr2)
        {
            var result = new List<int>();
            

            var len = arr1.Length > arr2.Length
                ? arr2.Length
                : arr1.Length;

            for (var i = 0; i < len; i++)
                result.Add(arr1[i] + arr2[i]);


            return result.ToArray();

        }

        public static int[] Accumulate(int[] inputArray)
        {
            var result = new int[inputArray.Length];

            for (var i = 0; i < inputArray.Length; i++)
            {
                result[i] = i == 0
                    ? inputArray[i]
                    : result[i - 1] + inputArray[i];
            }

            return result;
        }

        public static void Reverse1(int[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }
        }

        public static int[] Round(decimal[] inputArray)
        {
            var result = new int[inputArray.Length];

            for (var i = 0; i < inputArray.Length; i++)
                result[i] = (int)inputArray[i];

            return result;
        }

        public static int[] Round(int[] inputArray, int threshold)
        {
            var result = new List<int>();

            foreach (var element in inputArray)
                if (element >= threshold)
                    result.Add(element);

            return result.ToArray();
        }

        public static int[] Diagonal(int[,] inputArray)
        {
            var result = new int[inputArray.GetLength(0)];

            for (var i = 0; i < result.Length; i++)
                result[i] = inputArray[i, i];

            return result;
        }

        public static int[,] Triangularize(int[,] inputArray)
        {
            int len = inputArray.GetLength(0);
            var result = new int[len,len]; 

            for (var i = 0; i < len; i++)
            {
                for (var j = 0; j < len; j++)
                {
                    if (j < i) result[i, j] = 0;
                    else result[i, j] = inputArray[i, j];
                }
            }

            return result;
        }

        public static int[] Flatten(int[,] inputArray)
        {
            var result = new List<int>();

            for (var i = 0; i < inputArray.GetLength(0); i++)
            {
                for (var j = 0; j < inputArray.GetLength(1); j++) result.Add(inputArray[i, j]);
            }

            return result.ToArray();

        }

    }
}
