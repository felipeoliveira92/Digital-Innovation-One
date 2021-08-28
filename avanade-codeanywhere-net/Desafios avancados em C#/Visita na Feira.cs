using System; 

class VisitaFeira
{
    static void Main() 
    {
        int a, b, x;
        string[] numeros = Console.ReadLine().Split(" ");
        
        a = int.Parse(numeros[0]);
        b = int.Parse(numeros[1]);
        
        x = a + b;
        
        Console.WriteLine($"X = {x}");
    }
}