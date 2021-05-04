using System;

namespace DesafioJoeslei___0305
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaFloresta = 2;
            int diaEstrada = 1;
            int etapaFloresta = 2 * diaFloresta;
            int etapaEstrada = 2 * diaEstrada;
            int xFloresta = 0;
            int xEstrada = 0;

            Random ran = new Random();

            int vidaJoeslei = 18;
            int valorMinimo = 5, valorMaximo = 8; //Intervalo de dano de Joeslei

            int vidaGoblin = 10;
            int valorMinimoGob = 2, valorMaximoGob = 5; //Intervalo de dano de Goblin

            Console.WriteLine("Joeslei decide ir a capital");
            Console.WriteLine();
            Console.WriteLine("Por onde ele deve ir? Ir pela Floresta ou ir pela Estrada");
            string escolha = Console.ReadLine();

            if (escolha == "Floresta")
            {
                while (xFloresta < etapaFloresta)
                {
                    int chanceInimigo = ran.Next(1, 5);                    
                    if (chanceInimigo == 1)
                    {
                        Console.WriteLine("Você encontrou um inimigo na etapa: " + xFloresta);
                        int inimigo = ran.Next(1, 11);
                        if (inimigo <= 7)
                        {
                           
                        }
                        else if (inimigo <= 9)
                        {
                            Console.WriteLine("Seu inimigo é um Orc");
                        }
                        else
                        {
                            Console.WriteLine("Seu inimigo é um Troll");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você não encontrou nenhum inimigo na etapa: " + xFloresta);
                    }
                    xFloresta++;
                }
            }
            else
            {

            }
        }
    }
}
