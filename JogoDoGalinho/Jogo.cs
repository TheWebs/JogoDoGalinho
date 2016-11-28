using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDoGalinho
{
    class Jogo
    {

            private int pontosA;
            private int pontosB;
            private bool primeiro;
            private bool emJogo;
            private int x;
            private int y;
            private char[,] quadro = new char[3, 3];
            private char jogadorA = 'A';
            private char jogadorB = 'B';


            public Jogo()
            {
                x = 3;
                y = 3;
                pontosA = 0;
                pontosB = 0;
                emJogo = false;
                quadro = new char[3, 3];
            }

            public void preencheQuadro()
            {
                for (int i = 0; i < x; i++)
                {
                    for (int a = 0; a < y; a++)
                    {
                        quadro[i, a] = 'C';
                    }
                }

            }

            public void startGame()
            {
                emJogo = true;
                primeiro = true;

            }

            public void ocupaEspaco(int x, int y)
            {
                if (primeiro == true)
                {
                    quadro[x, y] = jogadorA;
                }
                else
                {
                    quadro[x, y] = jogadorB;
                }

            }

        public bool verificaOcupacao(int newX, int newY)
        {
            if(quadro[newX, newY] != 'C')
            {
                return true;
            }
            else
            {
                return false;
            }
        }


            public void print()
            {
                for (int i = 0; i < x; i++)
                {
                    for (int a = 0; a < y; a++)
                    {
                        Console.Write(quadro[i, a]);
                    }
                    Console.Write("\n");
                }
            }
            

        public char checkWin()
        {
            char currentPlayer;
            if (primeiro == true)
            {
                currentPlayer = 'B';
            }
            else
            {
                currentPlayer = 'A';
            }

            //VERTICAL
            if (quadro[0, 0] == quadro[0, 1] && quadro[0, 1] == quadro[0, 2] && quadro[0, 2] != 'C')
            {
                return currentPlayer;
            }
            else
            {
                if (quadro[1, 0] == quadro[1, 1] && quadro[1, 1] == quadro[1, 2] && quadro[1, 2] != 'C')
                {
                    return currentPlayer;
                }
                else
                {
                    if (quadro[2, 0] == quadro[2, 1] && quadro[2, 1] == quadro[2, 2] && quadro[2, 2] != 'C')
                    {
                        return currentPlayer;
                    }
                    else
                    {
                        //HORIZONTAL
                        if (quadro[0, 0] == quadro[1, 0] && quadro[1, 0] == quadro[2, 0] && quadro[2, 0] != 'C')
                        {
                            return currentPlayer;
                        }
                        else
                        {
                            if (quadro[0, 1] == quadro[1, 1] && quadro[1, 1] == quadro[2, 1] && quadro[2, 1] != 'C')
                            {
                                return currentPlayer;
                            }
                            else
                            {
                                if (quadro[0, 2] == quadro[1, 2] && quadro[1, 2] == quadro[2, 2] && quadro[2, 2] != 'C')
                                {
                                    return currentPlayer;
                                }
                                else
                                {
                                    //OBLIQUAS
                                    if (quadro[0, 0] == quadro[1, 1] && quadro[1, 1] == quadro[2, 2] && quadro[2, 2] != 'C')
                                    {
                                        return currentPlayer;
                                    }
                                    else
                                    {
                                        if (quadro[2, 0] == quadro[1, 1] && quadro[1, 1] == quadro[0, 2] && quadro[0, 2] != 'C')
                                        {
                                            return currentPlayer;
                                        }
                                        else
                                        {
                                            return 'C';
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }


        public string marca()
        {
            if(primeiro == true)
            {
                primeiro = false;
                return "X";
            }
            else
            {
                primeiro = true;
                return "O";
            }
        }




    }
}
