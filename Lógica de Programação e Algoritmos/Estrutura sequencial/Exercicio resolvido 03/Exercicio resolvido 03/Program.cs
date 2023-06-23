using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Declaramos a variavel
        string nome1, nome2; 
        int idade1, idade2;
        double media;

        string[] vet;

        //ler a linha inteira, divide em duas partes, separada por um espaço (' '), pegamos os dados e guardamos na variavel 'vet'
        vet = Console.ReadLine().Split(' ');
        nome1 = vet[0];
        idade1 = int.Parse(vet[1]);

        vet = Console.ReadLine().Split(' ');
        nome2 = vet[0];
        idade2 = int.Parse(vet[1]);

        //Soma da media de idades, é necessario declarar que é double, pois senão, não irá ficar certo
        media = (double) (idade1  + idade2) / 2.0;

        Console.WriteLine("A idade média de " + nome1 + " e " + nome2 + " é de " + media.ToString("F1", CultureInfo.InvariantCulture) + " anos");


    }
}
