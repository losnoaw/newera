/*
    ATIVIDADE 02
    
    Peça um número e retorne se e impar ou par
*/


//Verificação

//Expressão ternario

Console.WriteLine("Informe um Número:");
int numero = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(numero % 2 == 0 ? "O número é Par" : "O número é Ímpar");

/*Console.WriteLine("Digite um número:");
int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0)
{
    Console.WriteLine($"O número {numero} é par.");
}
else
{
    Console.WriteLine($"O número {numero} é ímpar.");
}*/