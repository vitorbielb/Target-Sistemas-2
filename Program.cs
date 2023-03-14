using System;

class Program
{
    static void Main(string[] args)
    {
        string original = " 1 2 3 4 5 ";

        string invertida = "";

        for (int i = original.Length - 1; i >= 0; i--)
        {
            invertida += original[i];
        }

        Console.WriteLine(invertida);
    }
}