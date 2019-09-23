/*Un programa que prepare espacio para guardar un máximo de 100
nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se
pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres
y se mostrará en pantalla la lista de los nombres que se han introducido.*/
using System;
public class E4_1_3_7
{
    public static void Ejecutar()
    {
        string[] nombres = new string[100];
        int contador = -1;
        for (int i = 0; i <= 99; i++)
        {
            Console.Write("¿Nombre {0}?", i + 1);
            nombres[i] = Convert.ToString(Console.ReadLine());
            if (nombres[i] == "")
                i = 100;
            else
                contador++;
        }
        for (int i = 0; i <= contador; i++)
        {
            Console.WriteLine("{0}", nombres[i]);
        }
    }
}
