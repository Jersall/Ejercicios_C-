/*Ejercicio 4.1.4.3: Crea una variante del ejemplo anterior (04_01_04a) que inserte un dato
introducido por el usuario en la posición que elija el usuario. Debe avisar si la
posición escogida es incorrecta (porque esté más allá del final de los datos)*/
using System;
public class E4_1_4_3
{
    public static void Ejecutar()
    {
        int[] numeros = { 10, 15, 12, 0, 0 };
        int cap = 5, cant = 3, posicion, nuevodato;
        Console.Write("Introduce el nuevo número que quieras añadir: ");
        nuevodato = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿En que posición irá?(max 5): ");
        posicion = Convert.ToInt32(Console.ReadLine());
        if (cant < cap)
        for (int i = cant; i > posicion; i--)
            numeros[i] = numeros[i - 1];
        numeros[posicion-1] = nuevodato;
        cant++;
        if (numeros[4] > 0)
            cant++;
        for (int i = 0; i < cant; i++)
            Console.WriteLine(numeros[i]);

    }
}