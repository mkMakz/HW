using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class ClassWithMethods
    {
        

        public void CheckElementsOfArray(int [] arr, int Element)
        {
            int element = Element;
            for (int i = 0; i < element; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

        public void FillArray(int Length , int el)
        {
            int length = Length;
            int Element = el;
            int[] arr = new int[length];
            Random rand = new Random();


            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100);
                Console.WriteLine(arr[i]);

            }
            Console.WriteLine("\n");

            CheckElementsOfArray(arr, Element);
        }
    }
}
