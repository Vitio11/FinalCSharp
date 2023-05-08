using static System.Console;
class OrdenarLista{
        public void ordenarLista()
    { 
        Console.WriteLine("Introduce los números separados por comas:");
        string? nombresJuntos = Console.ReadLine();
        string?[] nombres = nombresJuntos.Split(',');

        Array.Sort(nombres);

        WriteLine("Lista ordenada alfabéticamente:");

        foreach (string nombre in nombres)
        {
            WriteLine(nombre);
        }
        ReadLine();
    }
}