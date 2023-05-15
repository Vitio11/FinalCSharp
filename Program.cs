using static System.Console;
using static System.Math;
//using System.Linq; //hace falta?



bool salir = false;
while (!salir) {
try
{
        
    Console.WriteLine("1. Obtener el numero mayor y menor de una lista");
    Console.WriteLine("2. Saber si un numero es par o impar");
    Console.WriteLine("3. Averiguar si un año es bisiesto");
    Console.WriteLine("4. Saber si una cadena es un palindromo");
    Console.WriteLine("5. Ordenar una lista de nombres");
    Console.WriteLine("6. Calcular el factorial de un numero");
    Console.WriteLine("7. Saber si un numero es primo");
    Console.WriteLine("8. Calcular el Área y el volumen de un cubo");
    Console.WriteLine("9. Sumar los numeros pares de una lista");
    Console.WriteLine("10.Saber si un numero es positivo negativo o cero ");
    Console.WriteLine("11. Calcular la media de una lista ");
    Console.WriteLine("12. Juego: Adivina el numero entre 0 y 100 ");
    Console.WriteLine("13. Saber si dos cadenas son anagramas");
    Console.WriteLine("14. Eliminar numeros duplicados en una lista ");
    Console.WriteLine("15. Saber si un numero es capicua ");
    Console.WriteLine("0. Salir");
    Console.WriteLine("Elige una de las opciones");
    int opcion = Convert.ToInt32(Console.ReadLine());


    switch (opcion)
    {
        case 1:
            
            var miMenorMayor = new NumerosMayormenor();
            miMenorMayor.MenorMayor();
            break;

        case 2:
            var miParImpar = new Numerosparesimpar();
            miParImpar.ParImpar();
            break;
           
        case 3:
            var miAnio = new bisiesto();
            miAnio.AnyoBisiesto();
            break;
        case 4:
            var miPalindroque = new NumerosPalindromo();
            miPalindroque.palindromo();
            break;
        case 5:
            var miListaOrd = new OrdenarLista();
            miListaOrd.ordenarLista();
            break;
        case 6:
            var miFact = new FactorialNum();
            miFact.factorial();
            break;
        case 7:
            var miPrim = new NumPrimo();
            miPrim.NumeroPrimo();
            break;
        case 8:
            var miCubo = new volCubo();
            miCubo.AreaVolumenCubo();
            break;
        case 9:
            var miPar = new SumaPares();
            miPar.SumaNumerosPares();
            break;
        case 10:
            var miposinega= new PosiNega();
            miposinega.NumeroPositivoNegativoCero();
            break;
        case 11:
            var mimed = new MediaNum();
            mimed.MediaLista();
            break;
        case 12:
            var miJuego= new AdivinaNum();
            miJuego.AdivinarNumero();
            break;
        case 13:
            var miana= new Anagra();
            miana.Anagrama();
            break;
        case 14:
            var midupli= new Elidupli();
            midupli.EliminarDuplicados();
            break;
        case 15:
            var micapi= new Capi();
            micapi.Capicua();
            break;
        case 0:
            Console.WriteLine("Has elegido salir de la aplicación");
            salir = true;
            break;
        default:
            Console.WriteLine("Elige una opcion entre 1 y 15");
            break;
    }

}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}
}

Console.ReadLine();