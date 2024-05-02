using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SituacaoProblemaMatematicaPontos.Entities {
    internal class CalculadoraCartesiana {

        public static double distanciaPontos(Pontos x, Pontos y) {

            if (x != null && y != null) {
                double primeiraParte = (x.x - y.x)*(x.x-y.x); //(Xx - Xy)²
                double segundaParte = (x.y - y.y)*(x.y-y.y); //(Yx - Yy)²
                double distancia = Math.Sqrt((primeiraParte + segundaParte));

                return distancia;
            }

            return 0;
        }

        public static string alinhamentoPontos(Pontos a, Pontos b, Pontos c) {

            if (a != null && b != null && c!= null) {

                int diagonalPrincipal = (a.x * b.y) + (a.y * c.y) + (b.x * c.y);
                int diagonalSecundaria = (b.y * c.x) + (a.x * c.y) + (a.y * b.y);

                int determinante = diagonalPrincipal - diagonalSecundaria;

                if (determinante == 0) {
                    return "Alinhados";
                }else return "Não alinhados";

            }

            return "Pontos vazios encontrados!";
        }

    }
}
