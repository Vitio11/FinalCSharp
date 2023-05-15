using static System.Console;
class NumerosMayormenor
{
    public void MenorMayor()
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
        //int[] numeros = { 5, 3, 8, 1, 7, 2 };
        int mayor = numerosInt[0];
        int menor = numerosInt[0];

        foreach (int numero in numerosInt)
        {
            if (numero > mayor)
            {
                mayor = numero;
            }
            if (numero < menor)
            {
                menor = numero;
            }
        }

        WriteLine("El mayor número es: " + mayor);
        WriteLine("El menor número es: " + menor);
        ReadLine();
    }
}