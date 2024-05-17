namespace _2m_MonzenieMacierzy
{
    internal class Program
    {
        public static void wypisz(int[,] a, int w, int k)
        {
            for (int i = 0; i < w; i++)
            {
                for(int j = 0; j < k; j++)
                    Console.Write(a[i, j]+ " ");
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            const int w = 2;
            const int k = 3;
            int[,] A = { { 2, 1, 3 }, { -1, 2, 4 } };
            int[,] B = { { 1, 3 }, { 2, -2 }, { -1, 4 } };
            int[,] C = { { 0, 0 }, { 0, 0 } };
            Console.WriteLine("Macierz A");
            wypisz(A, 2, 3);
            Console.WriteLine("Macierz B");
            wypisz(B, 3, 2);

            for(int x=0; x < w; x++)
            {
                for(int y=0; y < w; y++)
                {
                    int c = 0;
                    for (int i = 0; i < k; i++)
                        c += A[x, i] * B[i, y];
                    Console.WriteLine(c);
                    C[x,y] = c;
                }

            }
            Console.WriteLine("Macierz C");
            wypisz(C, 2, 2);


        }
    }
}
