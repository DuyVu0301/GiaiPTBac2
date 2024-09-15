//Lê Duy Vũ


using System;
using System.Text;

namespace GiaiPTBac2
{
    class GiaiPTBac2
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap vao A: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao B: ");
            float b = float.Parse(Console.ReadLine());

            Console.WriteLine("Nhap vao C: ");
            float c = float.Parse(Console.ReadLine());

            float Delta = (b / 2) * (b / 2) - a * c;

            Console.WriteLine("Phuong trinh nhap vao la:\n {0}x*x + {1}x + {2} = 0", a, b, c);

            Console.WriteLine("Delta phay = {0}", Delta);

            if (Delta < 0)
            {
                Console.WriteLine("Phuong trinh co nghiem");
            }
            else if (Delta == 0)
            {
                float x = (-b / 2) / a;
                Console.WriteLine("Phuong trinh co hai nghiem kep x1 = x2 = {0}", x);
            }
            else
            {
                double x1 = 0;
                double x2 = 0;

                x1 = ((-b / 2) - Math.Sqrt(Delta)) / a;
                x2 = ((-b / 2) + Math.Sqrt(Delta)) / a;

                Console.WriteLine("Phuong trinh co hai nghiem phan biet: ");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
            Console.ReadKey();
        }
    }
}
