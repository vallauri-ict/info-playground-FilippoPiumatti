using System;

namespace algoritmodiricercaablocchi_project
{
    class Program
    {
        
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int n,x,lb;
            
            do
            {
                Console.Write("inserisci la lunghezza del vettore: ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n<=0);
            caricavet(a, n);
            stampavet(a, n);
            Console.Write("inserisci la chiave di ricerca: ");
            x = Convert.ToInt32(Console.ReadLine());
            bool trovato = false;
            bool esci = false;
            lb = (n * n) / n;
            int i = (lb - 1);
            

            do
            {
                if (a[i]==x)
                {
                    trovato = true;
                }
                else
                {
                    if (a[i] > x)
                        esaminablocco(a, n);
                    else
                        i = i + lb;
                }
            } while (trovato==false && esci==false && i<=n-1);
            if (trovato)
                Console.WriteLine("elemento trovato in posizione " + (i + 1).ToString());
            else
            {
                if (esci)
                    Console.WriteLine("elemento non trovato");
                else
                    ultimoblocco(a, n);
            }
        }

        private static void ultimoblocco(int[] a, int n)
        {
            
        }

        private static void esaminablocco(int[] a, int n)
        {

            int j = 0;
        }

        private static void stampavet(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(v[i]);
            }
        }

        private static void caricavet(int[] v, int n)
        {
            for (int i = 0; i < n; i++)
            {
                v[i] = rnd.Next(1, 11);
            }
        }
    }
}
