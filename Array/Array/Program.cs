using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nombre = "Unai";
            //char[] arrayNombre = nombre.ToCharArray();//nos va guardar cada letra{'u' 'n'...}
            //System.Array.Reverse(arrayNombre);


            //Console.WriteLine(arrayNombre);
            //Console.ReadLine();

            //EJERCICIO 1

            //int[] numeros = { 2, 1, 5, 6, 1, 8, 4, 8, 9, 5 };
            //for(int i=0; i<numeros.Length; i++)
            //{

            //    Console.Write(numeros[i]);
            //}

            //Console.ReadLine();

            //EJERCICIO 2 ARRAY
            //String name1, name2, name3;

            //Console.WriteLine("Escribe un nombre");
            //name1=Console.ReadLine();
            //Console.WriteLine("Escribe un nombre");
            //name2 = Console.ReadLine();
            //Console.WriteLine("Escribe un nombre");
            //name3 = Console.ReadLine();
            //string[] names = { name1, name2, name3 };
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[0]);


            //Console.ReadLine();

            //EJERCICIO 3


            //int []numeros;
            //numeros = new int [10];
            //int cuenta = 20;
            //for (int i=0; i<numeros.Length; i++)
            //{
            //    numeros[i] = cuenta;
            //    cuenta--;
            //    Console.WriteLine(numeros[i] + " ");
            //}
            //Console.ReadLine();

            //EJERCICIO 4

            //int[]numeros;
            //numeros = new int[3];
            //int num;

            //for (int i = 0; i < numeros.Length; i++)
            //{
            //Console.WriteLine("Escribe un numero");
            //num = Int32.Parse(Console.ReadLine());
            //numeros[i] = num;
            //}
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //Console.WriteLine(numeros[i]);
            //}

            //Console.ReadLine();

            //EJERCICIO 5

            //int[] count;
            //count = new int[3];
            //int num;
            //comparador=10000

            //for (int i=0; i<count.Length; i++)
            //{
            //    Console.WriteLine("Escribe un número");
            //    num = Int32.Parse(Console.ReadLine());
            //    count[i] = num;
            //if (comparador>count[i])
            //{
            //comparador = count[i];
            //}
            //}

            //if (Math.Max(count[0], count[1]) < count[2])
            //{
            //    Console.WriteLine("MAX" + count[2]);
            //}
            //else if (Math.Max(count[2], count[1]) < count[0])
            //{
            //    Console.WriteLine("MAX" + count[0]);
            //}
            //else
            //    Console.WriteLine("MAX" + count[1]);

            //if (Math.Min(count[0], count[1]) > count[2])
            //{
            //    Console.WriteLine("MIN" + count[2]);
            //}
            //else if (Math.Min(count[2], count[1]) > count[0])
            //{
            //    Console.WriteLine("MIN" + count[0]);
            //}
            //else
            //    Console.WriteLine("MIN" + count[1]);

            //Console.ReadLine();


            //EJERCICIO 6

            //String[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "November", "December" };
            //int monthText;


            //    Console.WriteLine("Introduce un numero de mes");
            //    monthText = Int32.Parse(Console.ReadLine());
            //        while (monthText <= 0 || monthText > 12) 
            //        {
            //         Console.WriteLine("Introduce un numero de mes");
            //         monthText = Int32.Parse(Console.ReadLine());
            //        }
            //    Console.WriteLine(months[monthText - 1]);

            //Console.ReadLine();

            //EJERCICIO 7

            //int[] count;
            //count = new int[10];
            //int total=0;
            //for (int i = 0; i < count.Length; i++)
            //{
            //    Console.WriteLine("escribe 1 valor");
            //    count[i] = Int32.Parse(Console.ReadLine());
            //}
            //for (int i=0; i<count.Length; i++)
            //{
            //    total = total + count[i];

            //}
            //Console.WriteLine("La media es" + total/10);
            //Console.ReadLine();

            //EJERCICIO 8
            //Contador de cuantas veces se mete un numero
            //int[] count;
            //count = new int[11];
            //int num;        
            //do
            //{
            //    Console.WriteLine("Escribe un numero del 0 al 10");
            //    num = Int32.Parse(Console.ReadLine());
            //    if (num > 10)
            //    {
            //        Console.WriteLine("el numero no es correcto");
            //    }
            //    else if (num>=0)
            //    {
            //        count[num]++;
            //    }
            //}

            //while (num >= 0);

            //for (int i = 0; i < count.Length; i++)
            //{
            //    Console.WriteLine(i + "\t" + count[i]);
            //}

            //Console.ReadLine();


            //EJERCICIO 9
            //int num;
            //int[] count = new int[10];
            //for (int i=0; i<count.Length; i++)
            //{
            //    count[i] = 1;
            //}
            //do
            //{
            //    Console.WriteLine("Escribe un número del 0 al 9");
            //    num = Int32.Parse(Console.ReadLine());

            //    if (num>=0)

            //    count[num] = count[num] * 2;               
            //}

            //while (num > 0);
            //for (int i = 0; i < count.Length; i++)
            //Console.WriteLine(i + "\t" + count[i]);
            //Console.ReadLine();

            //EJERCICIO 10

            Random rand = new Random();
            rand.Next(18, 36);
            int[] age = new int[20];
            int ageText;
            for (int i = 0; i < age.Length; i++)
            {
                do
                {
                    Console.WriteLine("Escribe tu edad");
                    ageText = Int32.Parse(Console.ReadLine());
                    if (ageText >= 18 && ageText <= 35)
                    {
                        age[i] = ageText;
                    }
                    
                }
                while (age.Length < i);

            }
            Console.WriteLine("La media de edad es" + age.Average());

            Console.ReadLine();

            //EJERCICIO 11

            Console.ReadLine();



        }
    }
}
