/*Ejercicio 4.4.7.1: Un programa que pida al usuario una frase y muestre sus palabras en orden inverso.*/
using System;
public class E4_4_7_1
{
    public static void Ejecutar()
    {
        string frasealeatoria;
        Console.Write("¿Frase random?");
        frasealeatoria = Convert.ToString(Console.ReadLine());
        char[] puntuacion = { ',', '.', ' '};
        string[] separado = frasealeatoria.Split(puntuacion);
        for(int i = separado.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(separado[i]);
        }
        Console.WriteLine("Aparcao");
    }
}
