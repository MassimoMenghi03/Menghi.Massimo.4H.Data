using System;

namespace Menghi.Massimo._4H.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Data D = new Data(30, 06, 2004);

            D.Out();

            D.Mod(32, 12, 2020);

            Console.WriteLine("Data modificata: ");

            D.Out();

            if(D.Val())
            {
                Console.WriteLine("Data non valida.");
            }
            else
            {
                Console.WriteLine("Data valida.");
            }



        }
    }

    class Data
    {
        int x;
        int y;
        int z;

        public int G
        {
            get;
            set;
        }

        public int M
        {
            get;
            set;
        }

        public int A
        {
            get;
            set;
        }

        public Data(int x, int y, int z)
        {
            G = x;
            M = y;
            A = z;
        }

        public void Mod(int x, int y, int z)
        {
            G = x;
            M = y;
            A = z;
        }

        public void Out()
        {
            Console.WriteLine($"{G.ToString("D2")}, {M.ToString("D2")}, {A.ToString("D2")}");
        }

        public bool Val()
        {
            if (A < 0 || A > 2100)
            {
                return true;
            }

            if (M > 12 || M < 1)
            {
                return true;
            }

            if (G > 31 || G < 1)
            {
                return true;
            }

            if (M != 1 && M != 3 && M != 5 && M != 7 && M != 8 && M != 10 && M != 12)
            {
                if (G < 1 || G > 30)
                {
                    return true;
                }
            }
            else
            {
                if (M == 2 && A % 4 == 0)
                {
                    if (G < 1 || G > 29)
                    {
                        return true;
                    }

                }

                if (M == 2 && A % 4 != 0)
                {

                    if (G < 1 || G > 28)
                    {
                        return true;
                    }

                }

            }

            return false;
        }
    }
}