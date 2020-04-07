using System;
using tabuleiro;

namespace Xadrez {
    class Program {
        static void Main(string[] args) {
            /*
            Posicao p;

            p = new Posicao(3,4);

            Console.WriteLine("Posição: "+p);
            Console.ReadLine();
            */

            Tabuleiro tab = new Tabuleiro(8, 8);

            Tela.imprimirTabuleiro(tab);

            Console.ReadLine();
        }
    }
}
