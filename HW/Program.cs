using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            #region FirstExercise
            /*
             * 1.	Перехватить исключение запроса к несуществующему веб ресурсу и вывести сообщение о том, что произошла ошибка. 
             * Программа должна завершиться без ошибок.
            string SourceName = "itstep.org";
            string UserName = "";
            try
            {

                UserName = Console.ReadLine();
                if(SourceName != UserName)
                {
                    throw new Exception("404 server not found!");
                }
                else 
                    Console.WriteLine("Correct\n");

                


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();*/
            #endregion

            #region SecondExercise
            /*
             * 2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. 
             * После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.
            int[] arr = new int[5];
            Random rand = new Random();

            for (int i = 0; i < 5; i++)
            {
            arr[i] = rand.Next(1, 10);
                Console.WriteLine(arr[i]);

            }
            Console.WriteLine("\n");
            try
            {
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();*/
            #endregion

            #region ThirdExercise
            /*
             * 3.	Реализовать несколько методов или классов с методами и вызвать один метод из другого. 
             * В вызываемом методе сгенерировать исключение и «поднять» его в вызывающий метод.
             */
            ClassWithMethods cl = new ClassWithMethods();

            try
            {
                cl.FillArray(20, 25);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
            #endregion
        }
    }
}
