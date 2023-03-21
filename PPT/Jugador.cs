using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT {
    internal class Jugador {
        public Jugador() { }
        public Jugador(Elemento e){
            this.El = e;
        }
        public Elemento El { get; set; }
    }
}
