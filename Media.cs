using static System.Console;

class MediaNum{
    public void MediaLista()
{
    Console.WriteLine("Introduce los números separados por comas:");
        string? numerosStr = Console.ReadLine();
        if (numerosStr == null)
        {
            WriteLine("Numeros invalidos");
            return;
        }
        string?[] numeros = numerosStr.Split(',');
        int[] numerosInt = new int[numeros.Length];
         for (int i = 0; i < numeros.Length; i++)
        {
              int.TryParse(numeros[i], out numerosInt[i]);
        }
    //int[] numeros = { 10, 20, 30, 40, 50 };
    double media = numerosInt.Average();
    WriteLine("La media es: " + media);
    ReadLine();
}

}