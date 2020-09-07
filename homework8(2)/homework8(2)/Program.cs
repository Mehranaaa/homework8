using System;

namespace homework8_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pervaya storona: ");
                string a = Console.ReadLine();
                int a1 = int.Parse(a);
                Console.WriteLine("Vtoraya storona: ");
                string b = Console.ReadLine();
                int b1 = int.Parse(b);
                Console.WriteLine("Tretya storona: ");
                string c = Console.ReadLine();
                int c1 = int.Parse(c);
                Triangle treuqolnik = new Triangle(a1, b1, c1);
                if (treuqolnik.VozmojniyTreuqolnik == true)
                {
                    treuqolnik.StoroniTreuqolnika();
                    treuqolnik.PerimetrTreuqolnika();
                    treuqolnik.Ploshad();
                }
                else
                {
                    Console.WriteLine("Oshibka! Net takoqo treuqolnika!");
                }
            }
            catch
            {
                Console.WriteLine("Oshibka! Nujno chislo!");
            }

        }
    }

    class Triangle
    {
        private int a;
        private int b;
        private int c;

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
        public int C
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
            }
        }

        public bool VozmojniyTreuqolnik
        {
            get
            {
                if (A + B > C && A + C > B && B + C > A)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }

        public Triangle(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public void StoroniTreuqolnika()
        {
            Console.WriteLine("Storoni treuqolnika: " + A + ", " + B + ", " + C + ".");
        }

        public void PerimetrTreuqolnika()
        {
            Console.WriteLine($"Perimetr treuqolnika: {A + B + C}.");
        }

        public void Ploshad()
        {
            int perimetr = A + B + C;
            int poluPerimetr = perimetr / 2;
            double ploshad = Math.Sqrt(poluPerimetr * (poluPerimetr - A) * (poluPerimetr - B) * (poluPerimetr - C));
            Console.WriteLine($"Ploshad treuqolnika: {ploshad}.");
        }
    }
}
