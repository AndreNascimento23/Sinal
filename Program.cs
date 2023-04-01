Console.Clear();int numero;

Console.WriteLine("--- Positivo ou Negativo ---\n");
Console.Write("Digite um numero: ");
numero = Convert.ToInt32(Console.ReadLine());

if (numero < 0 )
{
    Console.WriteLine("\nNegativo");
}

else if (numero > 0)
 {
    Console.WriteLine("\nPositivo");
 }   

else 
{
    Console.WriteLine("Zero");
}