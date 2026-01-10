//CalcularArea es una función que devuelve un valor double, se utiliza para calcular el área de un circulo, requiere 
//como argumento el radio del circulo

using System;

namespace CalcularArea
{
    class Program
    {
        static void Main(string[] args)//Se crea un punto de entrada de programa
        {
            double radio = 5.0; // Se asigna los valor 5.0
            double calcular =  CalcularArea(radio); // Se crea el argumento para que guarde el resultado en la variable

            //Se crea la funcion para mostrar resulatado en la consola
            Console. WriteLine($" EL area del cicuito con radio {radio} es: {calcular:f4}");
            Console.ReadKey();
        }

            //creamos la funcion para Calcular Area 
            public static double CalcularArea(double Radio)
            {
                return Math.PI*Radio * Radio;

        }
    }
}

        
    
