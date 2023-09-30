using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("============PROJETO PA============");
            Console.WriteLine("INSIRA A QUANTIDADE DE TERMOS: \r");
            var termo = int.Parse(Console.ReadLine());
            Console.WriteLine("INSIRA O PRIMEIRO TERMO: \r");
            var t1 = int.Parse(Console.ReadLine());
            Console.WriteLine("INSIRA A RAZÃO");
            var razao = int.Parse(Console.ReadLine());

            CalcularPA(termo, t1, razao);

            Console.ReadLine();
            Console.WriteLine("==================================");
            Console.WriteLine("1 - Recomeçar\n 2 - Sair");

            var escolha = Console.ReadLine();

            switch(escolha)
            {
                case "1":
                    Menu();
                    break;
                case "2":
                    break;
            }
            
        }

        static void CalcularPA(int termo, int t1, int razao)
        {
            int termoAnt = t1;
            Console.WriteLine($"\r{t1}\r");
            Console.WriteLine("==================================");
            for (int i = 0; i < termo; i++)
            {
                var termoAt = termoAnt + razao;
                Console.WriteLine($"\r{termoAt}\r"); 
                termoAnt = termoAt;
            }
        }
    }
}
