using System;

namespace homework8_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Dlina: ");
                string a = Console.ReadLine();
                int a1 = int.Parse(a);
                Console.WriteLine("Shirina: ");
                string b = Console.ReadLine();
                int b1 = int.Parse(b);
                Rectangle pramouqolnik = new Rectangle(a1, b1);
                if (pramouqolnik.Kvadrat == true)
                {
                    Console.WriteLine("Eto kvadrat!");
                }
                else
                {
                    Console.WriteLine("Eto ne kvadrat!");
                }
                pramouqolnik.StoroniPramouqolnika();
                pramouqolnik.PerimetrPramouqolnika();
                pramouqolnik.PloshadPramouqolnika();
            }
            catch
            {
                Console.WriteLine("Oshibka! Nujno chislo!");
            }
        }

    }


    class Rectangle
    {
        private int a;
        private int b;

        public int A
        {
            get
            {
                return a;
            }
            set
            {
                a = value;
            }
        }
        public int B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }

        public Rectangle(int a, int b)
        {
            A = a;
            B = b;
        }

        public bool Kvadrat
        {
            get
            {
                if (A == B) return true;
                else return false;
            }
        }

        public void StoroniPramouqolnika()
        {
            Console.WriteLine("Storoni pramouqolnika: dlina: " + A + ", shirina: " + B + ".");
        }

        public void PerimetrPramouqolnika()
        {
            int perimetr = (A + B) * 2;
            Console.WriteLine($"Perimetr pramouqolnika: {perimetr}.");
        }

        public void PloshadPramouqolnika()
        {
            int ploshad = A * B;
            Console.WriteLine($"Ploshad pramouqolnika: {ploshad}.");
        }
    }
}
