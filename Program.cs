using System;
using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть свій вік!:");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("Введіть свій ріст:");
        int height = int.Parse(Console.ReadLine());

        if (age > 18 && height >160)
        {
            Console.WriteLine("Вхід дозволений");
            }
       else
        {
            Console.WriteLine("вхід заборонений");
            }
         }
    }
