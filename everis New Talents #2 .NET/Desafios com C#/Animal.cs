using System;
using System.Text;

class Animal
{
  public static void Main (string[] args) 
  {
    String  word1; //declare as suas variaveis
    String  word2;
    String  word3;

    word1 = Console.ReadLine(); //insira suas variaveis
    word2 = Console.ReadLine();
    word3 = Console.ReadLine();

    if (word1 =="vertebrado")
    {
      if(word2 == "ave")
      {
        if(word3 == "carnivoro")
        {
          Console.WriteLine("aguia");
        }
        else
        {
          Console.WriteLine("pomba");
        }
      }
      else if(word2 == "mamifero")
      {
        if(word3 == "onivoro")
        {
          Console.WriteLine("homem");
        }
        else
        {
          Console.WriteLine("vaca");
        }
      }
    }
    else if (word1 == "invertebrado")
    {
      if(word2 == "inseto")
      {
        if(word3 == "hematofago")
        {
          Console.WriteLine("pulga");
        }
        else
        {
          Console.WriteLine("lagarta");
        }
      }
      else if(word2 == "anelideo")
      {
        if(word3 == "hematofago")
        {
          Console.WriteLine("sanguessuga");
        }
        else
        {
          Console.WriteLine("minhoca");
        }
      }
    }
  }
}