/*Ejercicio 4.1.4.5: Crea un programa que prepare espacio para un máximo de 10 nombres.
Deberá mostrar al usuario un menú que le permita realizar las siguientes operaciones:
 Añadir un dato al final de los ya existentes.
 Insertar un dato en una cierta posición (como ya se ha comentado, los que
quedén detrás deberán desplazarse "a la derecha" para dejarle hueco; por
ejemplo, si el array contiene "hola", "adios" y se pide insertar "bien" en la
segunda posición, el array pasará a contener "hola", "bien", "adios".
 Borrar el dato que hay en una cierta posición (como se ha visto, lo que
estaban detrás deberán desplazarse "a la izquierda" para que no haya
huecos; por ejemplo, si el array contiene "hola", "bien", "adios" y se pide
borrar el dato de la segunda posición, el array pasará a contener "hola",
"adios"
 Mostrar los datos que contiene el array.
 Salir del programa.*/
using System;
public class E4_1_4_5
{
    public static void Ejecutar()
    {
        string[] palabros = new string[10];
        int opcion = 0, cap = 10, cant = 0, posicion = 11;
        string nuevodato;
        while (opcion != 5)
        {
            Console.WriteLine("1. Añadir dato al final de los existentes.");
            Console.WriteLine("2. Insertar dato en la posicion deseada.");
            Console.WriteLine("3. Borrar dato de la posicion deseada.");
            Console.WriteLine("4. Mostrar datos.");
            Console.WriteLine("5. Finalizar programa.");
            Console.Write("¿Nº Opcion?: ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                {
                    if (cant < cap)
                    {
                        Console.Write("Introduce el nuevo dato en el hueco {0}: ", cant + 1);
                        palabros[cant] = Convert.ToString(Console.ReadLine());
                        cant++;
                    }
                    else
                    {
                        Console.WriteLine("El nuevo dato no cabe. Todos los espacios de guardado están llenos. Borra un dato antes de introducir el siguiente.");
                    }
                }
                    break;
                case 2:
                {
                    Console.Write("Introduce el nuevo dato a añadir: ");
                    nuevodato = Convert.ToString(Console.ReadLine());
                    while (posicion > 10)
                    {
                        Console.Write("¿En que posición irá?(max 10): ");
                        posicion = Convert.ToInt32(Console.ReadLine());
                        if (posicion > 10)
                        {
                            Console.WriteLine("No existen posiciones superiores a 10.");
                        }
                    }
                    if (cant<cap)
                    {
                        for (int i = cap - 1; i > posicion - 1; i--)
                            palabros[i] = palabros[i - 1];
                        palabros[posicion - 1] = nuevodato;
                        cant++;
                    }
                    posicion = 11;
                }
                    break;
                case 3:
                {
                    while (posicion > 10)
                    {
                        Console.Write("Selecciona la posicion que quieras borrar: ");
                        posicion = Convert.ToInt32(Console.ReadLine());
                        if ((posicion > 10) || (posicion <= 0))
                        {
                            Console.WriteLine("posicion erronea.");
                        }
                    }
                    for (int i = posicion - 1; i < cap; i++)
                    {
                        if (i < 9)
                            palabros[i] = palabros[i + 1];
                        else
                            palabros[9] = null;
                    }
                    cant--;
                    posicion = 11;
                }
                    break;
                case 4:
                {
                    Console.WriteLine("Mostrando datos...");
                    for(int i = 0; i < cap; i++)
                        Console.WriteLine(palabros[i]);
                }
                    break;
                default:
                    break;
            }
        }
    }
}