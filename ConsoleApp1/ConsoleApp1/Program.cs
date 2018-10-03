using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        
            //EJERCICIO WHILE
        {
            /**
            int i=0;//iterar
            int num;
            Console.WriteLine("Introducir un número" );
            num=Int32.Parse(Console.ReadLine());

            while (i<11)//esta en bucle hasta que llega a 11 que es cuando sale
                {
                    Console.WriteLine(num + " x "+ i + " = " + (num*i));
                    i++;
                }
            Console.ReadLine();

            //EJERCICIO 1-100
            
           i=1;
            
            while (i<101)
                {
                Console.WriteLine (i);
                i++;
                }
            Console.ReadLine();
            

            //EJERCICIO DO-WHILE

            do
                {
                Console.WriteLine(i);//
                i++;
                }
                while (i==1);//2 es igual a 1? NO, sale del bucle
            Console.ReadLine();
            
            //NUMERO NEGATIVO WHILE

            int num1;
            Console.WriteLine("Escribe un numero");
            num1=Int32.Parse(Console.ReadLine());

            while (num1>0)
                {
                Console.WriteLine("Escribe un numero");
                num1=Int32.Parse(Console.ReadLine());
                }
            Console.ReadLine();

            //NUMERO NEGATIVO DO-WHILE
            do 
                {
                Console.WriteLine("Escribe un numero");
                num1=Int32.Parse(Console.ReadLine());
                }
            while (num1>0);
            Console.ReadLine();
            

            //EJERCICIOS FOR
            for (int i= 0; i<=10; i=i+2)//Declarar, evaluar una condicion y añadir valores
                {
                Console.WriteLine(i);
                }
            Console.ReadLine();
            

            //EJERCICIO FOR
            //PEDIR CUATRO NUMEROS Y ESCRIBIR  LA SUMA TOTAL
            
            int suma=0;
            int num;
            
            for (int i=0; i<4; i++)
                {
                Console.WriteLine("escribe un numero");
                num=Int32.Parse(Console.ReadLine());
                suma=suma+num;
                }
            Console.WriteLine("Total: " + suma);
            Console.ReadLine();
            

            //EJERCICIO 1 BUCLES

            for (int i=10; i<=20;i++)
                {
                Console.WriteLine(" ");
                Console.WriteLine(i);
                }
            Console.ReadLine();
            
            //EJERCICIO 2 BUCLES
            int i;
            i=20;
            while (i>=10)
                {
                Console.WriteLine(i);
                Console.WriteLine(" ");
                i--;
                }
            Console.ReadLine();
            

            //EJERCICIO 3 BUCLES
            //sacar media

            int num;
            int media=0;
            for (int i=0; i<9; i++)
            {
              Console.WriteLine("Escribe un número");
              num=Int32.Parse(Console.ReadLine());
              media= media+num;
            }
            Console.WriteLine("La media es " + media/10);
            Console.ReadLine();
            
            
            //EJERCICIO 4 BUCLES

            int num;
            int suma=0;
            Console.WriteLine("Escribe un número");
            num=Int32.Parse(Console.ReadLine());
            suma=suma+num;
            while (num!=0)
            {
            Console.WriteLine("Escribe un número");
            num=Int32.Parse(Console.ReadLine());
                if (num<0)
                {
                  Console.WriteLine("No acepto valores negativos");
                }
                else
                {
                suma=suma+num;
                }

            }
            Console.WriteLine("la suma es " + suma);

            

            //EJERCICIO 5   
            int i;
            String respuesta = "";
            while (respuesta!="P" && respuesta != "I")
            {
            Console.WriteLine("Escribe P o I");
            respuesta=Console.ReadLine();
            
            }
            if(respuesta=="P")
            {
                    for (i=0; i<=100; i=i+2)
                    {
                    Console.WriteLine(i);
                    }
            }
            else
            {
                if (respuesta=="I")
                {
                    for (i=1; i<=99; i=i+2)
                    {
                    Console.WriteLine(i);
                    }
            }
            
            }
           
           
            //EJERCICIO 6
            
            int i,edad;
            Console.WriteLine("Cual es tu edad?");
            edad=Int32.Parse(Console.ReadLine());
            for (i=0; i<edad; i++ )
            {
                Console.WriteLine("Feliz Cumpleaños");
            }
           
            
            //EJERCICIO 7
            
            int num,i,j;
            Console.WriteLine("Escribe un número");
            num=Int32.Parse(Console.ReadLine());
            for(i=0; i<num; i++)
            {
                for(j=0; j<=i; j++)
                {
                    Console.Write("*");
                }

            Console.WriteLine();
            }

             

            //EJERCICIO 8
            int i;
           
            for (i=0; i<=12; i++)
            {
                if (i%2==0)
                {
                    Console.WriteLine(i + " \t " + Math.Pow(i, 3));
                }
                else
                {
                    Console.WriteLine(i + " \t " + Math.Pow(i, 2));
                }
                Console.WriteLine();
            }

            
            //EJERCICIO 9
            //Mostrar en pantalla diez números, siendo el primero 1 y los siguientes la suma del número anterior y 5.

            int suma =1;
            for(int i=0; i<=10; i++)
            {
                Console.WriteLine(suma);
                suma += 5;                
            }
            
            
            //EJERCICIO 10
          
            int num;
            int suma=0;   
             Console.WriteLine("Escribe un número");
              num=Int32.Parse(Console.ReadLine());
            for (int i=1; i<=num; i++)
            {
                if(i == num)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + "+");        
                }
              suma= suma+i;
            }
            Console.WriteLine(" " + suma);
            
            
            //EJERCICIO 11
            
            int num;
            int suma=0;   
            Console.WriteLine("Escribe un número");
            num=Int32.Parse(Console.ReadLine());
            if (num!=0)
            {
  
                for (int i=1; i<=num; i++)
                {        
                suma= suma+i;
                }
            Console.WriteLine(suma);
            }
            else
                Console.ReadLine();

            **/
            //EJERCICIO 12
            
            int num;

            Console.WriteLine("Escribe un número");
            num=Int32.Parse(Console.ReadLine());
            if (num!=0)
            {
                
            }

    


            Console.ReadLine();

        }
        
    }
}
