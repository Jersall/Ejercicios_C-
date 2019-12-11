/*
 * Ejercicio 4.4.5.1: Un programa que pida al usuario 10 frases, las guarde en un array, y
 * luego le pregunte textos de forma repetitiva, e indique si cada uno de esos textos
 * aparece como parte de alguno de los elementos del array. Terminará cuando el
 * texto introducido sea "fin"
 * 
 * Ejercicio 4.4.5.2: Crea una versión del ejercicio 4.4.5.1 en la que, 
 * en caso de que alguno de los textos aparezca como subcadena, se avise además si se 
 * encuentra exactamente al principio.
 */
using System;
public class E4_4_5_2
{
    public static void Ejecutar()
    {
        string[] diezfrases = new string[10];
        int contador = 0;
        do
        {
            Console.WriteLine("¿Frase {0}?: ", contador + 1);
            diezfrases[contador] = Convert.ToString(Console.ReadLine());
            contador++;
        }
        while (contador < 10);
        Console.Clear();
        Console.WriteLine("Array de frases completo, continuando...");
        string busqueda = "";
        do
        {
            Console.Write("¿Fragmento a buscar?: ");
            busqueda = Convert.ToString(Console.ReadLine());
            for (int j = 0; j < 10; j++)
            {
                if (diezfrases[j].Contains(busqueda))
                {
                    Console.WriteLine(" \"" + busqueda + "\" figura en la frase \"" + diezfrases[j] + "\"");
                }
                if (diezfrases[j].IndexOf(busqueda) >= 0)
                {
                    Console.WriteLine(diezfrases + " empieza con la búsqueda mencionada.");
                }
            }
        }
        while (busqueda != "fin");
    }
}