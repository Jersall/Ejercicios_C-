/*Ejercicio 4.4.5.1: Un programa que pida al usuario 10 frases, las guarde en un array, y
luego le pregunte textos de forma repetitiva, e indique si cada uno de esos textos
aparece como parte de alguno de los elementos del array. Terminará cuando el
texto introducido sea "fin"*/
using System;
public class E4_4_5_1
{
    public static void Ejecutar()
    {
        string[] frases = new string[10];
        for(int i = 0; i < 10; i++)
        {
            Console.Write("¿Frase {0}): ", i + 1);
            frases[i] = Convert.ToString(Console.ReadLine());
        }
        Console.Clear();
        Console.WriteLine("Array de frases completo, continuando...");
        string busqueda = "";
        do
        {
            Console.Write("¿Fragmento a buscar?: ");
            busqueda = Convert.ToString(Console.ReadLine());
            for(int j = 0; j < 10; j++)
            {
                if(frases[j].Contains(busqueda))
                {
                    Console.WriteLine(" \"" + busqueda + "\" figura en la frase \""+ frases[j] + "\"");
                }
            }
        }
        while (busqueda != "fin");

    }
}