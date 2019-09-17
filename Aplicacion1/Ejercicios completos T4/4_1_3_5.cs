/*Ejercicio 4.1.3.5: A partir del ejercicio anterior, crea otro que pida al usuario que le indique
la fecha, formada por día (1 al 31) y el mes (1=enero, 12=diciembre), y como
respuesta muestre en pantalla el número de días que quedan hasta final de año.*/
using System;
public class E4_1_3_5
{
    public static void Ejecutar()
    {
        int mes, dia, dianyo = 0, faltan;
        int[] diasmes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        Console.Write("¿Dia(numero)?: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿De que mes(Numero tambien)?: ");
        mes = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < mes - 1; i++)
        {
            dianyo += diasmes[i];
        }
        faltan = 365 - (dianyo + dia);
        Console.WriteLine("Faltan {0} dias para terminar el año", faltan);
    }
}