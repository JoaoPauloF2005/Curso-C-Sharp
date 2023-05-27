// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com seu nome completo:");

        string nome = Console.ReadLine();

        Console.WriteLine("Quantos quartos tem na sua casa?");

        int qnt_quartos = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com o preço de um produto:");

        double preco_produto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");

        string[] vet = Console.ReadLine().Split(' ');
        string ultimo_nome = vet[0];
        int idade = int.Parse(vet[1]);
        double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

        Console.WriteLine(nome);
        Console.WriteLine(qnt_quartos);
        Console.WriteLine(preco_produto.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(ultimo_nome);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));







        /*
        int n1 = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        string[] vet = Console.ReadLine().Split(' ');
        string nome = vet[0];
        char sexo = char.Parse(vet[1]);
        int idade = int.Parse(vet[2]);
        double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

        Console.WriteLine("vc digitou:");
        Console.WriteLine(n1);
        Console.WriteLine(ch);
        Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine(nome);
        Console.WriteLine(sexo);
        Console.WriteLine(idade);
        Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));*/
    }
}

