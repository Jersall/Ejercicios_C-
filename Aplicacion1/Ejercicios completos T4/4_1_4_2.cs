/*Ejercicio 4.1.4.2: Crea una variante del ejemplo anterior (04_01_04a) que añada un dato
introducido por el usuario al final de los datos existentes.*/
using System;
public class E4_1_4_2
{
    public static void Ejecutar()
    {
        int[] numeros = { 10, 15, 12, 0, 0 };
        int cap = 5;
        int cant = 3;
        int masnum;
        if (cap > cant)
        {
            Console.Write("¿Numero a añadir?: ");
            masnum = Convert.ToInt32(Console.ReadLine());
            numeros[cant] = masnum;
            cant++;
            for(int i = 0; i < cant; i++)
                Console.WriteLine(numeros[i]);
        }
    }
}