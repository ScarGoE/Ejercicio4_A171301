using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C_Areas
{
    public class calcular
    {
        public decimal Numero1 { get; set; }
        public decimal Numero2 { get; set; }
        public decimal Area_Cuadrado()
        {
            return Numero1 * Numero2;        
        }
        public decimal Area_Circulo(decimal N1)
        {
            Numero1 = N1;
            double Pi, N;
            Pi = 3.1416;
            N = Convert.ToDouble (Numero1);
            //Pi = convert.todouble(3.1416);
            return Convert.ToDecimal(Pi * N * N);
        }
        public decimal Area_Triangulo(decimal N1, decimal N2)
        {
            Numero1 = N1;
            Numero2 = N2;
            var Resultado = ((N1 * N2) / 2);
            return Resultado;
        }
    }
}