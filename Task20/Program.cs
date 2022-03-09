using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task20
{
    class Program
    {
        delegate double MyDelegate(double r);
       
        static void Main(string[] args)
        {
            Console.WriteLine("Задайте радиус");
            double Radius = Convert.ToDouble(Console.ReadLine());
            MyDelegate myDelegate = LengthCircle;
            if (myDelegate != null)
            { 
                double d = myDelegate(Radius);
                Console.WriteLine("Длина окружности={0}", d);
            }
            MyDelegate myDelegate2 = AreaCircle;
            if (myDelegate != null)
            {
                double s = myDelegate2(Radius);
                Console.WriteLine("Площадь круга={0} ", s);
            }
            MyDelegate myDelegate3 = VolumeCircle;
            if (myDelegate != null)
            {
                double v = myDelegate3(Radius);
                Console.WriteLine("Объем шара={0} ", v);
            }

            Console.ReadKey();
        }

        static double LengthCircle(double R)
        { 
            double D=2 * Math.PI * R;
            return D;
        }
        static double AreaCircle(double R)
        {
            double S = Math.PI * Math.Pow(R,2);
            return S;
        }
        static double VolumeCircle(double R)
        {
            double V = 4/3*Math.PI * Math.Pow(R, 3);
            return V;

        }
    }
}
