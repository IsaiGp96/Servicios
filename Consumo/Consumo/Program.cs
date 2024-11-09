using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceReference1.WebServiceSoapClient cliente = new ServiceReference1.WebServiceSoapClient();
            /*Ejercicio 1*/
            /*string result = cliente.HelloWorld();
            
            Console.WriteLine(result);*/

            /*Ejercicio 2*/
            /*Console.WriteLine("Introduce tu nombre");
            
            string nombre = Console.ReadLine();

            string results = cliente.Saludo(nombre);

            Console.WriteLine(results);*/

            /*Ejercicio 3*/
            /*Console.WriteLine("Introduce tu mensaje");
            
            string mensaje = Console.ReadLine();

            string results2 = cliente.GuardarLog(mensaje);

            Console.WriteLine(results2);*/

            /*Ejercicio 4*/
            Console.WriteLine("Introduce dos valores");

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            int result = cliente.Sumar(num1, num2);
            Console.WriteLine("El resultado de la operación es: " + result);

            Console.ReadLine();
        }
    }
}
