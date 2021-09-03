using System; 

class AreaCirculo
{
  static void Main(string[] args)
  {
    double pi = 3.14159, raio;

    raio = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("A=" + (pi * ( raio * raio) ).ToString("0.0000"));
  }
}