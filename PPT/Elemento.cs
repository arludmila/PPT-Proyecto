using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT {
    public class Elemento {
        public Elemento(){}
        public string Tipo { get; set; }
        public string GanaContra(Elemento e){
            if (this.Tipo.Equals(e.Tipo)){
                return "Empate!";
            }
            else if((this.Tipo.Equals("Tijera") && e.Tipo.Equals("Piedra"))||
                (this.Tipo.Equals("Papel") && e.Tipo.Equals("Tijera"))||
                this.Tipo.Equals("Piedra") && e.Tipo.Equals("Papel")){
                return "Pierde!";
            }
            else{
                return "Gano!";
            }
        }

    }
}
