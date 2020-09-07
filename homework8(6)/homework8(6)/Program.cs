using System;

namespace homework8_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Kolichestvo strok: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Kolichestvo stolbcov: ");
                int m = int.Parse(Console.ReadLine());
                Array2 array = new Array2(n, m);
                array.ElementiSKlaviaturi();
                Console.WriteLine("Elementi: ");
                array.PokazatElementi();
                Console.WriteLine("Skalar dla pribavleniya: ");
                int skalar = int.Parse(Console.ReadLine());
                array.PlusScalar = skalar;
                Console.WriteLine("Elementi: ");
                array.PokazatElementi();
            }
            catch
            {
                Console.WriteLine("Oshibka! Nujno celoe chislo!");
            }
        }
    }

    class Array2
    {
        private double[,] doubleArray;
        private int n;
        private int m;
        public int N
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }
        public int M
        {
            get
            {
                return m;
            }
            set
            {
                m = value;
            }
        }
        public double[,] DoubleArray
        {
            get
            {
                return doubleArray;
            }
            set
            {
                doubleArray = value;
            }
        }

        public Array2(int n, int m)
        {
            N = n;
            M = m;
            DoubleArray = new double[N, M];
        }

        public void ElementiSKlaviaturi()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine("Vvedite element: stroka: " + i + ", stolbec: " + j + ".");
                    DoubleArray[i, j] = double.Parse(Console.ReadLine());
                }
            }
        }

        public void PokazatElementi()
        {
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.WriteLine(DoubleArray[i, j]);
                }
            }
        }

        public int ObsheeKolichestvo
        {
            get
            {
                return N * M;
            }
        }

        public double PlusScalar
        {
            set
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        DoubleArray[i, j] += value;
                    }
                }
            }
        }
    }
}
