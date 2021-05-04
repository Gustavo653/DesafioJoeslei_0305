using System;
using System.Threading.Tasks;

namespace DesafioJoeslei___0305
{
    class Program
    {
        static async Task Main(string[] args)
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
            int resistenciaJoeslei = 2;

            int vidaGoblin = 10;
            int valorMinimoGob = 2, valorMaximoGob = 5; //Intervalo de dano de Goblin

            int vidaOrc = 12;
            int valorMinimoOrc = 3, valorMaximoOrc = 7; //Intervalo de dano de Goblin

            int vidaTroll = 20;
            int valorMinimoTroll = 5, valorMaximoTroll = 9; //Intervalo de dano de Goblin

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
                            Console.WriteLine("Seu inimigo é um Goblin");
                            Console.WriteLine("A luta iniciará em breve");
                            await Task.Delay(2000);
                            while (vidaGoblin > 0 || vidaJoeslei > 0)
                            {
                                int danoJoeslei = ran.Next(valorMinimo, valorMaximo);
                                int danoGoblin = ran.Next(valorMinimoGob, valorMaximoGob);

                                Console.WriteLine("Você deseja: 1 - Atacar, 2 - Defender, 3 - Usar item ou 4 - Fugir");
                                int decisao = int.Parse(Console.ReadLine());
                                if (decisao == 1)
                                {
                                    int danoAtaque = ran.Next(1, 101);
                                    if (danoAtaque <= 8)
                                    {
                                        Console.WriteLine("DANO ORIGINAL: " + danoJoeslei);
                                        danoJoeslei *= 2;
                                        Console.WriteLine("DANO DOBRADO: " + danoJoeslei);
                                    }
                                    vidaGoblin -= danoJoeslei;
                                    if (danoJoeslei > vidaGoblin)
                                    {
                                        vidaGoblin = 0;
                                        break;
                                    }
                                    vidaJoeslei -= danoGoblin;
                                    if (danoGoblin > vidaJoeslei)
                                    {
                                        vidaJoeslei = 0;
                                        break;
                                    }
                                    Console.WriteLine("Vida restante do Goblin: " + vidaGoblin);
                                    Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                                }
                                else if (decisao == 2)
                                {
                                    resistenciaJoeslei *= 2;
                                    Console.WriteLine("Resistência dobrada: " + resistenciaJoeslei);
                                    int pularAtaque = ran.Next(1, 11);
                                    if (pularAtaque <= 4)
                                    {
                                        Console.WriteLine("Ataque pulado!");
                                    }
                                    else
                                    {
                                        vidaJoeslei -= (danoGoblin - resistenciaJoeslei);
                                        if (danoGoblin > vidaJoeslei)
                                        {
                                            vidaJoeslei = 0;
                                            break;
                                        }
                                        Console.WriteLine("Vida restante do Goblin: " + vidaGoblin);
                                        Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                                    }
                                }
                                else if (decisao == 3)
                                {
                                    Console.WriteLine("Função indisponível");
                                }
                                else if (decisao == 4)
                                {
                                    int fugirAtaque = ran.Next(1, 101);
                                    if (fugirAtaque <= 35)
                                    {
                                        Console.WriteLine("Você conseguiu fugir do ataque!");
                                        Console.WriteLine("Reiniciando etapa");
                                        xFloresta--;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Comando inválido");
                                }
                            }
                            Console.WriteLine("Vida final do Goblin: " + vidaGoblin);
                            Console.WriteLine("Vida final do Joeslei: " + vidaJoeslei);
                        }
                        else if (inimigo <= 9)
                        {
                            Console.WriteLine("Seu inimigo é um Orc");
                            Console.WriteLine("A luta iniciará em breve");
                            await Task.Delay(2000);
                            while (vidaOrc > 0 || vidaJoeslei > 0)
                            {
                                int danoJoeslei = ran.Next(valorMinimo, valorMaximo);
                                int danoOrc = ran.Next(valorMinimoOrc, valorMaximoOrc);

                                Console.WriteLine("Você deseja: 1 - Atacar, 2 - Defender, 3 - Usar item ou 4 - Fugir");
                                int decisao = int.Parse(Console.ReadLine());
                                if (decisao == 1)
                                {
                                    int danoAtaque = ran.Next(1, 101);
                                    if (danoAtaque <= 8)
                                    {
                                        Console.WriteLine("DANO ORIGINAL: " + danoJoeslei);
                                        danoJoeslei *= 2;
                                        Console.WriteLine("DANO DOBRADO: " + danoJoeslei);
                                    }
                                    vidaOrc -= danoJoeslei;
                                    if (danoJoeslei > vidaOrc)
                                    {
                                        vidaOrc = 0;
                                        break;
                                    }
                                    vidaJoeslei -= danoOrc;
                                    if (danoOrc > vidaJoeslei)
                                    {
                                        vidaJoeslei = 0;
                                        break;
                                    }
                                    Console.WriteLine("Vida restante do Orc: " + vidaOrc);
                                    Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                                }
                                else if (decisao == 2)
                                {
                                    resistenciaJoeslei *= 2;
                                    Console.WriteLine("Resistência dobrada: " + resistenciaJoeslei);
                                    int pularAtaque = ran.Next(1, 11);
                                    if (pularAtaque <= 4)
                                    {
                                        Console.WriteLine("Ataque pulado!");
                                    }
                                    else
                                    {
                                        vidaJoeslei -= (danoOrc - resistenciaJoeslei);
                                        if (danoOrc > vidaJoeslei)
                                        {
                                            vidaJoeslei = 0;
                                            break;
                                        }
                                        Console.WriteLine("Vida restante do Orc: " + vidaOrc);
                                        Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                                    }
                                }
                                else if (decisao == 3)
                                {
                                    Console.WriteLine("Função indisponível");
                                }
                                else if (decisao == 4)
                                {
                                    int fugirAtaque = ran.Next(1, 101);
                                    if (fugirAtaque <= 35)
                                    {
                                        Console.WriteLine("Você conseguiu fugir do ataque!");
                                        Console.WriteLine("Reiniciando etapa");
                                        xFloresta--;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Comando inválido");
                                }
                            }
                            Console.WriteLine("Vida final do Orc: " + vidaOrc);
                            Console.WriteLine("Vida final do Joeslei: " + vidaJoeslei);
                        }
                        else
                        {
                            Console.WriteLine("Seu inimigo é um Troll");
                            Console.WriteLine("A luta iniciará em breve");
                            await Task.Delay(2000);
                            while (vidaTroll > 0 || vidaJoeslei > 0)
                            {
                                int danoJoeslei = ran.Next(valorMinimo, valorMaximo);
                                int danoTroll = ran.Next(valorMinimoTroll, valorMaximoTroll);

                                Console.WriteLine("Você deseja: 1 - Atacar, 2 - Defender, 3 - Usar item ou 4 - Fugir");
                                int decisao = int.Parse(Console.ReadLine());
                                if (decisao == 1)
                                {
                                    int danoAtaque = ran.Next(1, 101);
                                    if (danoAtaque <= 8)
                                    {
                                        Console.WriteLine("DANO ORIGINAL: " + danoJoeslei);
                                        danoJoeslei *= 2;
                                        Console.WriteLine("DANO DOBRADO: " + danoJoeslei);
                                    }
                                    vidaTroll -= danoJoeslei;
                                    if (danoJoeslei > vidaTroll)
                                    {
                                        vidaTroll = 0;
                                        break;
                                    }
                                    vidaJoeslei -= danoTroll;
                                    if (danoTroll > vidaJoeslei)
                                    {
                                        vidaJoeslei = 0;
                                        break;
                                    }
                                    Console.WriteLine("Vida restante do Troll: " + vidaTroll);
                                    Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                                }
                                else if (decisao == 2)
                                {
                                    resistenciaJoeslei *= 2;
                                    Console.WriteLine("Resistência dobrada: " + resistenciaJoeslei);
                                    int pularAtaque = ran.Next(1, 11);
                                    if (pularAtaque <= 4)
                                    {
                                        Console.WriteLine("Ataque pulado!");
                                    }
                                    else
                                    {
                                        vidaJoeslei -= (danoTroll - resistenciaJoeslei);
                                        if (danoTroll > vidaJoeslei)
                                        {
                                            vidaJoeslei = 0;
                                            break;
                                        }
                                        Console.WriteLine("Vida restante do Orc: " + vidaOrc);
                                        Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                                    }
                                }
                                else if (decisao == 3)
                                {
                                    Console.WriteLine("Função indisponível");
                                }
                                else if (decisao == 4)
                                {
                                    int fugirAtaque = ran.Next(1, 101);
                                    if (fugirAtaque <= 35)
                                    {
                                        Console.WriteLine("Você conseguiu fugir do ataque!");
                                        Console.WriteLine("Reiniciando etapa");
                                        xFloresta--;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Comando inválido");
                                }
                            }
                            Console.WriteLine("Vida final do Troll: " + vidaTroll);
                            Console.WriteLine("Vida final do Joeslei: " + vidaJoeslei);
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
                while (xEstrada < etapaEstrada)
                {
                    int chanceInimigo = ran.Next(1, 3);
                    if (chanceInimigo == 1)
                    {
                        Console.WriteLine("Você encontrou um inimigo na etapa: " + xEstrada);
                        int inimigo = ran.Next(1, 101);
                        if (inimigo <= 65)
                        {
                            Console.WriteLine("Seu inimigo é um Goblin");
                            Console.WriteLine("A luta iniciará em breve");
                            await Task.Delay(2000);
                            while (vidaGoblin > 0 || vidaJoeslei > 0)
                            {
                                int danoJoeslei = ran.Next(valorMinimo, valorMaximo);
                                int danoGoblin = ran.Next(valorMinimoGob, valorMaximoGob);

                                Console.WriteLine("Você deseja: 1 - Atacar, 2 - Defender, 3 - Usar item ou 4 - Fugir");
                                int decisao = int.Parse(Console.ReadLine());
                                if (decisao == 1)
                                {
                                    int danoAtaque = ran.Next(1, 101);
                                    if (danoAtaque <= 8)
                                    {
                                        Console.WriteLine("DANO ORIGINAL: " + danoJoeslei);
                                        danoJoeslei *= 2;
                                        Console.WriteLine("DANO DOBRADO: " + danoJoeslei);
                                    }
                                    vidaGoblin -= danoJoeslei;
                                    if (danoJoeslei > vidaGoblin)
                                    {
                                        vidaGoblin = 0;
                                        break;
                                    }
                                    vidaJoeslei -= danoGoblin;
                                    if (danoGoblin > vidaJoeslei)
                                    {
                                        vidaJoeslei = 0;
                                        break;
                                    }
                                    Console.WriteLine("Vida restante do Goblin: " + vidaGoblin);
                                    Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                                }
                                else if (decisao == 2)
                                {
                                    resistenciaJoeslei *= 2;
                                    Console.WriteLine("Resistência dobrada: " + resistenciaJoeslei);
                                    int pularAtaque = ran.Next(1, 11);
                                    if (pularAtaque <= 4)
                                    {
                                        Console.WriteLine("Ataque pulado!");
                                    }
                                    else
                                    {
                                        vidaJoeslei -= (danoGoblin - resistenciaJoeslei);
                                        if (danoGoblin > vidaJoeslei)
                                        {
                                            vidaJoeslei = 0;
                                            break;
                                        }
                                        Console.WriteLine("Vida restante do Goblin: " + vidaGoblin);
                                        Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                                    }
                                }
                                else if (decisao == 3)
                                {
                                    Console.WriteLine("Função indisponível");
                                }
                                else if (decisao == 4)
                                {
                                    int fugirAtaque = ran.Next(1, 101);
                                    if (fugirAtaque <= 35)
                                    {
                                        Console.WriteLine("Você conseguiu fugir do ataque!");
                                        Console.WriteLine("Reiniciando etapa");
                                        xFloresta--;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Comando inválido");
                                }
                            }
                            Console.WriteLine("Vida final do Goblin: " + vidaGoblin);
                            Console.WriteLine("Vida final do Joeslei: " + vidaJoeslei);
                        }
                        else
                        {
                            Console.WriteLine("Seu inimigo é um Orc");
                            Console.WriteLine("A luta iniciará em breve");
                            await Task.Delay(2000);
                            while (vidaOrc > 0 || vidaJoeslei > 0)
                            {
                                int danoJoeslei = ran.Next(valorMinimo, valorMaximo);
                                int danoOrc = ran.Next(valorMinimoOrc, valorMaximoOrc);

                                Console.WriteLine("Você deseja: 1 - Atacar, 2 - Defender, 3 - Usar item ou 4 - Fugir");
                                int decisao = int.Parse(Console.ReadLine());
                                if (decisao == 1)
                                {
                                    int danoAtaque = ran.Next(1, 101);
                                    if (danoAtaque <= 8)
                                    {
                                        Console.WriteLine("DANO ORIGINAL: " + danoJoeslei);
                                        danoJoeslei *= 2;
                                        Console.WriteLine("DANO DOBRADO: " + danoJoeslei);
                                    }
                                    vidaOrc -= danoJoeslei;
                                    if (danoJoeslei > vidaOrc)
                                    {
                                        vidaOrc = 0;
                                        break;
                                    }
                                    vidaJoeslei -= danoOrc;
                                    if (danoOrc > vidaJoeslei)
                                    {
                                        vidaJoeslei = 0;
                                        break;
                                    }
                                    Console.WriteLine("Vida restante do Orc: " + vidaOrc);
                                    Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                                }
                                else if (decisao == 2)
                                {
                                    resistenciaJoeslei *= 2;
                                    Console.WriteLine("Resistência dobrada: " + resistenciaJoeslei);
                                    int pularAtaque = ran.Next(1, 11);
                                    if (pularAtaque <= 4)
                                    {
                                        Console.WriteLine("Ataque pulado!");
                                    }
                                    else
                                    {
                                        vidaJoeslei -= (danoOrc - resistenciaJoeslei);
                                        if (danoOrc > vidaJoeslei)
                                        {
                                            vidaJoeslei = 0;
                                            break;
                                        }
                                        Console.WriteLine("Vida restante do Orc: " + vidaOrc);
                                        Console.WriteLine("Vida restante do Joeslei: " + vidaJoeslei);
                                    }
                                }
                                else if (decisao == 3)
                                {
                                    Console.WriteLine("Função indisponível");
                                }
                                else if (decisao == 4)
                                {
                                    int fugirAtaque = ran.Next(1, 101);
                                    if (fugirAtaque <= 35)
                                    {
                                        Console.WriteLine("Você conseguiu fugir do ataque!");
                                        Console.WriteLine("Reiniciando etapa");
                                        xFloresta--;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Comando inválido");
                                }
                            }
                            Console.WriteLine("Vida final do Orc: " + vidaOrc);
                            Console.WriteLine("Vida final do Joeslei: " + vidaJoeslei);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você não encontrou nenhum inimigo na etapa: " + xFloresta);
                    }
                    xFloresta++;
                }
            }
        }
    }
}
