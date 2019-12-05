/*Ejercicio 4.4.3.4: Un programa capaz de sumar dos números enteros muy grandes (por
ejemplo, de 30 cifras), que se deberán pedir como cadena de texto y analizar letra
a letra.*/
using System;
public class E4_4_3_4
{
    public static void Ejecutar()
    {
        string n1, n2, suma = "";
        int llevouna = 0;
        Console.Write("¿Numero 1?: ");
        n1 = Convert.ToString(Console.ReadLine());
        Console.Write("¿Numero 2?: ");
        n2 = Convert.ToString(Console.ReadLine());
        if (n1.Length > n2.Length)
        {
            while(n1.Length != n2.Length)
            {
                n2 = "0" + n2;
            }
        }
        else if (n2.Length > n1.Length)
        {
            while (n2.Length != n1.Length)
            {
                n1 = "0" + n1;
            }
        }
        for (int i = n1.Length-1; i >= 0; i--)
        {
            int temporaluno = Convert.ToInt32(Convert.ToString(n1[i]));
            int temporaldos = Convert.ToInt32(Convert.ToString(n2[i]));
            string resultadotemp = Convert.ToString(temporaluno + temporaldos + llevouna);
            Console.WriteLine(n1[i]+" + "+n2[i]+" = "+resultadotemp);
            if(resultadotemp.Length == 1)
            {
                suma = resultadotemp + suma;
                llevouna = 0;
            }
            else if(resultadotemp.Length == 2)
            {
                suma = resultadotemp[1] + suma;
                llevouna = 1;
            }
        }
        Console.Write(suma);
    }
}