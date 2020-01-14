/*Ejercicio 4.4.6.1:  Una variante del ejercicio 4.4.5.2, que no distinga entre mayúsculas y
minúsculas a la hora de buscar.*/

using System;
public class E4_4_6_1
{
    public static void Ejecutar()
    {
        string[] diezfrases = new string[10];
        int contador = 0;
        do
        {
            Console.WriteLine("¿Frase {0}?: ", contador + 1);
            diezfrases[contador] = Convert.ToString(Console.ReadLine());
            diezfrases[contador] = diezfrases[contador].ToLower();
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
            busqueda = busqueda.ToLower();
            for (int j = 0; j < 10; j++)
            {
                if (diezfrases[j].Contains(busqueda))
                {
                    Console.WriteLine(" \"" + busqueda + "\" figura en la frase \"" + diezfrases[j] + "\"");
                }
                if (diezfrases[j].IndexOf(busqueda) >= 0)
                {
                    Console.WriteLine(diezfrases[j] + " empieza con la búsqueda mencionada.");
                }
            }
        }
        while (busqueda != "fin");
    }
}