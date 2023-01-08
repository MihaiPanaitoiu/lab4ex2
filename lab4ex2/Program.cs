using System;

namespace lab4ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ex 2
                Cititi de la tastatura continutul unei matrici de intregi cu 3 dimensiuni avand lungimile n, m
                k. Lungimile celor trei dimensiuni ale matricii, n, m si k, vor fi citite de la tastaura.
                 Scrieti o functie care va calcula suma elementelor unei astfel de matrici , apelati-o si afisati-i
                rezultatul.
                 Scrieti o functie care va determina elementul cu valoare maxima, apelati-o si afisati-i
                rezultatul. 
             */
            Console.WriteLine("Introduceti n");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti m");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti k");
            int k = int.Parse(Console.ReadLine());

            int[,,] mat = ReadMatrix(n, m, k);

            Console.WriteLine(MatrixElemSum(mat));

            Console.WriteLine(MaxElemVal(mat));

        }

        static int[,,] ReadMatrix(int n, int m, int k)
        {
            Console.WriteLine("introduceti elementele arrayului");
            int[,,] result = new int[n, m, k];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int l = 0; l < k; l++)
                    {
                        result[i, j, l] = int.Parse(Console.ReadLine());
                    }
                }
            }
            return result;
        }

        static void ShowMatrix(int[,,] arr)
        {
            foreach (int mat in arr)
            {
                Console.Write(mat + " ");
            }
        }

        static int MatrixElemSum(int[,,] arr)
        {
            int sum = 0;
            foreach (int mat in arr)
            {
                sum += mat;
            }
            return sum;
        }

        static int MaxElemVal(int [,,] arr)
        {
            int max = 0;
            foreach (int mat in arr)
            {
                if (mat > max)
                {
                    max = mat;
                }
            }
            return max;
        }
    }
}
