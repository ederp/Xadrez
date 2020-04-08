using System;
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
            /*
            try {
                Tabuleiro tab = new Tabuleiro(8, 8);

                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(0, 0));
                tab.colocarPeca(new Torre(tab, Cor.Preta), new Posicao(1, 3));
                tab.colocarPeca(new Rei(tab, Cor.Preta), new Posicao(0, 2));

                Tela.imprimirTabuleiro(tab);

                Console.ReadLine();
            }
            catch(TabuleiroException e) {
                Console.WriteLine(e.Message);
            }

            */

            PosicaoXadrez pos = new PosicaoXadrez('a', 1);
            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());
        }
    }
}
