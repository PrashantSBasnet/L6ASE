using System;
using System.Windows.Forms;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab1!");
            Program lab1 = new Program();
            lab1.task3(); //to get out of static method
        }

        void task3()
        {
            MessageBox.Show("Message", "Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
