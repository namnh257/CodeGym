using System;

namespace HienThiLoiChao
{
    class Program
    {
        static void Main(string[] args)
        {
            float rate;
            Console.WriteLine("Vui long nhap ti gia: ");
            rate = float.Parse(Console.ReadLine());
            int usd;
            Console.WriteLine("Vui long nhap so luong ban muon quy doi: ");
            usd = int.Parse(Console.ReadLine());
            float quyDoi;
            quyDoi = rate*usd;
            Console.WriteLine("So tien cua ban quy doi ra VND bang: " + quyDoi);

        }
    }
}