/*Ejercicio 4.3.1.1: Crea un "struct" que almacene datos de una canción en formato MP3:
Artista, Título, Duración (en segundos), Tamaño del fichero (en KB). Un programa
debe pedir los datos de una canción al usuario, almacenarlos en dicho "struct" y
después mostrarlos en pantalla.*/
using System;
public class E4_3_1_1
{
    struct eseTemazo
    {
        public string artista, titulo;
        public int durasegundos;
        public double pesoKB;
    }
    public static void Ejecutar()
    {
        eseTemazo[] tema = new eseTemazo[1];

        Console.Write("¿Artista?: ");
        tema[0].artista = Convert.ToString(Console.ReadLine());
        Console.Write("¿Título del tema?: ");
        tema[0].titulo = Convert.ToString(Console.ReadLine());
        Console.Write("¿Cuántos segundos dura?: ");
        tema[0].durasegundos = Convert.ToInt32(Console.ReadLine());
        Console.Write("¿Cuantos KB ocupa?: ");
        tema[0].pesoKB = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Datos de {0}.mp3:", tema[0].titulo);
        Console.WriteLine("Artista: {0}", tema[0].artista);
        Console.WriteLine("Título: {0}", tema[0].titulo);
        Console.WriteLine("Duracion(Secs): {0}", tema[0].durasegundos);
        Console.WriteLine("Tamaño(KB): {0}", tema[0].pesoKB);
    }
}
