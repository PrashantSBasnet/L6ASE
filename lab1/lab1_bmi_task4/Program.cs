using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Windows.Forms;

namespace lab1_bmi_task4
{
    class Program
    {
        string result;
        static void Main(string[] args)
        {
            MessageBox.Show("Please enter values as per instruction", "User Guide to Enter Values", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //Console.WriteLine("Enter values!");
            Program app = new Program();
            app.values();
           
            Console.WriteLine("\n Do you want to re continue?(Y/N)");
            string ans = Console.ReadLine();
            if (ans.ToUpper().Equals("Y")) {
                app.values();
            }
            else
            { 
                System.Environment.Exit(0);

            } 
            
           
        }

        void values()
        {
            try
            {
                Console.WriteLine("Enter your weight in kgs");
                string s = Console.ReadLine();

                Console.WriteLine("Enter your height in meters");
                string h = Console.ReadLine();
                float ht = Single.Parse(h);

                Console.WriteLine("Enter your gender (M/F)");
                string g = Console.ReadLine().ToUpper();

                float wt = Single.Parse(s);


                float f = (wt / (ht * ht));






                if (g.Equals("M"))
                {
                    if (f < 20.7) result = "underweight";
                    else if (f > 20.7 & f < 26.4) result = "in normal range";
                    else if (f > 26.4 & f < 27.8) result = "marginally overweight";
                    else if (f > 27.8 & f < 31.1) result = "overweight";
                    else if (f > 31.1) result = "very overweight or obese";
                }

                if (g.Equals("F"))
                {
                    if (f < 17.5) result = "änorexia";
                    else if (f < 19.1) result = "underweight";
                    else if (f > 19.1 & f < 25.8) result = "in normal range";
                    else if (f > 25.8 & f < 27.3) result = "marginally overweight";
                    else if (f > 27.3 & f < 32.3) result = "overweight";
                    else if (f > 32.3) result = "very overweight or obese";
                    else if (f > 35 & f < 40) result = "severly obese";
                    else if (f > 40 & f < 50) result = "morbidly obese";
                    else result = "super obese";

                }

                MessageBox.Show("Gender "+ g +" person having weight and height "+ wt +" kg " + ht+ " m " + " and BMI " + f+ "ïs\n"+ result, "BMI OUTPUT", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //Console.Write(" Gender "+ g +" person having weight and height "+ wt +" kg " + ht+ " m " + " and BMI " + f+ " ïs "+ result);


            }

            catch (IOException ex)

            {
                MessageBox.Show("Please re check the value entered","Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

}

        
} 
    }

