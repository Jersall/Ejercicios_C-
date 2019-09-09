/*Ejercicio 3.5.4: Crea una versión alternativa del ejercicio 3.5.3 usando if 
 en lugar de bool*/
using System;
public class Ejercicio3_5_4
{
    public static void Ejecutar()
    {
        int n1, n2;
        Console.Write("¿Numero 1?");
        n1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Número 2?");
        n2 = Convert.ToInt32(Console.ReadLine());
        if ((n1 % 2 == 0) && (n2 % 2 == 0))
        {
            Console.WriteLine("Ambos son pares.");
        }
        else
        {
            if ((n1 % 2 == 0) || (n2 % 2 == 0))
            {
                Console.WriteLine("Aquí hay un numero par.");
            }
            else
            {
                Console.WriteLine("Ningun par.");
            }
        }
    }
}
