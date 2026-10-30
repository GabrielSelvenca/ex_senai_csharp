Console.Clear();

// 1

// string? nome, cidade, idade;
// int idadeFormatada;

// while (true)
// {
//     Console.WriteLine("Escreva seu nome: ");
//     nome = Console.ReadLine();
//     if (String.IsNullOrWhiteSpace(nome))
//         continue;
//     break;
// }

// while (true)
// {
//     Console.WriteLine("Escreva sua cidade: ");
//     cidade = Console.ReadLine();
//     if (String.IsNullOrWhiteSpace(cidade))
//         continue;
//     break;
// }

// while (true)
// {
//     Console.WriteLine("Escreva sua idade: ");
//     idade = Console.ReadLine();
//     if (String.IsNullOrWhiteSpace(idade))
//         continue;

//     if (!int.TryParse(idade, out idadeFormatada))
//     {
//         Console.WriteLine("Idade enviada não é número inteiro!");
//         await Task.Delay(2500);
//         continue;
//     }
//     break;
// }

// Console.WriteLine($"\n\n========= Suas Informações =========\nNome: {nome}\nCidade: {cidade}\nIdade: {idadeFormatada}");

// string? nomeProduto;
// int qtd;
// decimal preco;

// 2

// Console.Write("Escreva o nome do produto: ");
// nomeProduto = Console.ReadLine();

// Console.Write("Escreva a quantidade do produto: ");
// qtd = int.Parse(Console.ReadLine());

// Console.Write("Escreva o preço unitário do produto: ");
// preco = Convert.ToDecimal(Console.ReadLine());

// decimal valorT = preco * qtd;

// Console.WriteLine($"Nome do produto: {nomeProduto}\n\nQuantidade: {qtd}\n\nPreço unitário: {preco}\n\n\nValor Total: {valorT}");

// string? nome;
// float nota;

// 3

// Console.Write("Escreva o nome do aluno: ");
// nome = Console.ReadLine();

// Console.Write("Escreva a nota do aluno: ");
// string notaString = Console.ReadLine();

// if (float.TryParse(notaString, out nota))
// {
//     if (nota <= 10 && nota >= 0)
//     {
//         string resultado;
//         if (nota >= 7) resultado = "Aprovado";
//         else if (nota >= 5) resultado = "Recuperação";
//         else resultado = "Reprovado";
//         Console.WriteLine($"Nome do aluno: {nome}\nNota: {nota}\n\nAluno está: {resultado}");
//         return;
//     }
// }
// Console.WriteLine("Nota não é um valor correto!");

// 4

// int numInteiro = 0;

// Console.Write("Escreva um número inteiro: ");
// numInteiro = int.Parse(Console.ReadLine());

// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{numInteiro} x {i} = {numInteiro * i}");
// }

// 5

// int numSec = 53;
// int tentativas = 0;

// do
// {
//     Console.Write($"Quantidade de tentativas: {tentativas}\nEscolhe um número inteiro: ");
//     int entrada = int.Parse(Console.ReadLine()!);

//     Console.Clear();
//     if (entrada == numSec) break;
//     else if (entrada < numSec) Console.WriteLine("Numero digitado é menor que o número secreto");
//     else if (entrada > numSec)  Console.WriteLine("Numero digitado é maior que o número secreto");
//     tentativas++;
// } while(true);

// Console.WriteLine($"Parabéns você acertou o número: {numSec}\n\nQuantidade de tentativas: {tentativas}");

// 6

// int Somar(int a, int b)
// {
//     return a + b;
// }

// int Multiplicar(int a, int b)
// {
//     return a * b;
// }

// Console.Write("Escreva o primeiro número: ");
// int a = int.Parse(Console.ReadLine()!);

// Console.Write("Escreva o segundo número: ");
// int b = int.Parse(Console.ReadLine()!);

// int soma = Somar(a,b);
// int multi = Multiplicar(a,b);

// Console.WriteLine($"Soma = {soma}\nMultiplicação = {multi}");

// 7

// float[] notas = new float[3];

// for (int i = 0; i < notas.Length; i++)
// {
//     Console.Write($"Escreva a {i+1}ª nota: ");
//     notas[i] = float.Parse(Console.ReadLine()!);
// }

// for (int i = 0; i < notas.Length; i++)
// {
//     Console.WriteLine(notas[i]);
// }

// float soma = 0;
// foreach (float nota in notas)
// {
//     soma += nota;
// }

// double media = Math.Round(soma / notas.Length, 2);

// Console.WriteLine($"Media das notas: {media:F2}");

// 8

// int[] numeros = new int[5];

// for (int i = 0; i < numeros.Length; i++)
// {
//     Console.Write($"Digite um número inteiro: ");
//     numeros[i] = int.Parse(Console.ReadLine()!);
// }

// Console.WriteLine("\n\nNúmeros salvos:\n\n");

// foreach (var num in numeros)
// {
//     Console.WriteLine(num );
// }

// int totalPar = 0, maior = 0;

// for (int i = 0; i < numeros.Length; i++)
// {
//     if (numeros[i] % 2 == 0)
//         totalPar++;

//     if(numeros[i] > maior)
//         maior = numeros[i];
// }

// Console.WriteLine($"Total de números pares: {totalPar}\nMaior número: {maior}");

// 9 

List<string> produtos = new List<string>();


for (int i = 0; i < 3; i++)
{
    Console.Write($"Digite o nome do produto nº {i + 1}: ");
    string nomeProduto = Console.ReadLine()!;

    if (String.IsNullOrWhiteSpace(nomeProduto))
    {
        Console.WriteLine("\nNome do produto não pode ser nulo ou vazio!\n");
        i--;
    }

    produtos.Add(nomeProduto);
}

Console.WriteLine("\nProdutos: ");

foreach (var produto in produtos)
{
    Console.WriteLine(produto);
}

Console.Write("\nEscreva o nome de um produto para validar se está na lista: ");
string busca = Console.ReadLine()!;

if (produtos.Contains(busca))
    Console.WriteLine("\nProduto existe na lista!\n");
else
    Console.WriteLine("\nProduto não existe na lista!\n");

Console.Write("\n\nEscreva o nome de um produto para remover da lista: ");
string produtoRemove = Console.ReadLine()!;

if (produtos.Contains(produtoRemove))
{
    produtos.Remove(produtoRemove);
    Console.WriteLine("\nProduto removido com sucesso!\n");
}
else
    Console.WriteLine("Produto não encontrado para ser removido.");

Console.WriteLine("\n\nProdutos: ");

foreach (var produto in produtos)
{
    Console.WriteLine(produto);
}