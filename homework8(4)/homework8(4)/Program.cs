using System;

namespace homework8_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nominal: ");
                string a = Console.ReadLine();
                int first = int.Parse(a);
                Console.WriteLine("Kolichestvo kupur: ");
                string b = Console.ReadLine();
                int second = int.Parse(b);
                Money money = new Money(first, second);
                Console.WriteLine("Summa na pokupku tovara: ");
                string c = Console.ReadLine();
                money.N = int.Parse(c);
                Console.WriteLine("Cena tovara: ");
                string d = Console.ReadLine();
                money.n = int.Parse(d);
                money.Dengi();
                Console.WriteLine("Vsego deneg: " + money.SummaDeneg + ".");
                Console.WriteLine("Deneg xvatit na pokupku tovara? " + money.XvatitDeneg());
                Console.WriteLine("Mi mojem kupit " + money.KolichestvoTovara() + " shtuk tovara.");
            }
            catch
            {
                Console.WriteLine("Oshibka! Nujno chislo!");
            }

        }
    }


    class Money
    {
        private int first;
        private int second;
        public int First
        {
            get
            {
                return first;
            }
            set
            {
                first = value;
            }
        }

        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                second = value;
            }
        }

        public int N
        {
            get;
            set;
        }

        public int n
        {
            get;
            set;
        }

        public Money(int f, int s)
        {
            First = f;
            Second = s;
        }

        public int SummaDeneg
        {
            get
            {
                return First * Second;
            }
        }

        public void Dengi()
        {
            Console.WriteLine("Nominal: " + First + ", Kolichestvo kupur: " + Second + ".");
        }

        public string XvatitDeneg()
        {
            return First * Second >= N ? "Da" : "Net";
        }

        public int KolichestvoTovara()
        {
            return First * Second / n;
        }
    }
}
