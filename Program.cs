int numerador, denominador, resultado; // Declarando variáveis

Console.WriteLine(); // Linha em branco

Console.Write("Digite o numerador....: ");
numerador = Convert.ToInt32(Console.ReadLine()); // Solicitando e armazenando o numerador

Console.Write("Digite o denominador..: ");
denominador = Convert.ToInt32(Console.ReadLine()); // Solicitando e armazenando o denominador

if (denominador == 0) // Verificando se o denominador é zero. A operação será feita caso contrário
{
    Console.WriteLine("Não é possível dividir por zero."); 
    Console.WriteLine(); // Linha em branco
}
else 
{
    Console.WriteLine(); // Linha em branco

    resultado = numerador / denominador;
    Console.WriteLine($"{numerador} dividido {denominador} é {resultado}"); // Dividindo e exibindo o resultado

    Console.WriteLine(); // Linha em branco
}