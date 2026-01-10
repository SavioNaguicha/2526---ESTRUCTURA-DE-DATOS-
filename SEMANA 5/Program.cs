//1.Escribir un programa que almacene las asignaturas de un curso (por ejemplo Matemáticas, Física, Química, Historia y Lengua)
//en una lista y la muestre por pantalla el mensaje Yo estudio <asignatura>, donde <asignatura> es cada una de las asignaturas de la lista.

using System;

namespace MyAPP
{
    // Definición de la clase Curso
    class Curso
    {
        // Propiedades (PascalCase con tildes)
        public string Matemáticas { get; set; }
        public string Física { get; set; }
        public string Química { get; set; }
        public string Historia { get; set; }
        public string Lenguaje { get; set; }

        // Constructor para asignar valores
        public Curso(string matemáticas, string física, string química, string historia, string lenguaje)
        {
            this.Matemáticas = matemáticas;
            this.Física = física;
            this.Química = química;
            this.Historia = historia;
            this.Lenguaje = lenguaje;
        }

        // Método para mostrar las materias en consola
        public void MostrarMaterias()
        {
            // Se usan tildes exactas para evitar el error CS0103 visto en tu terminal
            Console.WriteLine("\n" + new string('=', 45));
            Console.WriteLine($"{"MATERIA", -15} | {"DESCRIPCIÓN DEL ESTUDIO"}");
            Console.WriteLine(new string('-', 45));

            // Filas alineadas perfectamente
            Console.WriteLine($"{"Matemáticas", -15} | {Matemáticas}");
            Console.WriteLine($"{"Física", -15} | {Física}");
            Console.WriteLine($"{"Química", -15} | {Química}");
            Console.WriteLine($"{"Historia", -15} | {Historia}");
            Console.WriteLine($"{"Lenguaje", -15} | {Lenguaje}");
            Console.WriteLine(new string('=', 45) + "\n");

        }
    }

    // Clase Program: Punto de entrada para evitar el error CS5001
    class Program
    {
        static void Main(string[] args)
        {
            // Crear el objeto
            Curso miCurso = new Curso("Yo estudio: Matemáticas I", "Yo estudio Física II", "Yo estudio: Química ", "Yo estudio: Historia", "Yo estudio: Lenguaje");
            
            // Llamar al método
            miCurso.MostrarMaterias();
        }
    }
}

        

   
        
                



            
        








    


    





    


            
    




    









    









    




        



