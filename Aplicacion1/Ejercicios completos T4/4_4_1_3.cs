/*Ejercicio 4.4.1.3: Un programa que pida tu nombre, tu día de nacimiento y tu mes de
nacimiento y lo junte todo en una cadena, separando el nombre de la fecha por
una coma y el día del mes por una barra inclinada, así: "Juan, nacido el 31/12".*/
using System;
public class E4_4_1_3
{
    public static void Ejecutar()
    {
        string nombre;
        int dia, mes;
        Console.Write("¿Nombre?: ");
        nombre = Convert.ToString(Console.ReadLine());
        Console.Write("¿Mes de nacimiento?: ");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Dia de nacimiento?: ");
        dia = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(nombre + ", nacido el " + dia + "/" + mes);
    }
}
