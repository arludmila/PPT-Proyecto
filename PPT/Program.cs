// See https://aka.ms/new-console-template for more information
using PPT;
public class Program {
    static Jugador getEleccion(string str){
        switch (Convert.ToInt32(str)){
            case 1:
                return new Jugador(new Piedra());
            case 2:
                return new Jugador(new Papel());
            case 3:
                return new Jugador(new Tijera());
            default:
                return new Jugador();
        }
    }
    static void Main(string[] args)
    {
        Elemento[] array = { new Piedra(), new Papel(), new Tijera() };
        Elemento eleccionComputadora = array[new Random().Next(0, array.Length)];
        Console.WriteLine("Ingrese el numero correspondiente a la opcion que desea: " +
            "\n1 - PIEDRA\n2 - PAPEL\n3 - TIJERA");
        Jugador jugador = getEleccion(Console.ReadLine());
        Console.WriteLine("Eleccion del Jugador: "+jugador.El.Tipo);
        Console.WriteLine("Eleccion de la Computadora: "+eleccionComputadora.Tipo);
        string resultado = jugador.El.GanaContra(eleccionComputadora);
        Console.WriteLine("---------------------");
        if (resultado.Contains("perdio")){
            Console.WriteLine("Perdiste!");
        }
        else if (resultado.Contains("gano")){
            Console.WriteLine("Ganaste!");
        }
        else{
            Console.WriteLine("Empataron!");
        }
        Console.WriteLine(resultado);

    }
}

