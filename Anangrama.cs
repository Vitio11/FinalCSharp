using static System.Console;

class Anagra{
    public void Anagrama()
{   WriteLine("Introduce la primer palabra");
    string palabra1 = Console.ReadLine();
    WriteLine("Introduce la segunda palabra");
    string palabra2 = Console.ReadLine();

    char[] letras1 = palabra1.ToLower().ToCharArray();
    char[] letras2 = palabra2.ToLower().ToCharArray();

    Array.Sort(letras1);
    Array.Sort(letras2);

    bool sonAnagramas = letras1.SequenceEqual(letras2);

    if (sonAnagramas)
    {
        WriteLine(palabra1 + " y " + palabra2 + " son anagramas.");
    }
    else
    {
        WriteLine(palabra1 + " y " + palabra2 + " no son anagramas.");
    }
     ReadLine();
}

}