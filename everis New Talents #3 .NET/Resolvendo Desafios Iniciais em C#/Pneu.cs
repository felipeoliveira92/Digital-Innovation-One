using System;

class Pneu {
    static void Main () {
        var A = int.Parse(Console.ReadLine());
        var B = int.Parse(Console.ReadLine());
        var diferenca = A - B;
       
        Console.WriteLine($"{diferenca}"); 
    }
}