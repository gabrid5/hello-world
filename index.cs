/* Hello World */

Console.WriteLine("Hello World");

var names = new[] { "gabri", "d", "5" };
string combinedName = "";  // Variável para armazenar a concatenação das palavras

foreach (var name in names)
{
    // Adiciona cada nome ao combinedName
    combinedName += name;  
    Console.WriteLine($"Hello {name}");
}

// Exibe a combinação das palavras
Console.WriteLine($"Combined Name: {combinedName}");
