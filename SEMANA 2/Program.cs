//CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un circulo, requiere 
//como argumento el radio del circulo

using System;

namespace CalcularArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio = 5.0;
            double calcular =  CalcularArea(radio);

            //Se muestra el resulatdo en la consola
            Console. WriteLine($" EL area del cicuito con radio {radio} es: {calcular:f4}");
            Console.ReadKey();
        }

            //
            public static double CalcularArea(double Radio)
            {
                return Math.PI*Radio * Radio;
                


        }
    }
}

        
    
