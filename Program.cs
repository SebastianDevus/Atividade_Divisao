double numerador, denominador, resultado; // Declarando variáveis

Console.WriteLine(); // Linha em branco

 // Solicitando e armazenando o numerador e o denominador
Console.Write("Digite o numerador....: ");
numerador = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o denominador..: ");
denominador = Convert.ToDouble(Console.ReadLine());

// Verificando se o denominador é zero. A operação será feita caso contrário
if (denominador == 0)
{
    Console.WriteLine("Não é possível dividir por zero."); 
    
    Console.WriteLine(); // Linha em branco
}
else 
{
    Console.WriteLine(); // Linha em branco

    // Dividindo e exibindo o resultado
    resultado = numerador / denominador;
    Console.WriteLine($"{numerador} dividido {denominador} é {resultado:N2}"); 

    Console.WriteLine(); // Linha em branco
}