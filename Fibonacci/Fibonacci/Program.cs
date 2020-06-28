using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Apresentar resultado da sequencia Fibonacci
            Console.WriteLine("Insira o primeiro termo: ");
            int t1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o segundo termo: ");
            int t2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insira o limite da sequencia: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            var sequence = GetSequence(t1, t2, limit);

            if (sequence.Count > 0)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    Console.WriteLine(sequence[i]);
                }
            }
            else
                Console.WriteLine("Não há valores suficientes para a sequencia definida!");

            Console.ReadLine();
        }

        static List<int> GetSequence(int t1, int t2, int limit)
        {
            List<int> sequence = new List<int>();

            try
            {
                for (int i = 0; i < limit; i++)
                {
                    if (i == 0)
                    {
                        sequence.Add(t1);
                    }
                    else if (i == 1)
                    {
                        sequence.Add(t2);
                    }
                    else
                    {
                        sequence.Add(sequence[sequence.Count - 2] + sequence[sequence.Count - 1]);
                    }
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine("There was an error!");
                Console.WriteLine(ex);
            }

            return sequence;
        }
    }
}
