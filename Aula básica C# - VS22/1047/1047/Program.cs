using System;
using System.Globalization;

namespace uri1045
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int minutoInicial = int.Parse(valores[1]);
            int horaFinal = int.Parse(valores[2]);
            int minutoFinal = int.Parse(valores[3]);

            int instanciaInicial = horaInicial * 60 + minutoInicial;
            int instanciaFinal = horaFinal * 60 + minutoFinal;

            int duracao;
            if (instanciaInicial < instanciaFinal)
            {
                duracao = instanciaFinal - instanciaInicial;
            }
            else
            {
                duracao = (24 * 60 - instanciaInicial) + instanciaFinal;
            }

            int duracaoHoras = duracao / 60;
            int duracaoMinutos = duracao % 60;

            Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
 
        }
    }
}
