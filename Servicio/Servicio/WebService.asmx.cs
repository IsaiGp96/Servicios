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

    }
}
