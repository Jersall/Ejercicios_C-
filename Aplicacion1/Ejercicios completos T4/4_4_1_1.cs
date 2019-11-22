/*Ejercicio 4.4.1.1: Crea un programa que pida al usuario su nombre. Si se llama como tú
(por ejemplo, "Nacho"), responderá "Bienvenido, jefe". En caso contrario, le
saludará por su nombre.*/
using System;

public class E4_4_1_2
{
    public static void Ejecutar()
    {
        string nombre;
        Console.WriteLine("¿Cómo dices que te llamas?: ");
        nombre = Convert.ToString(Console.ReadLine());
        if (nombre == "Juanjo")
            Console.WriteLine("Bienvenido, jefe");
        else
            Console.WriteLine("Hola, " + nombre);
    }
}
