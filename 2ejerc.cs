using System;

class SumMatrices
{
    static void Main()
    {
        List<int> matriz0 = new List<int>() 
        { 1, 2, 5,
          5, 8, 9 };
        List<int> matriz1 = new List<int>() 
        { 9, 8, 5, 
          5, 2, 1 };

        Console.Write(SumarMatrices);

    }
    static void SumarMatrices(List<int> matriz0, List<int> matriz1){
        List<int> resultado = new List<int>()
        foreach (var fila in matriz)
        {
            foreach (var elemento in fila)
            {
                resultado.Add(elemento);
            }
            Console.WriteLine("la matriz resultante es: "+ resultado);
        }

    }
}    