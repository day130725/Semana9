using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MIBIBLIOTECA;

namespace Semana9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 day = new Class1();
            //day.sumar();
            //Console.ReadKey();

            int resultado = 0;

            resultado = 10;
            day.Resta(ref resultado);
            Console.WriteLine("la resta es: "+ resultado);
            
            Calculadora c = new Calculadora();
            int r2;
            c.multiplicar(out r2);
            Console.WriteLine("la Multiplicacion es: " + r2);

            Console.ReadKey();
        }
    }
}
