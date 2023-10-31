
using System;
using System.Collections.Generic;

class Filtro
{
    static void Main(string[] args)
    {
        Console.WriteLine("escriba la cantidad de cadenas que se desea alojar en una pila");
        int cantidadCadenas = int.Parse(Console.ReadLine());
        Stack<string> pila = new Stack<string>();
        for (int i = 0; i < cantidadCadenas; i++)
        {
            Console.WriteLine("Escriba la cadena que ira dentro de la pila");
            string cadena = Console.ReadLine();
            pila.Push(cadena);
        }
    
    }
    static int FiltrarConsonantesEnPila(Stack<string> pila)
    {
        int totalConsonantes = 0;
        string consonantes = "abcdfghjklmnñpqrstvwxyz";

        foreach (string cadena in pila)
        {
            foreach (char letra in cadena)
            {
                if (consonantes.Contains((letra)))
                {
                    totalConsonantes++;
                }
            }
        }
        return totalConsonantes;
    }
}
