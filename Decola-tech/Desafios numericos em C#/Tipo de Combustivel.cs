using System; 

class TipoCombustivel {

    static void Main(string[] args) { 
      
      int Alcool = 0;
      int Gasolina = 0;
      int Diesel =0;
      int n;
      
      do
      {
        n = Convert.ToInt32(Console.ReadLine());
        
        switch (n)
        {
          case 1:
            Alcool++;
            break;
          case 2:
            Gasolina++;
            break;
          case 3:
            Diesel++;
            break;
          case 4:
            Console.WriteLine("MUITO OBRIGADO"); 
            break;
        }
        
      }
      while(n < 4 || n > 4);
      
      Console.WriteLine("Alcool: " + Alcool);
      Console.WriteLine("Gasolina: " + Gasolina);
      Console.WriteLine("Diesel: " + Diesel);
    }
}