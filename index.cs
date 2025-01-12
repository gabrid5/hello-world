/* Execução com o código C# */

using System;

class Program
{
    static void Main()
    {
        // Exibe uma saudação inicial
        Console.WriteLine("Bem-vindo ao programa de exemplo!");

        // Solicita o nome do usuário
        Console.Write("Por favor, insira seu nome: ");
        string nome = Console.ReadLine();

        // Solicita a idade do usuário
        Console.Write("Por favor, insira sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        // Calcula a idade em dias (aproximação simples)
        int idadeEmDias = idade * 365;

        // Exibe a saudação personalizada
        Console.WriteLine($"Olá, {nome}! Você tem {idade} anos, o que equivale a {idadeEmDias} dias.");

        // Exibe uma mensagem de despedida
        Console.WriteLine("Obrigado por usar o programa. Até logo!");
    }
}
