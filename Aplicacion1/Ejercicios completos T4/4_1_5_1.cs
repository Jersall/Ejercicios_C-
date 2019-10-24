/*Ejercicio 4.1.5.1: Crea un programa que contenga un array con los nombres de los meses
del año. El usuario podrá elegir entre verlos en orden natural (de Enero a
Diciembre) o en orden inverso (de Diciembre a Enero). Usa constantes para el
valor máximo del array en ambos recorridos.*/
using System;

public class E4_1_5_1
{
    public static void Ejecutar()
    {
        string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
        const int ultimo = 11;
        char dr;
        Console.WriteLine("¿Derecho o revés? (D o R): ");
        dr = Convert.ToChar(Console.ReadLine());
        if ((dr == 'D') || (dr == 'd'))
        {
            for (int i = 0; i <= ultimo; i++)
            {
                Console.WriteLine(meses[i]);
            }
        }
        if ((dr == 'R') || (dr == 'r'))
        {
            for (int i = ultimo; i >= 0; i--)
            {
                Console.WriteLine(meses[i]);
            }
        }
    }
}
