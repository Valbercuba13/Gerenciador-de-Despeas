using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Receita
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            int[] despesas = new int[5];

            Console.Write("Digite o Valor do Salario: ");
            despesas[0] = Convert.ToInt32(Console.ReadLine()); 

            Console.Write("Digite o Valor do Combustivel: ");
            despesas[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Valor do Mercado: ");
            despesas[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Valor da Casa: ");
            despesas[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o Valor do Lazer: ");
            despesas[4] = Convert.ToInt32(Console.ReadLine());

            int baseFinanceira = despesas[0] - despesas[1] - despesas[2] - despesas[3] - despesas[4];

            if (baseFinanceira < 400)
            {
                Console.WriteLine("Estamos na merda com: {0}", baseFinanceira);
            }
            else
            {
                Console.WriteLine("Estamos na boa com: {0}", baseFinanceira);
            }
            Console.WriteLine("Pressione 'x' para sair ou 'r' para recomeçar.");

            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.X)
            {
                continuar = false;
            }
            else if (key.Key == ConsoleKey.R)
            {
                Console.Clear();
            }
        }
    }
}