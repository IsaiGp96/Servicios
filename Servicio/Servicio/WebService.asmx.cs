using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Servicio
{
    /// <summary>
    /// Descripción breve de WebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public string Saludo(string nombre)
        {
            return "Hola " + nombre;
        }
        [WebMethod]
        public string GuardarLog(string mensaje)
        {
            Funciones.Logs("LogsServicios", mensaje);
            return "Ok";
        }

        [WebMethod]
        public int Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;
            return resultado;
        }

        [WebMethod(Description = "Consumo de vector")]
        public string [] Vector()
        {
            string[] Estaciones = new string[4];
            Estaciones[0] = "Invierno";
            Estaciones[1] = "Primavera";
            Estaciones[2] = "Verano";
            Estaciones[3] = "Otoño";

            return Estaciones;
        }

        [WebMethod(Description = "Recibe vector y guarda en txt")]
        public string GuardarVector(string[] Objetos)
        {
            foreach (string Objeto in Objetos)
            {
                Funciones.Logs("ArchivoVector", Objeto);
            }

            return "Guardado con éxito";
        }
    }
}