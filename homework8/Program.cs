using System;

namespace homework8
{
    class Program
    {
        static void Main(string[] args)
        {
            Point tochka = new Point();
            Point tochka2 = new Point(2, 5);
            string t = tochka.Tochki();
            string t1 = tochka2.Tochki();
            double d1 = tochka2.Rasstoyanie();
            tochka2.UmnojenieNaSkalar = 5;
            Console.WriteLine(t);
            Console.WriteLine(t1);
            Console.WriteLine("Rasstoyanie: " + d1);
            Console.WriteLine("Umnojili na skalar i poluchili: " + tochka2.Tochki());
        }
    }


    class Point
    {
        private int x;
        private int y;
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }

        public int UmnojenieNaSkalar
        {
            set
            {
                X = X * value;
                Y = Y * value;
            }
        }

        public Point()
        {
            X = 0;
            Y = 0;
        }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string Tochki()
        {
            return "Koordinati: x: " + X + " y: " + Y;
        }

        public double Rasstoyanie()
        {
            return Math.Sqrt(X * X + Y * Y);
        }
    }
}
