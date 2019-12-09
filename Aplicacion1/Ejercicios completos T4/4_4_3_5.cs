/*Ejercicio 4.4.3.5: Un programa capaz de multiplicar dos números enteros muy grandes
(por ejemplo, de 30 cifras), que se deberán pedir como cadena de texto y analizar
letra a letra.*/
using System;
public class E4_4_3_5
{
    public static void Ejecutar()
    {
        string n1, n2, largo, corto;
        int unidades = 1, producto = 0;
        Console.Write("¿Numero 1?: ");
        n1 = Convert.ToString(Console.ReadLine());
        Console.Write("¿Numero 2?: ");
        n2 = Convert.ToString(Console.ReadLine());
        if(n1.Length >= n2.Length)
        {
            largo = n1;
            corto = n2;
        }
        else
        {
            largo = n2;
            corto = n1;
        }
        int[] presuma = new int[corto.Length];
        for (int i = corto.Length - 1; i >= 0; i--)
        {
            int temuno, tempdos;
            tempdos = Convert.ToInt32(Convert.ToString(corto[i]));
            for (int j = largo.Length - 1; j >= 0; j--)
            {
                temuno = Convert.ToInt32(Convert.ToString(largo[j]));
                presuma[i] = presuma[i] + ((temuno * unidades) * tempdos);
                unidades *= 10;
                if (j == 0)
                {
                    Console.WriteLine(presuma[i]);
                }
            }
            unidades = 1;
            if (i == 0)
            {
                for (int k = corto.Length - 1; k >= 0; k--)
                {
                    presuma[k] = presuma[k] * unidades;
                    Console.WriteLine("{0}", presuma[k]);
                    producto = producto + presuma[k];
                    unidades *= 10;
                    if (k == 0)
                    {
                        Console.WriteLine(producto);
                    }
                }
            }
        }
    }
}
