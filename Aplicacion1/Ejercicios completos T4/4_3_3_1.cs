/*Ejercicio 4.3.3.1: Amplia el programa 4.3.2.1, para que el campo "duración" se almacene
como minutos y segundos, usando un "struct" anidado que contenga a su vez
estos dos campos.*/
using System;
public class E4_3_3_1
{
    struct cancion
    {
        public string artista, titulo;
        public int durasegundos;
        public double pesoKB;
    }
    struct duracion
    {
        public int minutos, segundos;
    }
    public static void Ejecutar()
    {
        const int capacidad = 100;
        int opcionmenu, cantidad = 0;
        string buscar;
        cancion[] temastr = new cancion[capacidad];
        duracion[] tiempo = new duracion[capacidad];
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
            switch (opcionmenu)
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
                            tiempo[cantidad].segundos = Convert.ToInt32(Console.ReadLine());
                            for(int k = 0; tiempo[cantidad].segundos > 60; k++)
                            {
                                if (segundos > 60)
                                {
                                    tiempo[cantidad].segundos = tiempo[cantidad].segundos - 60;
                                }
                                tiempo[cantidad].minutos = k;
                            }
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
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("{0}) {1} - {2}", i + 1, temastr[i].artista, temastr[i].titulo);
                        }
                        Console.ReadLine();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("¿Buscas un artista o una canción? Escribe el nombre completo o el título completo:");
                        buscar = Convert.ToString(Console.ReadLine());

                        for (int j = 0; j < cantidad; j++)
                        {
                            if ((buscar.ToLower() == temastr[j].artista.ToLower()) || (buscar.ToLower() == temastr[j].titulo.ToLower()))
                            {
                                Console.WriteLine("Resultado encontrado: {0} - {1}({2}:{3})({4} KB)", temastr[j].artista, temastr[j].titulo, tiempo[j].minutos, tiempo[j].segundos,  temastr[j].pesoKB);
                            }
                        }
                        Console.ReadLine();
                    }
                    break;
            }
        }
        while ((opcionmenu < 4) && (opcionmenu > 0));
        Console.WriteLine("¡Hasta otra!");
        Console.ReadLine();
    }
}