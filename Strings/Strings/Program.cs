using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            //EJERCICIO 1
            string palabra;
            Console.WriteLine("escribe una palabra");
            palabra = Console.ReadLine();
            Console.WriteLine(palabra.Length);
            Console.ReadLine();
            

            //EJERCICIO 3   
            int palabra = 1;
            string frase;
            Console.WriteLine("escribe una frase");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                if (frase[i] == ' ')
                {
                    palabra++;
                }

            }
            Console.ReadLine();

            
            //EJERCICIO 4

            String palabra;
            string palabra2;
            Console.WriteLine("Escribe frase");
            palabra = Console.ReadLine();
            palabra2 =string.Copy(palabra);
            Console.WriteLine(palabra2);

            Console.ReadLine();
            

            //EJERCICIO 6   
            string frase;
            int palabra = 0;
            Console.WriteLine("escribe una frase");
            frase = Console.ReadLine();
            for(int i=0; i<frase.Length; i++)
            {
                if (frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] =='u')
                {
                    palabra++;
                }
            }
            Console.WriteLine(palabra);
            Console.ReadLine();
            

            //EJERCICIO 6
            string frase;
            Console.WriteLine("escribe una frase");
            frase = Console.ReadLine();
            Console.WriteLine(frase.ToUpper() + " " + frase.ToLower() + " ");
            

            //EJERCICIO 7
            bool found=false;
            String frase;
            Console.WriteLine("escribe una frase");
            frase = Console.ReadLine();

            for (int i = 0; i < frase.Length; i++)
            {
                found = frase[i] == 'r' || frase[i] == 'R';
                if (found)
                {
                    Console.WriteLine("SI Contiene la r");
                }

            }
            Console.WriteLine("NO Contiene la r");

            Console.ReadLine();

                   

            //EJERCICIO 8
            // jon==> la respuesta "O" unai==> la respuesta "na"
            bool pair = false;
            string sentence;
           
            Console.WriteLine("Escribe una frase");
            sentence = Console.ReadLine();
            pair = (sentence.Length % 2 == 0);

            if (pair)
            {
                Console.WriteLine(sentence[(sentence.Length / 2)-1]);
                Console.WriteLine(sentence[(sentence.Length / 2)]);

            }
            else
                Console.WriteLine(sentence[(sentence.Length / 2)]);


            Console.ReadLine();


            //EJERCICIO 9 
            //Contraseña

            bool correcto = false;
            string contraseña;
            int contador = 0;
            do
            {
                Console.WriteLine("introduce contraseña");
                contraseña = Console.ReadLine();
                if (contraseña.Length >= 8)
                {
                    for (int i = 0; i < contraseña.Length; i++)
                    {
                        if (char.IsDigit(contraseña[i]) == true)
                        {
                            contador++;
                            if (contador >= 2)
                            {
                                correcto = true;
                            }
                        }
                    }
                }
            }
            while (correcto == false);
            Console.WriteLine("La contrasña es correcta");

            

            //EJERCICIO 10
            int num1, num2, num3;
            Console.WriteLine("Escribe un numero");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe un numero");
            num2 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Escribe un numero");
            num3 = Int32.Parse(Console.ReadLine());

            if(Math.Max(num1, num2)<num3)
            {
                Console.WriteLine(num3 + " MAX");
            }
            else if(Math.Max(num3,num2)<num1)
            {
                Console.WriteLine(num1 + " MAX");
            }
            else
                Console.WriteLine(num2 + " MAX");

            if (Math.Min(num1, num2) > num3)
            {
                Console.WriteLine(num3 + " MIN");
            }
            else if (Math.Min(num3, num2) > num1)
            {
                Console.WriteLine(num1 + " MIN");
            }
            else
                Console.WriteLine(num2 + " MIN");


            Console.ReadLine();

            */

            //EJERCICIO 12

            DateTime fecha = DateTime.Now;
            Console.WriteLine(fecha);



            Console.ReadLine();

        }

    }
}
