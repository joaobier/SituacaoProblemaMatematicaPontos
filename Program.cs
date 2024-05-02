
using SituacaoProblemaMatematicaPontos.Entities;

namespace SituacaoProblemaMatematicaPontos // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            char response = 'Y';

            do {
                int x, y;

                Console.WriteLine("Olá, eu calculo se 3 pontos estão alinhados e a distância entre eles em um plano cartesiano");

                Console.WriteLine("Informe o ponto A");
                Console.Write("X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                y = int.Parse(Console.ReadLine());
                Pontos pontoA = new Pontos(x, y);


                Console.WriteLine("Informe o ponto B");
                Console.Write("X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                y = int.Parse(Console.ReadLine());
                Pontos pontoB = new Pontos(x, y);

                Console.WriteLine("Informe o ponto C");
                Console.Write("X: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Y: ");
                y = int.Parse(Console.ReadLine());
                Pontos pontoC = new Pontos(x, y);

                Console.WriteLine("Pontos a serem operados");
                Console.WriteLine("Ponto A, Coordenadas  " + pontoA.apresentarPonto());
                Console.WriteLine("Ponto B, Coordenadas  " + pontoB.apresentarPonto());
                Console.WriteLine("Ponto C, Coordenadas  " + pontoC.apresentarPonto());

                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("Os pontos estão: " + CalculadoraCartesiana.alinhamentoPontos(pontoA, pontoB, pontoC));
                if (string.Equals(CalculadoraCartesiana.alinhamentoPontos(pontoA, pontoB, pontoC), "Alinhados")) {
                    Console.WriteLine("Distância de entre A e B: " + CalculadoraCartesiana.distanciaPontos(pontoA, pontoB));
                    Console.WriteLine("Distância de entre B e C: " + CalculadoraCartesiana.distanciaPontos(pontoB, pontoC));
                    Console.WriteLine("Distância de entre C e A: " + CalculadoraCartesiana.distanciaPontos(pontoC, pontoA));
                }
                Console.WriteLine("----------------------------------------------------------------");

                Console.WriteLine("Deseja trabalhar com outros pontos? (Y/N)");
                response = char.Parse(Console.ReadLine());

            } while (response == 'Y' || response == 'y');
        }
    }
}