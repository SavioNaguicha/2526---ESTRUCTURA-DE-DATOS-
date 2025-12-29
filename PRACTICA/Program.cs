// Practico Experimental N. 1
//Agenda telefónica.
// Agenda de turnos de pacientes de una clínica
//Software de registro de aportes de integrantes de una asociación de empleados de una institución.

using System;
class Program
{
    struct Agendatefonica
    {
        public string nombre;
        public string contacto;
        public string email;
        public string direccion;
        public string telefono_fijo_de_trabajo;


    static void Main(string[] args)
    {
        Agendatefonica agendatefonica1;


        agendatefonica1.nombre = "Savio";
        agendatefonica1.contacto =  " 0939060853";
        agendatefonica1.email = "savionaguicha@gmail.com";
        agendatefonica1.direccion = "centro de Quito";
        agendatefonica1.telefono_fijo_de_trabajo = "2536958";


        Console.WriteLine(" El nombre es: {0}", agendatefonica1.nombre);
        Console.WriteLine(" El contacto es: {0}", agendatefonica1.contacto);
        Console.WriteLine(" La direccion es: {0}", agendatefonica1.direccion);
        Console.WriteLine(" El telefono fijo es: {0}", agendatefonica1. telefono_fijo_de_trabajo);

        


        Console.Read();


    }
    }
}
