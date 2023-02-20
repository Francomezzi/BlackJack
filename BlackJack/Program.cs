// See https://aka.ms/new-console-template for more information
int totalJugador = 0;
int totalDealer = 0;
int num = 0;
int creditos = 0;
string message = "";
string controlOtraCarta = "";
string switchControl = "menu";
System.Random random = new System.Random();



while (true)
{
    Console.WriteLine("Bienvenido al casino");
    Console.WriteLine("Cuantos creditos quieres?\n Recuerda que necesitas 1 por juego.");
     
    creditos = Convert.ToInt32(Console.ReadLine());

    for (int i = 0; i < creditos; i++)
    {

        totalDealer = 0;
        totalJugador = 0;


        switch (switchControl)
        {
            case "menu":
                Console.WriteLine("Para jugar al blackjack escribe 21");
                switchControl = Console.ReadLine();
                i = i - 1;
                break;

            case "21":
                do
                {
                    num = random.Next(1, 12);
                    totalJugador = totalJugador + num;
                    Console.WriteLine("Toma tu  Carta jugador");
                    Console.WriteLine($"Te salio el: {num}");
                    Console.WriteLine("Deseas otra carta");
                    controlOtraCarta = Console.ReadLine();

                } while (controlOtraCarta == "Si" || controlOtraCarta == "si");

                totalDealer = random.Next(12, 23);
                Console.WriteLine($"El dealer tiene {totalDealer}");

                if (totalJugador > totalDealer && totalJugador < 22)
                { 
                    message = "Venciste al dealer, goood";
                    switchControl = "menu";

                }
                else if (totalDealer > totalJugador)
                {
                    message = "Perdiste contra el dealer, mal ahi";
                    switchControl = "menu";

                }else if (totalDealer > 22 && totalJugador <= 21)
                {
                    Console.WriteLine("Ganaste al dealer, el se paso");
                }
                else if (totalJugador > 21)
                {
                    message = "Perdiste te pasaste de 21";
                    switchControl = "menu";
                }
                else
                {
                    message = "Empataste";
                    switchControl = "menu";

                }

                Console.WriteLine(message);
                break;
            default:
                Console.WriteLine("Valor ingresado no valido");
                switchControl = "menu";
                break;
        }

    }

}