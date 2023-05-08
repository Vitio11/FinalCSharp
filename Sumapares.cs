using static System.Console;
class SumaPares{
        public void SumaNumerosPares()
    {
        Console.WriteLine("Introduce los números separados por comas:");
            string? numerosStr = Console.ReadLine();
            string?[] numeros = numerosStr.Split(',');
            int[] numerosInt = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                numerosInt[i] = int.Parse(numeros[i]);
            }
    // List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int suma = 0;

        foreach (int num in numerosInt)
        {
            if (num % 2 == 0)
                suma += num;
        }

        WriteLine("La suma de los números pares es {0}", suma);

        ReadKey();
    }

}