/*Ejercicio 4.4.3.5: Un programa capaz de multiplicar dos números enteros muy grandes
(por ejemplo, de 30 cifras), que se deberán pedir como cadena de texto y analizar
letra a letra.*/
using System;
public class E4_4_3_5
{
    public static void Ejecutar()
    {
        //creamos las primeras variables: n1 y n2 para aclarar ambos operadores. Necesitaremos un producto final para el resultado de las sumas de los factores de
        //la multiplicación de numeros sobre 10. Añadimos una variable para las cuentas de "llevar".
        //usaremos un array para identificar cada multiplicación con los factores individuales. (1234 * 89 deberá ser 1234*9, luego * 8 y añadiremos un 0 después, y luego se sumarán ambas opciones)
        string n1, n2, largo, corto;
        int unidades = 1, producto = 0;
        Console.Write("¿Numero 1?: ");
        n1 = Convert.ToString(Console.ReadLine());
        Console.Write("¿Numero 2?: ");
        n2 = Convert.ToString(Console.ReadLine());
        //Ordenaremos los factores, por comodidad de construcción. Pondremos el número largo arriba, y el número corto abajo, para hacerlo similar a una multiplicación convencional a papel.
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
        //Vamos a pasar los números "Largo" y "Corto" a variables numéricas para trabajar con producto. El ejercicio especifica que requerimos de cada posición para ser trabajada
        //como número individual, así que deberá estar en un for.
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
