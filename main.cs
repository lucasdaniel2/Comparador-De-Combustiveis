using System;

class Program
{

    public static void Main(string[] args)
    {
        double p_alcool, p_gasolina, razao;
        int escolha = 1;
        while (escolha == 1)
        {
            Console.Write("Digite o preço por litro do álcool R$ ");
            p_alcool = double.Parse(Console.ReadLine());
            Console.Write("Digite o preço por litro da gasolina R$ ");
            p_gasolina = double.Parse(Console.ReadLine());
            razao = p_alcool / p_gasolina;

            if (razao == 0.7)
            {
                Console.WriteLine("Tanto faz com qual combustível abastecer...");
                Console.WriteLine("Para novo teste, digite 1, senão digite 2");
                escolha = int.Parse(Console.ReadLine());
            }

            else if (razao < 0.7)
            {
                Console.WriteLine(" Vale a pena abastecer com álcool! ");
                Console.WriteLine("Para novo teste, digite 1, senão digite 2");
                escolha = int.Parse(Console.ReadLine());
            }

            else
            {
                Console.WriteLine("Vale a pena abastecer com gasolina! ");
                Console.WriteLine("Para novo teste, digite 1, senão digite 2");
                escolha = int.Parse(Console.ReadLine());
            }
        }
    }
}

