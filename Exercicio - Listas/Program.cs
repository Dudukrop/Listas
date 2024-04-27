using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio___Listas
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> lista = new List<string> { "Maria", "Joao", "Eduardo" };
            lista.Add("krop");
            lista.Add("felipe");
            lista.Insert(0, "fal");
            lista.Insert(4, "Gomes");

            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(lista.Count);

            Console.WriteLine();

            string s1 = lista.Find(x => x[0] == 'f');
            Console.WriteLine("Primeiro com a letra a: " + s1);

            string s2 = lista.FindLast(x => x[0] == 'f');
            Console.WriteLine("Ultimo com a letra a: " + s2);

            int s3 = lista.FindIndex(x => x[0] == 'f');
            Console.WriteLine("Primeira posição: " + s3);

            int s4 = lista.FindLastIndex(x => x[0] == 'f');
            Console.WriteLine(s4);

            List<string> lista2 = lista.FindAll(x => x.Length == 5);

            foreach (string obj in lista2)
            {
                Console.WriteLine(obj);
            }
            lista.Remove("felipe");
            foreach (string obj in lista)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine(lista.Count);

            lista.RemoveAll(x => x[0] == 'f');
            lista.RemoveAt(2);
            lista.RemoveRange(2, 4);
        }
    }
}
