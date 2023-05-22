using System;

class TareaEstructura
{
    static void Main(string[] args)
    {
        int[] PrimerArreglo = new int[3];
        int[] SegundoArreglo = new int[3];
        Console.WriteLine("Ingrese los números del primer arreglo");
        for (int i = 0; i < 3; i++)
        {
            Console.Write("Número {0}: ", i + 1);
            PrimerArreglo[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Llenar el segundo arreglo
        Console.WriteLine("\nIngrese los números para el segundo arreglo:");

        for (int i = 0; i < 3; i++)
        {
            Console.Write("Número {0}: ", i + 1);
            SegundoArreglo[i] = Convert.ToInt32(Console.ReadLine());
        }
        int[] ArregloFinal = new int[6];
        PrimerArreglo.CopyTo(ArregloFinal, 0);
        SegundoArreglo.CopyTo(ArregloFinal, PrimerArreglo.Length);
        Array.Sort(ArregloFinal);
        Console.WriteLine("El arreglo final da como resultado: ");
        ImprimirResultado(ArregloFinal);
        Console.ReadLine();


    }
    static void ImprimirResultado(int[] Arreglo)
    {
        foreach (int numero in Arreglo) 
        {
            Console.Write("{0} ", numero);
        }
    }
  }           
