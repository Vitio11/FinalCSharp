using static System.Console;

class MediaNum{
    public void MediaLista()
{
    Console.WriteLine("Introduce los números separados por comas:");
        string? numerosStr = Console.ReadLine();
        string?[] numeros = numerosStr.Split(',');
        int[] numerosInt = new int[numeros.Length];
         for (int i = 0; i < numeros.Length; i++)
        {
            numerosInt[i] = int.Parse(numeros[i]);
        }
    //int[] numeros = { 10, 20, 30, 40, 50 };
    double media = numerosInt.Average();
    WriteLine("La media es: " + media);
    ReadLine();
}

}