using System;

class Program {
    static void Main(string[] args)
    {

        Console.Write("Nhap mot so nguyen khong am tu 0 den 999: ");

        int number = int.Parse(Console.ReadLine());

        string[] ones = {"mot", "hai", "ba", "bon", "nam", "sau", "bay", "tam", "chin"};
        string[] tens = {"muoi ", "hai muoi ", "ba muoi ", "bon muoi ", "nam muoi ", "sau muoi ", "bay muoi ", "tam muoi ", "chin muoi "};
        string[] hundreds = {"mot tram ", "hai tram ", "ba tram ", "bon tram ", "nam tram ", "sau tram ", "bay tram ", "tam tram ", "chin tram "};


        if (number < 10)
        {
            switch (number)
            {
                case 1:
                    Console.WriteLine(ones[0]);
                    break;
                case 2:
                    Console.WriteLine(ones[1]);
                    break;
                case 3:
                    Console.WriteLine(ones[2]);
                    break;
                case 4:
                    Console.WriteLine(ones[3]);
                    break;
                case 5:
                    Console.WriteLine(ones[4]);
                    break;
                case 6:
                    Console.WriteLine(ones[5]);
                    break;
                case 7:
                    Console.WriteLine(ones[6]);
                    break;
                case 8:
                    Console.WriteLine(ones[7]);
                    break;
                case 9:
                    Console.WriteLine(ones[8]);
                    break;
            }
        }

        if (10 < number && number < 20)
        {
            switch (number)
            {
                case 11:
                    Console.WriteLine(tens[0] + ones[0]);
                    break;
                case 12:
                    Console.WriteLine(tens[0] + ones[1]);
                    break;
                case 13:
                    Console.WriteLine(tens[0] + ones[2]);
                    break;
                case 14:
                    Console.WriteLine(tens[0] + ones[3]);
                    break;
                case 15:
                    Console.WriteLine(tens[0] + ones[4]);
                    break;
                case 16:
                    Console.WriteLine(tens[0] + ones[5]);
                    break;
                case 17:
                    Console.WriteLine(tens[0] + ones[6]);
                    break;
                case 18:
                    Console.WriteLine(tens[0] + ones[7]);
                    break;
                case 19:
                    Console.WriteLine(tens[0] + ones[8]);
                    break;
            }
        }
    }
}