using System; 
 
class Guilherme_Pipas
{
    static void Main(string[] args) 
    { 
        long N = long.Parse(Console.ReadLine());
        long resposta = ((N - 3)* N) /2;
        Console.WriteLine(resposta);
    }
}