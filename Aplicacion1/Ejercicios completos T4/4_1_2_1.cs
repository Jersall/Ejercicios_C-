/*Ejercicio 4.1.2.1: Un programa que almacene en una tabla el numero de dias que 
 tiene cada mes, y pida al usuario que le indique un mes(de 1 a 12) 
 y muestre en pantalla el numero de dias.*/
using System;
public class E4_1_2_1
{
    public static void Ejecutar()
    {
        int[] meses = {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
        int nmes;
        Console.Write("¿Numero de mes?: ");
        nmes = Convert.ToInt32(Console.ReadLine());
        nmes--;
        switch(nmes)
        {
            case 0:
                Console.Write("Enero: ");
                break;
            case 1:
                Console.Write("Febrero: ");
                break;
            case 2:
                Console.Write("Marzo: ");
                break;
            case 3:
                Console.Write("Abril: ");
                break;
            case 4:
                Console.Write("Mayo: ");
                break;
            case 5:
                Console.Write("Junio: ");
                break;
            case 6:
                Console.Write("Julio: ");
                break;
            case 7:
                Console.Write("Agosto: ");
                break;
            case 8:
                Console.Write("Septiempre: ");
                break;
            case 9:
                Console.Write("Octubre: ");
                break;
            case 10:
                Console.Write("Noviembre: ");
                break;
            case 11:
                Console.Write("Diciembre: ");
                break;
            default:
                Console.Write("No hay tantos meses.");
                break;
        }
        Console.Write(meses[nmes]);
        Console.WriteLine(" días en total.");
    }
}
