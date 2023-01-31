using System;

namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 45;
            age = 55;
            age = 100;
            age = 10;
            age = 10;


            string name = "Hikmet";
            name = name + '-';
            name = "Abbas";

          


            Console.WriteLine(name);
            Console.WriteLine(age);

            int number = 45;

            SetZero(number);

            Console.WriteLine(number);

            int[] nums = { 43, 45, 2, 10 };

            SetZero(nums);

            Console.WriteLine(nums[0]);

            string text = "Salam";

            SetZero(text);

            Console.WriteLine(text);
        }

        static void SetZero(int number)
        {
            number = 0;
        }

        static void SetZero(int[] arr)
        {
            arr[0] = 0;
        }

        static void SetZero(string str)
        {
            str = "0";
        }
    }
}
