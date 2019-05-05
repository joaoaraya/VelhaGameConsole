using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            //VARIAVEIS
            int j1Cor = 0, j2Cor = 0, jogada1, jogada2, j1Wins = 0, j2Wins = 0;
            string[,] tabuleiro = new string[3, 3];
            bool ganhou = true;
            bool jogarNovamente = false;

            //LOGO PERSONALIZADO
            var logoA = new[]
            {
                @"                @@@  @@@ @@@@@@@@ @@@      @@@  @@@  @@@@@@     ",
                @"                @@!  @@@ @@!      @@!      @@!  @@@ @@!  @@@    ",
            };

            var logoB = new[]
            {
                @"                @!@  !@! @!!!:!   @!!      @!@!@!@! @!@!@!@!    ",
                @"                 !: .:!  !!:      !!:      !!:  !!! !!:  !!!    ",
                @"                   ::    : :: ::  : ::.: :  :   : :  :   : :    ",
            };

            //TROFÉU PERSONALIZADO
            var trofeu = new[]
            {
                @"               .-=========-.",
                @"               \'-=======-'/",
                @"               _|   .=.   |_",
                @"              ((|  {{1}}  |))",
                @"               \|   /|\   |/",
                @"                \__ '`' __/",
                @"                  _`) (´_",
                @"                _/_______\_",
                @"               /___________\",
            };

            //LOGO
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (string logoText in logoA) Console.WriteLine(logoText);
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            foreach (string logoText in logoB) Console.WriteLine(logoText);
            Console.WriteLine("\n");

            //ESCOLHER A COR
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\t\t  ---- JOGADOR I 'X' ESCOLHA UMA COR ----\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\t\t\t  '1' AMARELO");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\t'2' AZUL");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n\n\t\t  ---------------------------------------\n");

            //NÃO DEIXAR ESCOLHER +Q 2 OU -Q 0
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("\t\t\t DIGITE A SUA ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("ESCOLHA: ");
                j1Cor = int.Parse(Console.ReadLine());
            }
            while (j1Cor > 2 || j1Cor <= 0);

            //DEFINIÇÕES DE CORES
            if (j1Cor == 1)
            {
                j2Cor = 2;
            }
            else if (j1Cor == 2)
            {
                j2Cor = 1;
            }

            //DEFINIÇÕES DO TABULEIRO
            tabuleiro[0, 0] = "1";
            tabuleiro[0, 1] = "2";
            tabuleiro[0, 2] = "3";

            tabuleiro[1, 0] = "4";
            tabuleiro[1, 1] = "5";
            tabuleiro[1, 2] = "6";

            tabuleiro[2, 0] = "7";
            tabuleiro[2, 1] = "8";
            tabuleiro[2, 2] = "9";

            //COMEÇAR O JOGO
            Console.Clear();

            do
            {
                //LOGO DO JOGO
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Magenta;
                foreach (string logoText in logoA) Console.WriteLine(logoText);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                foreach (string logoText in logoB) Console.WriteLine(logoText);
                Console.WriteLine("\n");

                //JOGADORES (CORES E PONTOS)
                if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                Console.Write("\t\t  'X' JOGADOR I: " + j1Wins);
                if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                Console.Write("\t'O' JOGADOR II: " + j2Wins);

                //TABULEIRO 1ª PARTE
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\n\n\t\t\t      | \t    | \t\t");
                Console.Write("\t\t       ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (tabuleiro[0, 0] == "X")
                {
                    if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                if (tabuleiro[0, 0] == "O")
                {
                    if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                Console.Write(tabuleiro[0, 0]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("      |      ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (tabuleiro[0, 1] == "X")
                {
                    if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                if (tabuleiro[0, 1] == "O")
                {
                    if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                Console.Write(tabuleiro[0, 1]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("      |      ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (tabuleiro[0, 2] == "X")
                {
                    if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                if (tabuleiro[0, 2] == "O")
                {
                    if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                Console.Write(tabuleiro[0, 2]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\t\t _____________|_____________|_____________");

                //TABULEIRO 2ª PARTE
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t      | \t    | \t\t");
                Console.Write("\t\t       ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (tabuleiro[1, 0] == "X")
                {
                    if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                if (tabuleiro[1, 0] == "O")
                {
                    if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                Console.Write(tabuleiro[1, 0]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("      |      ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (tabuleiro[1, 1] == "X")
                {
                    if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                if (tabuleiro[1, 1] == "O")
                {
                    if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                Console.Write(tabuleiro[1, 1]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("      |      ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (tabuleiro[1, 2] == "X")
                {
                    if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                if (tabuleiro[1, 2] == "O")
                {
                    if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                Console.Write(tabuleiro[1, 2]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\t\t _____________|_____________|_____________");

                //TABULEIRO 3ª PARTE
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\t\t\t      | \t    | \t\t");
                Console.Write("\t\t       ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (tabuleiro[2, 0] == "X")
                {
                    if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                if (tabuleiro[2, 0] == "O")
                {
                    if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                Console.Write(tabuleiro[2, 0]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("      |      ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (tabuleiro[2, 1] == "X")
                {
                    if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                if (tabuleiro[2, 1] == "O")
                {
                    if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                Console.Write(tabuleiro[2, 1]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("      |      ");
                Console.ForegroundColor = ConsoleColor.DarkGray;
                if (tabuleiro[2, 2] == "X")
                {
                    if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                if (tabuleiro[2, 2] == "O")
                {
                    if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                }
                Console.Write(tabuleiro[2, 2]);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n\t\t\t      | \t    | \t\t");

                /*---------------------------------------------------------------------------------------*/
                /*---------------------------------  JOGADOR I 'X'  -----------------------------------*/
                /*---------------------------------------------------------------------------------------*/
                try
                {
                    //JOGADAS (RESET)
                    if (jogarNovamente == true)
                    {
                        //*----TELA DE VENCEU----*//
                        Console.Clear();
                        //LOGO DO JOGO 
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        foreach (string logoText in logoA) Console.WriteLine(logoText);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        foreach (string logoText in logoB) Console.WriteLine(logoText);

                        //TROFEU
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (string logoText in trofeu) Console.WriteLine("\t\t" + logoText);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\n\t\t\t--- JOGADOR II 'O' GANHOU ---");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("\n\t\t   pressione qualqer tecla para continuar ");

                        Console.ReadKey();
                        Console.Clear();

                        //*----REDESENHAR TUDO----*//
                        //LOGO DO JOGO
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        foreach (string logoText in logoA) Console.WriteLine(logoText);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        foreach (string logoText in logoB) Console.WriteLine(logoText);
                        Console.WriteLine("\n");

                        //JOGADORES (CORES E PONTOS)
                        if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        Console.Write("\t\t  'X' JOGADOR I: " + j1Wins);
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        Console.Write("\t'O' JOGADOR II: " + j2Wins);

                        //REDEFINIR O TABULEIRO
                        tabuleiro[0, 0] = "1"; tabuleiro[0, 1] = "2"; tabuleiro[0, 2] = "3";
                        tabuleiro[1, 0] = "4"; tabuleiro[1, 1] = "5"; tabuleiro[1, 2] = "6";
                        tabuleiro[2, 0] = "7"; tabuleiro[2, 1] = "8"; tabuleiro[2, 2] = "9";

                        //TABULEIRO 1ª PARTE
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\n\n\t\t\t      | \t    | \t\t");
                        Console.Write("\t\t       ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[0, 0] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[0, 0] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[0, 0]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[0, 1] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[0, 1] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[0, 1]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[0, 2] == "X")
                        {
                            if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[0, 2] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[0, 2]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t _____________|_____________|_____________");

                        //TABULEIRO 2ª PARTE
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\t\t\t      | \t    | \t\t");
                        Console.Write("\t\t       ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[1, 0] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[1, 0] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[1, 0]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[1, 1] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[1, 1] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[1, 1]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[1, 2] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[1, 2] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[1, 2]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t _____________|_____________|_____________");

                        //TABULEIRO 3ª PARTE
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\t\t\t      | \t    | \t\t");
                        Console.Write("\t\t       ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[2, 0] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[2, 0] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[2, 0]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[2, 1] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[2, 1] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[2, 1]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[2, 2] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[2, 2] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[2, 2]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t\t      | \t    | \t\t");

                        jogarNovamente = false;
                    }

                    //JOGADAS
                    Console.Write("\n\n\t\t    --- 'X' JOGADOR I ------------------");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n\n\t\t\t    DIGITE A SUA ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("POSIÇÃO: ");
                    jogada1 = int.Parse(Console.ReadLine());

                    //PARTE SUPERIOR DO TABULEIRO: jogador I "X".
                    if (jogada1 == 1)
                    {
                        tabuleiro[0, 0] = "X";
                    }
                    else if (jogada1 == 2)
                    {
                        tabuleiro[0, 1] = "X";
                    }
                    else if (jogada1 == 3)
                    {
                        tabuleiro[0, 2] = "X";
                    }

                    //PARTE CENTRAL DO TABULEIRO: jogador I "X".
                    else if (jogada1 == 4)
                    {
                        tabuleiro[1, 0] = "X";
                    }
                    else if (jogada1 == 5)
                    {
                        tabuleiro[1, 1] = "X";
                    }
                    else if (jogada1 == 6)
                    {
                        tabuleiro[1, 2] = "X";
                    }

                    //PARTE INFERIO DO TABULEIRO: jogador I "X".
                    else if (jogada1 == 7)
                    {
                        tabuleiro[2, 0] = "X";
                    }
                    else if (jogada1 == 8)
                    {
                        tabuleiro[2, 1] = "X";
                    }
                    else if (jogada1 == 9)
                    {
                        tabuleiro[2, 2] = "X";
                    }

                    //REDEFINIR VALORES
                    Console.Clear();


                    //PRIMEIRA PARTE DO TABULEIRO - REAPARECER TABULEIRO

                    //LOGO DO JOGO
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    foreach (string logoText in logoA) Console.WriteLine(logoText);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    foreach (string logoText in logoB) Console.WriteLine(logoText);
                    Console.WriteLine("\n");

                    //JOGADORES (CORES E PONTOS)
                    if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    Console.Write("\t\t  'X' JOGADOR I: " + j1Wins);
                    if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                    else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    Console.Write("\t'O' JOGADOR II: " + j2Wins);

                    //TABULEIRO 1ª PARTE
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\n\n\t\t\t      | \t    | \t\t");
                    Console.Write("\t\t       ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    if (tabuleiro[0, 0] == "X")
                    {
                        if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    if (tabuleiro[0, 0] == "O")
                    {
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    Console.Write(tabuleiro[0, 0]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("      |      ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    if (tabuleiro[0, 1] == "X")
                    {
                        if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    if (tabuleiro[0, 1] == "O")
                    {
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    Console.Write(tabuleiro[0, 1]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("      |      ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    if (tabuleiro[0, 2] == "X")
                    {
                        if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    if (tabuleiro[0, 2] == "O")
                    {
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    Console.Write(tabuleiro[0, 2]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t\t _____________|_____________|_____________");

                    //TABULEIRO 2ª PARTE
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t      | \t    | \t\t");
                    Console.Write("\t\t       ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    if (tabuleiro[1, 0] == "X")
                    {
                        if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    if (tabuleiro[1, 0] == "O")
                    {
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    Console.Write(tabuleiro[1, 0]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("      |      ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    if (tabuleiro[1, 1] == "X")
                    {
                        if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    if (tabuleiro[1, 1] == "O")
                    {
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    Console.Write(tabuleiro[1, 1]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("      |      ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    if (tabuleiro[1, 2] == "X")
                    {
                        if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    if (tabuleiro[1, 2] == "O")
                    {
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    Console.Write(tabuleiro[1, 2]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t\t _____________|_____________|_____________");

                    //TABULEIRO 3ª PARTE
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\t\t\t      | \t    | \t\t");
                    Console.Write("\t\t       ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    if (tabuleiro[2, 0] == "X")
                    {
                        if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    if (tabuleiro[2, 0] == "O")
                    {
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    Console.Write(tabuleiro[2, 0]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("      |      ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    if (tabuleiro[2, 1] == "X")
                    {
                        if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    if (tabuleiro[2, 1] == "O")
                    {
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    Console.Write(tabuleiro[2, 1]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("      |      ");
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    if (tabuleiro[2, 2] == "X")
                    {
                        if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    if (tabuleiro[2, 2] == "O")
                    {
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                    }
                    Console.Write(tabuleiro[2, 2]);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n\t\t\t      | \t    | \t\t");

                    /*---------------------------------------------------------------------------------------*/
                    /*---------------------------------  POSSIBILIDADES  ------------------------------------*/
                    /*---------------------------------------------------------------------------------------*/

                    //POSSIBILIDADES DE GANHAR X - HORIZONTAL
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[0, 1] == "X") && (tabuleiro[0, 2] == "X"))
                    {
                        Console.Clear();
                        j1Wins += 1;
                        jogarNovamente = true;
                    }
                    else if ((tabuleiro[1, 0] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[1, 2] == "X"))
                    {
                        Console.Clear();
                        j1Wins += 1;
                        jogarNovamente = true;
                    }
                    else if ((tabuleiro[2, 0] == "X") && (tabuleiro[2, 1] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        Console.Clear();
                        j1Wins += 1;
                        jogarNovamente = true;
                    }

                    //POSSIBLIDADES DE GANHAR X - VERTICAL
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[1, 0] == "X") && (tabuleiro[2, 0] == "X"))
                    {
                        Console.Clear();
                        j1Wins += 1;
                        jogarNovamente = true;
                    }
                    else if ((tabuleiro[0, 1] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 1] == "X"))
                    {
                        Console.Clear();
                        j1Wins += 1;
                        jogarNovamente = true;
                    }
                    else if ((tabuleiro[0, 2] == "X") && (tabuleiro[1, 2] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        Console.Clear();
                        j1Wins += 1;
                        jogarNovamente = true;
                    }

                    //POSSIBLIDADES DE GANHAR X - DIAGONAL
                    if ((tabuleiro[0, 0] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 2] == "X"))
                    {
                        Console.Clear();
                        j1Wins += 1;
                        jogarNovamente = true;
                    }
                    else if ((tabuleiro[0, 2] == "X") && (tabuleiro[1, 1] == "X") && (tabuleiro[2, 0] == "X"))
                    {
                        Console.Clear();
                        j1Wins += 1;
                        jogarNovamente = true;
                    }


                    /*---------------------------------------------------------------------------------------*/
                    /*---------------------------------  JOGADOR II 'O'  ------------------------------------*/
                    /*---------------------------------------------------------------------------------------*/

                    //JOGADAS (RESET)
                    if (jogarNovamente == true)
                    {
                        //*----TELA DE VENCEU----*//
                        Console.Clear();
                        //LOGO DO JOGO 
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        foreach (string logoText in logoA) Console.WriteLine(logoText);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        foreach (string logoText in logoB) Console.WriteLine(logoText);

                        //TROFEU
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        foreach (string logoText in trofeu) Console.WriteLine("\t\t" + logoText);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\n\t\t\t--- JOGADOR I 'X' GANHOU ---");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("\n\t\t   pressione qualqer tecla para continuar ");

                        Console.ReadKey();
                        Console.Clear();

                        //*----REDESENHAR TUDO----*//
                        //LOGO DO JOGO
                        Console.WriteLine("\n");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        foreach (string logoText in logoA) Console.WriteLine(logoText);
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        foreach (string logoText in logoB) Console.WriteLine(logoText);
                        Console.WriteLine("\n");

                        //JOGADORES (CORES E PONTOS)
                        if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        Console.Write("\t\t  'X' JOGADOR I: " + j1Wins);
                        if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                        else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        Console.Write("\t'O' JOGADOR II: " + j2Wins);

                        //REDEFINIR O TABULEIRO
                        tabuleiro[0, 0] = "1"; tabuleiro[0, 1] = "2"; tabuleiro[0, 2] = "3";
                        tabuleiro[1, 0] = "4"; tabuleiro[1, 1] = "5"; tabuleiro[1, 2] = "6";
                        tabuleiro[2, 0] = "7"; tabuleiro[2, 1] = "8"; tabuleiro[2, 2] = "9";

                        //TABULEIRO 1ª PARTE
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\n\n\t\t\t      | \t    | \t\t");
                        Console.Write("\t\t       ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[0, 0] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[0, 0] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[0, 0]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[0, 1] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[0, 1] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[0, 1]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[0, 2] == "X")
                        {
                            if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[0, 2] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[0, 2]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t _____________|_____________|_____________");

                        //TABULEIRO 2ª PARTE
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\t\t\t      | \t    | \t\t");
                        Console.Write("\t\t       ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[1, 0] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[1, 0] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[1, 0]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[1, 1] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[1, 1] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[1, 1]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[1, 2] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[1, 2] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[1, 2]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t _____________|_____________|_____________");

                        //TABULEIRO 3ª PARTE
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\t\t\t      | \t    | \t\t");
                        Console.Write("\t\t       ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[2, 0] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[2, 0] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[2, 0]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[2, 1] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[2, 1] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[2, 1]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("      |      ");
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        if (tabuleiro[2, 2] == "X")
                        {
                            if (j1Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j1Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        if (tabuleiro[2, 2] == "O")
                        {
                            if (j2Cor == 1) { Console.ForegroundColor = ConsoleColor.Yellow; }
                            else if (j2Cor == 2) { Console.ForegroundColor = ConsoleColor.DarkCyan; }
                        }
                        Console.Write(tabuleiro[2, 2]);
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n\t\t\t      | \t    | \t\t");

                        jogarNovamente = false;
                    }

                    //JOGADAS
                    Console.Write("\n\n\t\t    --- 'O' JOGADOR II -----------------");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n\n\t\t\t    DIGITE A SUA ");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("POSIÇÃO: ");
                    jogada2 = int.Parse(Console.ReadLine());

                    //PARTE SUPERIOR DO TABULEIR - jogador 2 "O".

                    if (jogada2 == 1)
                    {
                        tabuleiro[0, 0] = "O";
                    }
                    else if (jogada2 == 2)
                    {
                        tabuleiro[0, 1] = "O";
                    }
                    else if (jogada2 == 3)
                    {
                        tabuleiro[0, 2] = "O";
                    }

                    //PARTE CENTRAL DO TABULEIRO - jogador 2 "O".
                    else if (jogada2 == 4)
                    {
                        tabuleiro[1, 0] = "O";
                    }
                    else if (jogada2 == 5)
                    {
                        tabuleiro[1, 1] = "O";
                    }
                    else if (jogada2 == 6)
                    {
                        tabuleiro[1, 2] = "O";
                    }

                    //PARTE INFERIO DO TABULEIRO - jogador 2 "O".
                    else if (jogada2 == 7)
                    {
                        tabuleiro[2, 0] = "O";
                    }
                    else if (jogada2 == 8)
                    {
                        tabuleiro[2, 1] = "O";
                    }
                    else if (jogada2 == 9)
                    {
                        tabuleiro[2, 2] = "O";
                    }
                    else
                    {
                        Console.WriteLine("\n\t\tApenas os numeros que contem no tabuleiro");
                    }

                    //POSSIBILIDADES DE GANHAR O - HORIZONTAL
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[0, 1] == "O") && (tabuleiro[0, 2] == "O"))
                    {
                        Console.Clear();
                        j2Wins += 1;
                        jogarNovamente = true;
                    }
                    else if ((tabuleiro[1, 0] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[1, 2] == "O"))
                    {
                        Console.Clear();
                        j2Wins += 1;
                        jogarNovamente = true;
                    }
                    else if ((tabuleiro[2, 0] == "O") && (tabuleiro[2, 1] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        Console.Clear();
                        j2Wins += 1;
                        jogarNovamente = true;
                    }

                    //POSSIBLIDADES DE GANHAR O - VERTICAL
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[1, 0] == "O") && (tabuleiro[2, 0] == "O"))
                    {
                        Console.Clear();
                        j2Wins += 1;
                        jogarNovamente = true;
                    }
                    else if ((tabuleiro[0, 1] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 1] == "OX"))
                    {
                        Console.Clear();
                        j2Wins += 1;
                        jogarNovamente = true;
                    }
                    else if ((tabuleiro[0, 2] == "O") && (tabuleiro[1, 2] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        Console.Clear();
                        j2Wins += 1;
                        jogarNovamente = true;
                    }

                    //POSSIBLIDADES DE GANHAR O - DIAGONAL
                    if ((tabuleiro[0, 0] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 2] == "O"))
                    {
                        Console.Clear();
                        j2Wins += 1;
                        jogarNovamente = true;
                    }
                    else if ((tabuleiro[0, 2] == "O") && (tabuleiro[1, 1] == "O") && (tabuleiro[2, 0] == "O"))
                    {
                        Console.Clear();
                        j2Wins += 1;
                        jogarNovamente = true;
                    }

                    Console.Clear();

                }
                catch (Exception)
                {
                    //SE ERRAR
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    foreach (string logoText in logoA) Console.WriteLine(logoText);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    foreach (string logoText in logoB) Console.WriteLine(logoText);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n\n\t\t      ----  PRESTE MAIS ATENÇÃO  ----\n");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\n\t\tDIGITE APENAS OS NºS QUE ESTÃO NO TABULEIRO");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (ganhou);
        }
    }
}
