/*  Atividade 01

    Peça dois números inteiros, se forem iguais realize a soma, se forem difeferentes realize a multiplicação.
*/

// Obter o primeiro valor

Console.WriteLine("Informe o primeiro número:");
int numero1 = Convert.ToInt32(Console.ReadLine());

// Obter o Segundo valor

Console.WriteLine("Informe o Segundo número:");
int numero2 = Convert.ToInt32(Console.ReadLine());

// Condicional

if (numero1 == numero2)
{
    Console.WriteLine(numero1+numero2);
}
else
{
    Console.WriteLine(numero1*numero2);
}