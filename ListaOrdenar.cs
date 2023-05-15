using static System.Console;
class OrdenarLista{
        public void ordenarLista()
    { 
        Console.WriteLine("Introduce los números separados por comas:");
        string? nombresJuntos ;
        nombresJuntos= Console.ReadLine();
        string?[] nombres;
        nombres= nombresJuntos!.Split(',');

        if (nombres == null || nombresJuntos==null)
            {
                WriteLine("Numeros invalidos");
                return;
            }
            
        Array.Sort(nombres);

        WriteLine("Lista ordenada alfabéticamente:");

        foreach (string? nombre in nombres)
        {
            WriteLine(nombre);
        }
        ReadLine();
    }
}