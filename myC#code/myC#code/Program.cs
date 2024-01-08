using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace myC_code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Show Product");

            start:
            Console.Write("Choose an option : ");
            option = int.Parse(Console.ReadLine());

            Student student = new Student();

            switch (option) {
                case 1:
                    student.Add();
                    break;
                case 2:
                    student.Show();
                    break;
                default:
                    Console.WriteLine("Wrong Input Bitch!");
                    break;
            }
            goto start;







            Console.ReadKey();
        }
    }
}
