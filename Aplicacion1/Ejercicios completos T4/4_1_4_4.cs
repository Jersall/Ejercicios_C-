/*Ejercicio 4.1.4.4: Crea una variante del ejemplo anterior (04_01_04a) que borre el dato que
se encuentre en la posición que elija el usuario. Debe avisar si la posición escogida
no es válida.*/
using System;
public class E4_1_4_4
{
    public static void Ejecutar()
    {
        int[] numeros = { 10, 15, 12, 11, 13 };
        int cant = 5, posicion = 6;
        for (int i = 0; i < cant; i++)
        {
            Console.Write("{0}. ", i + 1);
            Console.WriteLine(numeros[i]);
        }
        while (posicion > 5)
        {
            Console.Write("Selecciona la posicion que quieras borrar.");
            posicion = Convert.ToInt32(Console.ReadLine());
            if((posicion > 5) || (posicion <= 0))
            {
                Console.WriteLine("No existen posiciones superiores a 5.");
            }
        }
        for (int i = posicion - 1; i < cant - 1; i++)
            numeros[i] = numeros[i + 1];
        cant--;
        for (int i = 0; i < cant; i++)
        {
            Console.Write("{0}. ", i + 1);
            Console.WriteLine(numeros[i]);
        }
    }
}