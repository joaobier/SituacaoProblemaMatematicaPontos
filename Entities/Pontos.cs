using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SituacaoProblemaMatematicaPontos.Entities {
    internal class Pontos {

        public int x { get; set; }
        public int y { get; set; }

        public Pontos(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public string apresentarPonto() {
            return " X: " + this.x + " Y: " + this.y;
        }

    }
}
