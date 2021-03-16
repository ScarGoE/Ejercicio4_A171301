using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace C_Areas
{
    /// <summary>
    /// Descripción breve de WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
        [WebMethod]
        public decimal A_Cuadrado(decimal N1, decimal N2)
        {
            calcular c = new calcular();
            c.Numero1 = N1;
            c.Numero2 = N2;
            return c.Area_Cuadrado();
        }
        [WebMethod]
        public decimal A_Circulo(decimal N1)
        {
            calcular c = new calcular();
            return c.Area_Circulo(N1);
        }
        [WebMethod]
        public decimal A_triangulo(decimal N1, decimal N2)
        {
            calcular c = new calcular();
            return c.Area_Triangulo(N1,N2);
        }

    }
}
