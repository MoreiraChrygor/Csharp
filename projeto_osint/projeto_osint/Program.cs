using System;

namespace Aula1_Exemplo5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, ultimo, cidade, rua, bairro;
            int n_casa;

            Console.WriteLine("Digite seu primeiro nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o seu ultimo nome: ");
            ultimo = Console.ReadLine();

            Console.WriteLine("Digite a cidade: ");
            cidade = Console.ReadLine();

            Console.WriteLine("Digite a rua: ");
            rua = Console.ReadLine();

            Console.WriteLine("Digite o número da casa: ");
            n_casa = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o bairro: ");
            bairro = Console.ReadLine();

            
            Console.WriteLine("\n--- Dados cadastrados ---");
            Console.WriteLine("Nome completo: " + nome + " " + ultimo);
            Console.WriteLine("Endereço: " + rua + ", Nº " + n_casa + ", Bairro " + bairro + ", Cidade " + cidade);

            Console.ReadKey();
        }
    }
}