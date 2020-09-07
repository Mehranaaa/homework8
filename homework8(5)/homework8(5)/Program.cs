using System;

namespace homework8_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Kolichestvo elementov massiva: ");
                int kolichestvo = int.Parse(Console.ReadLine());
                Array array = new Array(kolichestvo);
                array.sKlaviaturi();
                Console.WriteLine("Elementi: ");
                array.ElementiNaEkran();
                array.Bubble();
                Console.WriteLine("Otsortirovano: ");
                array.ElementiNaEkran();
                Console.WriteLine("Skalar dla umnojeniya: ");
                int skalar = int.Parse(Console.ReadLine());
                array.UmnojNaSkalar = skalar;
                Console.WriteLine("Peremnojili!");
            }
            catch
            {
                Console.WriteLine("Oshibka! Nujno celoe chislo!");
            }
        }
    }

    class Array
    {
        private int[] intArray;
        private int n;
        public int[] IntArray
        {
            get
            {
                return intArray;
            }
            set
            {
                intArray = value;
            }
        }
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

        public int Razmernost
        {
            get
            {
                return N;
            }
        }

        public int UmnojNaSkalar
        {
            set
            {
                for (int i = 0; i < N; i++)
                {
                    Console.WriteLine(IntArray[i] = IntArray[i] * value);
                }
            }
        }

        public Array(int razmer)
        {
            N = razmer;
            IntArray = new int[N];
        }

        public void sKlaviaturi()
        {
            for (int i = 0; i < N; i++)
            {
                try
                {
                    Console.WriteLine("Vvedite element pod indeksom: " + i);
                    int element = int.Parse(Console.ReadLine());
                    IntArray[i] = element;
                }
                catch
                {
                    Console.WriteLine("Oshibka! Nujno celoe chislo!");
                }
            }
        }

        public void ElementiNaEkran()
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(IntArray[i]);
            }
        }

        public void Bubble()
        {
            int temp;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (IntArray[i] > IntArray[j])
                    {
                        temp = IntArray[i];
                        IntArray[i] = IntArray[j];
                        IntArray[j] = temp;
                    }
                }
            }
        }
    }
}
