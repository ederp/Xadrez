﻿using System;
using tabuleiro;
using xadrez;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {
            /*
            Posicao p;

            p = new Posicao(3,4);

            Console.WriteLine("Posição: "+p);
            Console.ReadLine();
            */
            
            try {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (! partida.terminada) {
                    try {
                        Console.Clear();
                        Tela.imprimirPartida(partida);

                        Console.WriteLine();
                        Console.Write("Origem: ");
                        Posicao origem = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeOrigem(origem);

                        bool[,] posicoesPossiveis = partida.tab.peca(origem).movimentosPossiveis();


                        Console.Clear();
                        Tela.imprimirTabuleiro(partida.tab, posicoesPossiveis);

                        Console.WriteLine();
                        Console.Write("Destino: ");
                        Posicao destino = Tela.lerPosicaoXadrez().toPosicao();
                        partida.validarPosicaoDeDestino(origem, destino);
                        

                        partida.realizaJogada(origem, destino);
                    }
                    catch (TabuleiroException e) {
                        Console.WriteLine(e.Message);
                        Console.ReadLine();
                    }

                }
                
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
            /*
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
            */
        }
    }
}
