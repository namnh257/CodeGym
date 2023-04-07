using System;

namespace TinhChiSoCanNang
{
    class Program
    {
        static void Main (string[] args)
        {   
            double height;
            Console.Write ("Nhap chieu cao (cm): ");
            height = double.Parse(Console.ReadLine())/100;

            double weight;
            Console.Write ("Nhap can nang (kg): ");
            weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height*height);
            
            Console.WriteLine ("BMI: " + bmi);
            if (bmi < 18.5)
                {
                    Console.WriteLine("Underweight");
                }
            else if (bmi < 25)
                {
                    Console.WriteLine("Normal");
                }
            else if (bmi < 30)
                {
                    Console.WriteLine("Overweight");
                }
            else
                {
                    Console.WriteLine("Obese");
                }
        }
    }
}