
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
namespace Recapitulare
{
    class Program
    {
        static Random rnd = new Random();
        static int MAX = 100;
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int[] v = GenerateRandomArray(10);


            PrintArray(v,"inainte de sortare:");
            sw.Start();
            //Array.Sort(v);
           
           // SelectionSort(v);
            
          //BubbleSort(v);
            
            //BubbleSort2(v);
           
           // InsertionSort(v);
            
            SortareaMea(v);
            PrintArray(v, "dupa sortare:");
            sw.Stop();
            Console.WriteLine($"Sortarea a durat {sw.ElapsedMilliseconds} milisecunde");
        }

        private static void SortareaMea(int[] v)
        {
            int i, j;
            for (i = 0; i < v.Length - 1; i++)
                for (j = i + 1; j < v.Length; j++)
                    if (v[i] > v[j])
                        swap(v, i, j);
        }

        private static void InsertionSort(int[] v)
        {
            int i, k;
            for (i = 1; i < v.Length; i++)
                for (k = i; k > 0 && v[k] < v[k - 1]; k--)
                    swap(v, k, k - 1);
        }

        private static void BubbleSort2(int[] v)
        {
            int i;
            bool sortat;
            do
            {
                sortat = true;
                for (i = 0; i < v.Length - 1; i++)
                    if (v[i] > v[i + 1])
                    {
                        swap(v, i, i + 1);
                        sortat = false;
                    }
            } while (sortat != true);
        }

        private static void BubbleSort(int[] v)
        {
            int i, j;
            bool swapped;
            for(i=0;i<v.Length;i++)
            {
                swapped = false;
                for(j=v.Length-1;j>=i+1;j--)
                    if(v[j]<v[j-1])
                    {
                        swap(v, j, j - 1);
                        swapped = true;
                    }
                if (swapped == false)
                    break;
            }
        }

        private static void SelectionSort(int[] v)
        {
            int i, j, k;
            for(i=0;i<v.Length;i++)
            {
                k = i;
                for (j = i + 1; j < v.Length; j++)
                    if (v[j] < v[k])
                        k = j;
                swap(v, i, k);
            }
        }

        private static void swap(int[] v, int i, int k)
        {
            int aux;
            aux = v[i];
            v[i] = v[k];
            v[k] = aux;
        }

        private static void PrintArray(int[] v1, string message)
        {
            Console.WriteLine(message);
            foreach(int item in v1)
                Console.Write(item+" ");
            Console.WriteLine();
        }

        private static int[] GenerateRandomArray(int n)
        {
            int[] v = new int[n];

            for (int i = 0; i < v.Length; i++)
                v[i] = rnd.Next(MAX);
            return v;
        }
    }
}
