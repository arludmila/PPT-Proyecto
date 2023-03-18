using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPT {
    public class Elemento {
        public Elemento(string tipo)
        {
            Tipo = tipo;
        }

        public string Tipo { get; set; }
        public string GanaContra(Elemento e){
            if (this.Tipo.Equals(e.Tipo)){
                Debug.WriteLine(this.Tipo + " empato contra " + e.Tipo);
                return this.Tipo + " empato contra " + e.Tipo;
            }
            else if((this.Tipo.Equals("Tijera") && e.Tipo.Equals("Piedra"))||
                (this.Tipo.Equals("Papel") && e.Tipo.Equals("Tijera"))||
                this.Tipo.Equals("Piedra") && e.Tipo.Equals("Papel")){
                return this.Tipo + " perdio contra " + e.Tipo;
            }
            else{
                return this.Tipo + " gano contra " + e.Tipo;
            }
        }

    }
}
