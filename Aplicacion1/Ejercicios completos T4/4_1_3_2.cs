/*Ejercicio 4.1.3.2: Crea un programa que pregunte al usuario cuántos números 
enteros va a introducir(por ejemplo, 10), le pida todos esos números, 
los guarde en un array y finalmente calcule y muestre la media de esos números.*/
using System;
public class E4_1_3_2
{
    public static void Ejecutar()
    {
        int jowmuch, suma = 0, media;
        Console.Write("¿Cuantos numeros vas a usar?: ");
        jowmuch = Convert.ToInt32(Console.ReadLine());
        int[] nums = new int[jowmuch];
        for (int i = 0; i < jowmuch; i++)
        {
            Console.Write("¿Numero {0}?: ", i + 1);
            nums[i] = Convert.ToInt32(Console.ReadLine());
            suma += nums[i];
        }
        media = suma / jowmuch;
        Console.WriteLine("La media de todos estos numeros es {0}", media);
    }
}
