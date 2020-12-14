using System;

namespace job_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            Console.WriteLine("Введите 4 значное число");
            a = double.Parse(Console.ReadLine());
            if (a % 3 == 0) System.Console.WriteLine("{0} - кратно 3.", a);
            //Если четырехзначное чило не кратно 3 ,то число не выйдет в окне!.
            double r1 = (a / 3);
            if (a % r1 == 0) System.Console.WriteLine("{0} - кратно произведению его цифр.", a);
            //Если данное число не кратно произведению его цифр то число не выйдет в окне!.
        }
    }
}
