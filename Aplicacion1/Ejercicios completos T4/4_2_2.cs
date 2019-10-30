/*Ejercicio 4.2.2: Un programa que pida al usuario dos bloques de 6 cadenas de texto.
Después pedirá al usuario una nueva cadena y comprobará si aparece en alguno
de los dos bloques de información anteriores.*/
using System;
public class E4_2_2
{
    public static void Ejecutar()
    {
        string[,] blas = new string[2, 6];
        string busca;
        for (int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 6; j++)
            {
                Console.Write("Introduce una palabra({0}, {1}): ", i+1, j+1);
                blas[i, j] = Convert.ToString(Console.ReadLine());
            }
        }
        Console.Write("¿Que palabra buscas?: ");
        busca = Convert.ToString(Console.ReadLine());
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                if(busca == blas[i,j])
                {
                    Console.WriteLine(busca + " está entre las palabras escritas.");
                }
            }
        }
    }
}
