/*Ejercicio 4.3.2.2: Crea un programa que permita guardar datos de "imágenes" (ficheros de
ordenador que contengan fotografías o cualquier otro tipo de información gráfica).
De cada imagen se debe guardar: nombre (texto), ancho en píxeles (por ejemplo
2000), alto en píxeles (por ejemplo, 3000), tamaño en Kb (por ejemplo 145,6). El
programa debe ser capaz de almacenar hasta 700 imágenes (deberá avisar cuando
su capacidad esté llena). Debe permitir las opciones: añadir una ficha nueva, ver
todas las fichas (número y nombre de cada imagen), buscar la ficha que tenga un
cierto nombre.*/
using System;
public class E4_3_2_2
{
    struct fotos
    {
        public string nombre;
        public int alto, ancho, pesoKb;
    }
    public static void Ejecutar()
    {
        const int capacidad = 700;
        int opcionmenu, cantidad = 0;
        string buscar;
        fotos[] imagen = new fotos[capacidad];
        do
        {
            Console.Clear();
            Console.WriteLine("Selecciona una opción");
            Console.WriteLine("1) Añadir nueva imágen");
            Console.WriteLine("2) Lista de imágenes guardadas");
            Console.WriteLine("3) Búsqueda");
            Console.Write("¿Opción?: ");
            opcionmenu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch(opcionmenu)
            {
                case 1:
                    {
                        if (cantidad < capacidad)
                        {
                            Console.Write("¿Nombre?: ");
                            imagen[cantidad].nombre = Convert.ToString(Console.ReadLine());
                            Console.Write("¿Alto?: ");
                            imagen[cantidad].alto = Convert.ToInt32(Console.ReadLine());
                            Console.Write("¿Ancho?: ");
                            imagen[cantidad].ancho = Convert.ToInt32(Console.ReadLine());
                            Console.Write("¿Cuántos Kb ocupa?: ");
                            imagen[cantidad].pesoKb = Convert.ToInt32(Console.ReadLine());
                            cantidad++;
                            Console.WriteLine("Imágen guardada.");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Lo lamento, pero ya no cabe mas");
                            Console.ReadLine();
                        }
                    }
                    break;
                case 2:
                    {
                        for(int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("{0}) {1} - {2}x{3}px", i+1, imagen[i].nombre, imagen[i].alto, imagen[i].ancho);
                        }
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    {
                        Console.Write("Introduce el nombre de la foto que buscas: ");
                        buscar = Convert.ToString(Console.ReadLine());
                        for(int j = 0; j < cantidad;j++)
                        {
                            if(buscar.ToLower() == imagen[j].nombre.ToLower())
                            {
                                Console.WriteLine("{0}) {1} - {2} x {3} px - {4} Kb", j + 1, imagen[j].nombre, imagen[j].alto, imagen[j].ancho, imagen[j].pesoKb);
                            }
                        }
                        Console.ReadLine();
                    }
                    break;
            }
        }
        while ((opcionmenu < 4) && (opcionmenu > 0));
        Console.WriteLine("¡Hasta otra!");
    }   
}