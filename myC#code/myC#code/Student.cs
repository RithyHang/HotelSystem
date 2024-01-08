using System;
using System.Collections;
using ConsoleTables;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myC_code
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Barcode { get; set; }
        public float UnitPrice { get; set; }
        public float SellPrice { get; set; }
        public int QtyInstock { get; set; }

        public int n;
        public ArrayList arrayListStudent = new ArrayList();

        public void Add()
        {
            
            Console.Write("Enter N : ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Student student = new Student();

                Console.Write("Enter ID              : ");
                student.Id = int.Parse(Console.ReadLine());
                Console.Write("Enter Name            : ");
                student.Name = Console.ReadLine();
                Console.Write("Enter Barcode         : ");
                student.Barcode = int.Parse(Console.ReadLine());
                Console.Write("Enter Unit Price  : ");
                student.UnitPrice = float.Parse(Console.ReadLine());
                Console.Write("Enter Sell Price  : ");
                student.SellPrice = float.Parse(Console.ReadLine());
                Console.Write("Enter QTY Instock : ");
                student.QtyInstock = int.Parse(Console.ReadLine());

                arrayListStudent.Add(student);
                Console.Clear();

            }
        }

        public void Show()
        {
            var Table = new ConsoleTable();
            string[] columnHeader = { "ID", "Name", "Barcode", "Unit Price", "Sell Price", "Qty Instock" };
            for (int i = 0;i < arrayListStudent.Count; i++)
            {
                Student student = new Student();
                student = (Student)arrayListStudent[i];

                Table.AddRow(student.Id, student.Name, student.Barcode, student.UnitPrice, student.SellPrice, student.QtyInstock);
            }
        }
    }
}
