/*Ejercicio 4.3.2.1: Amplia el programa del ejercicio 4.3.1.1, para que almacene datos de
hasta 100 canciones. Deberá tener un menú que permita las opciones: añadir una
nueva canción, mostrar el título de todas las canciones, buscar la canción que
contenga un cierto texto (en el artista o en el título)*/
using System;
public class E4_3_2_1
{
    struct cancion
    {
        public string artista, titulo;
        public int durasegundos;
        public double pesoKB;
    }
    public static void Ejecutar()
    {
        const int capacidad = 100;
        int opcionmenu, cantidad = 0;
        string buscar;
        cancion[] temastr = new cancion[capacidad];
        do
        {
            Console.Clear();
            Console.WriteLine("1) Añadir nueva canción.");
            Console.WriteLine("2) Mostrar todas las canciones guardadas.");
            Console.WriteLine("3) Busqueda.");
            Console.WriteLine("4) Salir");
            Console.Write("¿Opción?: ");
            opcionmenu = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch(opcionmenu)
            {
                case 1:
                {
                    if (cantidad < capacidad)
                    {
                        Console.WriteLine("(h {0})", cantidad + 1);
                        Console.Write("¿Artista?: ");
                        temastr[cantidad].artista = Convert.ToString(Console.ReadLine());
                        Console.Write("¿Título del tema?: ");
                        temastr[cantidad].titulo = Convert.ToString(Console.ReadLine());
                        Console.Write("¿Cuántos segundos dura?: ");
                        temastr[cantidad].durasegundos = Convert.ToInt32(Console.ReadLine());
                        Console.Write("¿Cuantos KB ocupa?: ");
                        temastr[cantidad].pesoKB = Convert.ToDouble(Console.ReadLine());
                        cantidad++;
                    }
                    else
                    {
                        Console.WriteLine("Lo siento, no cabe más, tendrás que borrar alguna de las canciones ya guardadas.");
                    }
                }
                    break;
                case 2:
                {
                    for(int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("{0}) {1} - {2}",i + 1, temastr[i].artista, temastr[i].titulo);
                    }
                    Console.ReadLine();
                }
                    break;
                case 3:
                {
                    Console.WriteLine("¿Buscas un artista o una canción? Escribe el nombre completo o el título completo:");
                    buscar = Convert.ToString(Console.ReadLine());
                    
                    for(int j = 0; j < cantidad; j++)
                    {
                        if((buscar == temastr[j].artista) || (buscar == temastr[j].titulo))
                        {
                            Console.WriteLine("Resultado encontrado: {0} - {1}({2} KB)", temastr[j].artista, temastr[j].titulo, temastr[j].pesoKB);
                        }
                    }
                    Console.ReadLine();
                }
                    break;
            }
        }
        while ((opcionmenu < 4) && (opcionmenu > 0));

    }
}