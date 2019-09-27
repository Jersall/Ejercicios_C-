/*Ejercicio 4.1.4.1: Crea una variante del ejemplo anterior (04_01_04a) que pida al usuario el
dato a buscar, avise si ese dato no aparece, y que diga cuántas veces se ha
encontrado en caso contrario.*/
using System;
public class E4_1_4_1
{
    public static void Ejecutar()
    {
        int[] numeros = { 10, 15, 12, 10, 0 };
        int cap = 5;
        int cant = 4;
        int busqueda, veces = 0;

        Console.Write("¿Que numero buscas?: ");
        busqueda = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < cant; i++)
        {
            if(busqueda == numeros[i])
            {
                veces++;
            }
        }
        if (veces > 0)
        {
            Console.WriteLine("{0} Está entre los datos, {1} vez(ces).", busqueda, veces);
        }
    }
}
