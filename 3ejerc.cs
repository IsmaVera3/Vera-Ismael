using System;
using System.Collections.Generic;

class MaxMin
{
    static void Main(string[] args)
    {
        Queue<int> callerIds = new Queue<int>();
        Console.WriteLine("cuantos enteros desea alojar en la cola?");
        int n = int.Parse(Console.ReadLine());
        int max = 0;
        int min = 0;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("ingrese un valor a la cola: ");
            int num = int.Parse(Console.ReadLine());
            n.Enqueue(num);
        }
    }
    

}
