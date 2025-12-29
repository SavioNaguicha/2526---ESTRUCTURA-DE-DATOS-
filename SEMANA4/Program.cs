
// Practico Experimental N. 1
//Agenda telefónica

using System; // Este codigo proporciona acceso a clases y estructuras fundamentales. NET

namespace Arraysobjetos //Se difine un Arraysobjetos para organizar clases.
{
public class Contacto//Creamos una clase llamado contacto 
{
    public string Telefono {get;set;} //  Se crea el constructor para la clase contacto 
    public Contacto(string telefono)//Toma telefono como argumento 
    { 
        Telefono = telefono;// Asignamos el valor del argumento telefono a la propiedad de Telefeno (objeto Contacto)
    }
}
class Program// Creamos la clase (class Program)
{
    static void Main(string[] args)// Se crea el punto de entrada con el metodo (Main)
    {
        Contacto[] listaContactos = new Contacto[10];// Se crea un arreglo de objetos contacto llamado listaContactos[10]
     
         listaContactos[0] = new Contacto("Savio Naguicha:0939060853");
         listaContactos[1] = new Contacto("Angel Zambrano:0987667776");
         listaContactos[2] = new Contacto("Daniela Sanchez:0939990999");
         listaContactos[3] = new Contacto("Carlos Romero:0984747474");
         listaContactos[4] = new Contacto("Ronald Lopez:09234576660");
         listaContactos[5] = new Contacto("Agel Romero:0987667776");
         listaContactos[6] = new Contacto("David Solorzano:0939045533");
         listaContactos[7] = new Contacto("Edgar Arevalo:0987687775");
         listaContactos[8] = new Contacto("Rodrigo Rios:0989999087");
         listaContactos[9] = new Contacto("Esteban Salazar:0987698880");
         
         //Utilizaremos la lectura con Inerpolireacion de cadeana
         //Console.WriteLine($"Primer contacto:{listaContactos[0].Telefono}");
         //Console.WriteLine($"Segundo contacto:{listaContactos[1].Telefono}");
         //Console.WriteLine($"Primer contacto:{listaContactos[2].Telefono}");
         //Console.WriteLine($"Segundo contacto:{listaContactos[3].Telefono}");
         //Console.WriteLine($"Primer contacto:{listaContactos[4].Telefono}");
         //Console.WriteLine($"Segundo contacto:{listaContactos[5].Telefono}");
         //Console.WriteLine($"Primer contacto:{listaContactos[6].Telefono}");
         // Console.WriteLine($"Segundo contacto:{listaContactos[7].Telefono}");
         //Console.WriteLine($"Segundo contacto:{listaContactos[8].Telefono}");
         // Console.WriteLine($"Primer contacto:{listaContactos[9].Telefono}");
         foreach (var c in listaContactos)//Inicia un blucle que itera a traves de cada elemento del arreglo listaContactos
            {
         
         if (c != null) // Verefica el contacto actual (c)no es nula 
         {
           Console.WriteLine($"Tel: {c.Telefono}");//Se Crea para imprimir el objeto Contacto siguiendo la propiedad telefono
            }                                       //y la Interpolarisacion de cadenas $
        }

        //Console.Read();//Con este cogido imprmimos el resultado 
        }
    }
}

        








   






