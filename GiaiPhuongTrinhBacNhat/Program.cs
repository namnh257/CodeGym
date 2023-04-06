using System;

namespace GiaiPhuongTrinhBacNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Giai phuong trinh bac nhat");
            Console.WriteLine("Vui long nhap cac he so");
            Console.Write("a:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b:");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a != 0)
                {
                    double solution = -b / a;
                    Console.Write("The solution is: {0}!", solution);
                }
            else
                {
                    if (b==0)
                        {
                            Console.Write("Phuong trinh co vo so nghiem");
                        }
                    else
                        {
                             Console.Write("Phuong trinh vo nghiem");
                        }
                }
        }
    }
}