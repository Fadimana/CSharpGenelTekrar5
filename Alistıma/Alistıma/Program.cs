
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alistıma
{   //DİNMAİK POLİMORFİZM Örneği
    public class CalcArea
    {
        public virtual double Area() //sanallaştıdık
        {
            double area = 0;
            return area;
        }
    }

    public class Circle : CalcArea
    {
        public double Radius;
        public Circle(double r)
        {
            Radius = r;
        }
        public override double Area() //üzerine yazdık.
        {
            return (3.14) * Math.Pow(Radius, 2);
        }
    }
    public class Kare : CalcArea
    {
        public double length;
        public Kare(double len)
        {
            length = len;
        }
        public override double Area()
        {
            return Math.Pow(length, 2);
        }
    }

    public class Dikdortgen : CalcArea
    {
        public double height, width;
        public Dikdortgen(double h, double w)
        {
            height = h;
            width = w;
        }
        public override double Area()
        {
            return height * width;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CalcArea C = new Circle(5);
            Console.WriteLine("Area of Circle: " + C.Area());

            CalcArea S = new Kare(3.2);
            Console.WriteLine("Area of Square:" + S.Area());

            CalcArea R = new Dikdortgen(2.5, 5.2);
            Console.WriteLine("Area of Rectangle :" + R.Area());
            Console.ReadKey();
        }
    }
}
