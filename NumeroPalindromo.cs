using static System.Console;
class NumerosPalindromo{
    public void palindromo()
    {
        Write("Ingrese una palabra o frase: ");
        string? texto = ReadLine();
        if (texto == null)
        {
            Write("Texto invalido");
            return;
        }
        texto = texto.ToLower().Replace(" ", "");
        bool palindromo = true;
        for (int i = 0; i < texto.Length / 2; i++)
        {
            if (texto[i] != texto[texto.Length - 1 - i])
            {
                palindromo = false;
                break;
            }
        }

        if (palindromo)
        {
            WriteLine("La cadena es un palíndromo");
        }
        else
        {
            WriteLine("La cadena no es un palíndromo");
        }
    ReadLine();
    }
}