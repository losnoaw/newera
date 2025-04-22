// Variável
string linguagem = "C#";

// Estrutura de escolha
// switch (linguagem)
// {
//     case "C#":
//         Console.WriteLine("C# é uma linguagem de programação");
//         break;
//     case "HTML":
//         Console.WriteLine("HTML é uma linguagem de marcação");
//         break;
//     case "CSS":
//         Console.WriteLine("CSS é uma linguagem de estilo");
//         break;
//     default:
//         Console.WriteLine("Linguagem não encontrada");
//         break;
// }

// Expressão Switch
string retorno = linguagem switch
{
    "C#" => "C# é uma linguagem de programação",
    "HTML" => "HTML é uma linguagem de marcação",
    "CSS" => "CSS é uma linguagem de estilo",
    _ => "Linguagem não encontrada"
};

Console.WriteLine(retorno);