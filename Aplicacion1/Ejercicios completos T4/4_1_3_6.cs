/*Ejercicio 4.1.3.6: Un programa que pida 10 nombres y los memorice (pista: esta vez se
trata de un array de "string"). Después deberá pedir que se teclee un nombre y
dirá si se encuentra o no entre los 10 que se han tecleado antes. Volverá a pedir
otro nombre y a decir si se encuentra entre ellos, y así sucesivamente hasta que se
teclee "fin"*/
using System;
public class E4_1_3_6
{
    public static void Ejecutar()
    {
        string[] nombres = new string[10];
        string nombreprueba;
        bool enlalista;
        for (int i = 0; i <= 9; i++)
        {
            Console.Write("¿Nombre nº{0}?: ", i + 1);
            nombres[i] = Convert.ToString(Console.ReadLine());
        }
        Console.Write("Introduce un nombre(Fin para salir): ");
        nombreprueba = Convert.ToString(Console.ReadLine());
        while (nombreprueba != "Fin")
        {
            for (int j = 0; j <= 9;)
            {
                enlalista = (nombreprueba == nombres[j]);
                if (enlalista == false)
                {                    
                    if (j == 9)
                    {
                        Console.WriteLine("No está en la lista.");
                    }
                    j++;
                }
                else
                if (enlalista)
                {
                    Console.WriteLine("Está en la lista.");
                    j = 10;
                }
            }
            Console.Write("Introduce un nombre(Fin para salir): ");
            nombreprueba = Convert.ToString(Console.ReadLine());
        }       
    }
}