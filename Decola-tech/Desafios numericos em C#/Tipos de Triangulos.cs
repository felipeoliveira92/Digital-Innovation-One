using System;

namespace teste
{
    class TiposTriangulos
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(" ");

            double A = double.Parse(line[0]);

            double B = double.Parse(line[1]);

            double C = double.Parse(line[2]);

            double aux;


            if (B > A && B > C)
            {
                aux = A;

                A = B;

                B = aux;
            }
            else if (C > A)
            {
                aux = A;

                A = C;

                C = aux;
            }


            if (A >= (B + C))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            }
            else
            {
                if (A * A == (B * B) + (C * C)) 
                {
                  Console.WriteLine("TRIANGULO RETANGULO");
                }
                if (A * A > (B * B) + (C * C)) 
                {
                  Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                if (A * A < (B * B) + (C * C))
                {
                  Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (A == B && A == C) 
                {
                  Console.WriteLine("TRIANGULO EQUILATERO");
                }
                if ((A == B && A != C) || (A == C && A != B) || (B == C && B != A))
                {
                  Console.WriteLine("TRIANGULO ISOSCELES");
                }
                    
            }
        }
    }
}