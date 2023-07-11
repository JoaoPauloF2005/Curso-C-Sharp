// são declaradas as variáveis N, anos, meses, dias e resto, todas do tipo int.
int N, anos, meses, dias, resto;

//A linha N = int.Parse(Console.ReadLine());
//solicita ao usuário que digite um valor, que será armazenado na variável N após ser convertido de uma string para um inteiro.
N = int.Parse(Console.ReadLine());

//A próxima linha, anos = N / 365;, calcula o número de anos contidos em N dividindo-o por 365.
//Essa operação é possível porque a divisão de dois números inteiros resulta em um número inteiro, descartando a parte decimal.
anos = N / 365;

//resto = N % 365; calcula o resto da divisão de N por 365,
//usando o operador % (módulo). O operador módulo retorna o resto da divisão inteira.
resto = N % 365;

//A linha meses = resto / 30; calcula o número de meses contidos no resto obtido na etapa anterior, dividindo-o por 30.
meses = resto / 30;

//Por fim, dias = resto % 30; calcula o número de dias restantes, que é o resto da divisão anterior por 30.
dias = resto % 30;

Console.WriteLine(anos + " ano(s)");
Console.WriteLine(meses + " mes(es)");
Console.WriteLine(dias + " dia(s)");