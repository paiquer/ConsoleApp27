using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {

            // Preguntar al usuario su edad, que se guardará en un "byte".A continuación, se deberá le deberá decir que no aparenta tantos años(por ejemplo, "No aparentas 20 años").
            byte edad;
               Console.WriteLine("Cual es su edad?");
               edad = byte.Parse(Console.ReadLine());
               Console.WriteLine("Usted aparenta de: " + edad + " años");
               Console.ReadLine();


               // Pedir al usuario dos números enteros largos("long") y mostrar su suma, su resta y su producto.
               long r;
               Console.WriteLine("Escriba dos numeros largos");

               Console.WriteLine("Digite el primero");
               long numero = long.Parse(Console.ReadLine());
               Console.WriteLine("Digite el segundo ");
               long numer1 = long.Parse(Console.ReadLine());
               r = numero + numer1;
               Console.WriteLine("La suma de ambos numeros es igual a: " + r);
               r = numero - numer1;
               Console.WriteLine("La resta de ambos numeros es igual a: " + r);
               r = numero * numer1;
               Console.WriteLine("El producto de ambos numeros es igual a: " + r);
               Console.ReadLine();
               //Crear un programa que use tres variables x,y,z. Sus valores iniciales serán 15, -10, 2.147.483.647. Se deberá incrementar tres vece el valor de estas variables. Mostrar en pantalla el valor incial de las variables y el valor final obtenido por el programa.
               int x = 15;
              int y = -10;

               x *= 3;
               y *= 3;

               Console.WriteLine("El valor inicial de x era 15 ahora es:" + x);
               Console.WriteLine("El valor inicial de y era -10 ahora es:" + y);
              long z = 2147483647;
               z *= 3;
               Console.WriteLine("El valor inicial de z era 2.147.483.647 ahora es:" + z);
               Console.ReadKey();
             //¿Cuál sería el resultado de las siguientes operaciones? a = 5; b = ++a; c = a++; b = b * 5; a = a * 2;
             int p;
             int a = 5;
             int b = ++a;
             int c = a++;
             Console.WriteLine("El resultado del primer ejercicio es: " + b + " Presione enter para seguir");
             Console.ReadLine();
             Console.WriteLine("El resultado del segundo ejercicio es: " + c + " Presione enter para seguir");
             Console.ReadLine();
             p = b = b * 5;
             Console.WriteLine("El resultado del tercer ejercicio es: " + p + " Presione enter para seguir");
             Console.ReadLine();
             p= a = a * 2;
             Console.WriteLine("El resultado del ultimo ejercicio es: " + p + " Presione enter para salir");
             Console.ReadLine();

            //¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; c=-3; c*=2; ++c; a*=b;

            int m;
            int A = 5;
           int B = a + 2;
           int C = -3;
            Console.WriteLine("El resultado del primer ejercicio es: " + b + " Presione enter para seguir");
            Console.ReadLine();
            Console.WriteLine("El resultado del segundo ejercicio es: " + C + " Presione enter para seguir");
            Console.ReadLine();
            m=  C = -3;
            Console.WriteLine("El resultado del tercer ejercicio es: " + m + " Presione enter para seguir");
            Console.ReadLine();
            m =  C *= 2;
            Console.WriteLine("El resultado del cuarto ejercicio es: " + m + " Presione enter para seguir");
            Console.ReadLine();
            m = ++C;
            Console.WriteLine("El resultado del quinto ejercicio es: " + m + " Presione enter para seguir");
            Console.ReadLine();
            m = A *= B;
            Console.WriteLine("El resultado del ultimo ejercicio es: " + m + " Presione enter para salir");
            Console.ReadLine();
            //Calcular el área de un círculo, dado su radio (pi * radio al cuadrado).
            Double rs = 3.1416;
            Double raiz;
            Console.WriteLine("ingrese el valor del radio");
           Double radio = double.Parse(Console.ReadLine());

            raiz = Math.Pow(radio, 2);

            radio = rs * raiz;
            
            Console.WriteLine("el resultado es:" + radio);
            Console.ReadKey();
            //Crear un programa que pida al usuario a una distancia (en metros) y el tiempo necesario para recorrerla (como tres números: horas, minutos, segundos), y muestre la velocidad, en metros por segundo, en kilómetros por hora y en millas por hora (pista: 1 milla = 1.609 metros).

            
            Console.WriteLine("Digite una distancia en metros");
            int metros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cual fue la cantidad de horas que duro el recorrido");
            int hora = Convert.ToInt32(Console.ReadLine());
            int segundos = (hora * 60 * 60);
            int velocidad = metros / segundos;
            Console.WriteLine("Su velocidad es de: " + velocidad + "m/s");
            double kilo = metros / 1000;
            Console.WriteLine("kilometros" + kilo + "km/h");
            double millas = kilo / 1.609;
            Console.WriteLine("Millas" + millas + "m/h");
            Console.ReadLine();



        }
    }
}
