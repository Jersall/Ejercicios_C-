/*Ejercicio 4.1.3.4: Un programa que almacene en una tabla el número de días que tiene
cada mes (de un año no bisiesto), pida al usuario que le indique un mes (ej. 2 para
febrero) y un día (ej. el día 15) y diga qué número de día es dentro del año (por
ejemplo, el 15 de febrero sería el día número 46, el 31 de diciembre sería el día
365).*/
using System;
public class E4_1_3_4
{
    public static void Ejecutar()
    {
        int mes, dia, dianyo = 0, numerodia;
        int[] diasmes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.Write("¿Dia(numero)?: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿De que mes(Numero tambien)?: ");
        mes = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < mes - 1; i++)
        {
            dianyo += diasmes[i];
        }
        numerodia = dianyo + dia;
        Console.WriteLine("Este dia es el {0} de 365", numerodia);
    }
}