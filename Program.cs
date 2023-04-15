using System;

namespace Meses
{
    internal class Program
    {
        // Utilizando o switch case em forma de lista 
        static void Main(string[] args)
        {

            string mes = null;

            Console.WriteLine("Entre com o mês para ser verificado:");
            mes = Console.ReadLine();

            switch (mes)
            {
                case "janeiro":
                case "março":
                case "maio":
                case "julho":
                case "agosto":
                case "outubro":
                case "dezembro":
                    Console.WriteLine("Esse mês tem 31 dias");
                    break;
                case "fevereiro":
                    Console.WriteLine("Esse mês tem 28 dias");
                    break;
                case "setembro":
                case "junho":
                case "abril":
                case "novembro":
                    Console.WriteLine("Esse mês tem 30 dias");
                    break;
            }
                
        }
    }
}
