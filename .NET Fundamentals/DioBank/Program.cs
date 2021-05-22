using System;

namespace DioBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Felipe Rabelo");
            Console.WriteLine("Hello World!");
        }
    }
}
