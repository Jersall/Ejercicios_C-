/*Ejercicio 4.4.3.3: Un programa que pida al usuario una frase, después una letra y
finalmente diga si aparece esa letra como parte de esa frase o no.*/
using System;
public class E4_4_3_3
{
    public static void Ejecutar()
    {
        string frase;
        char letra;
        int contador = 0, largo;
        Console.Write("Introduce una frase: ");
        frase = Convert.ToString(Console.ReadLine());
        largo = frase.Length;
        Console.Write("Introduce una letra: ");
        letra = Convert.ToChar(Console.ReadLine());
        for(int i = 0; i < largo; i++)
        {
            if(frase[i] == letra)
            {
                contador++;
            }
        }
        if (contador > 0)
        {
            Console.WriteLine("Hay " + contador + " letras " + letra + " en esta frase.");
        }
        else
        {
            Console.WriteLine("No hay letras " + letra + " en esta frase.");
        }
    }
}