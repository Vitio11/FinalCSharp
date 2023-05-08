using static System.Console;

class Elidupli{
    public void EliminarDuplicados()
    {
        Console.WriteLine("Introduce los números separados por comas:");
            string? numerosStr = Console.ReadLine();
            string?[] numeros = numerosStr.Split(',');
            int[] numerosInt = new int[numeros.Length];
            for (int i = 0; i < numeros.Length; i++)
            {
                numerosInt[i] = int.Parse(numeros[i]);
            }
        //List<int> numeros = new List<int>() { 10, 20, 30, 20, 50 };

        List<int> numerosSinDuplicados = new List<int>();

        foreach (int numero in numerosInt)
        {
            if (!numerosSinDuplicados.Contains(numero))
            {
                numerosSinDuplicados.Add(numero);
            }
        }

        WriteLine("Números originales: " + string.Join(", ", numeros));
        WriteLine("Números depurados: " + string.Join(", ", numerosSinDuplicados));
        ReadLine();

    }
}