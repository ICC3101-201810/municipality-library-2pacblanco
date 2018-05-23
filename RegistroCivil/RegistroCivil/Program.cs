using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Reflection;
using ClassLibrary1;
using System.Globalization;
using System.IO;


namespace RegistroCivil
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bienvenido al registro civil ");
            Console.WriteLine("Que desea hacer? \n 1) Registrar una persona \n 2) Registrar un auto \n 3) registrar una propiedad");
            int opcion= Convert.ToInt32(Console.ReadLine());

            if (opcion==1)
            {
                Console.WriteLine("Ingrese nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su apellido: ");
                string apellido = Console.ReadLine();
                Console.WriteLine("Ingrese fecha de nacimiento: ");
                DateTime fechanac = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                Console.WriteLine("Ingrese Alma mater: ");
                string alma = Console.ReadLine();
                Console.WriteLine("Ingrese grado profesional");
                string grado = Console.ReadLine();
                Console.WriteLine("Ingrese rut: ");
                string rut = Console.ReadLine();

                Person person = new Person(nombre, apellido, fechanac, null, rut, null, null);
                
            }
            if (opcion == 2)
            {
                Console.WriteLine("Ingrese calle: ");
                string calle = Console.ReadLine();
                Console.WriteLine("Ingrese numero casa: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese comuna: ");
                string comuna = Console.ReadLine();
                Console.WriteLine("Ingrese ciudad: ");
                string ciudad = Console.ReadLine();
                Console.WriteLine("Ingrese año construccion");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese numero de piezas: ");
                int piezas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese numero de baños: ");
                int baños = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese 1 si tiene patio, 0 si no tiene");
                int opcionpatio = Convert.ToInt32(Console.ReadLine());
                bool patio;
                if (opcionpatio == 1)
                { patio = true;}
                else { patio = false; }

                Address casita = new Address(calle, numero, comuna, ciudad, null, year, piezas, baños, patio, false);

            }
            if (opcion == 3)
            {
                Console.WriteLine("Ingrese marca: ");
                string marca = Console.ReadLine();
                Console.WriteLine("Ingrese modelo: ");
                string modelo = Console.ReadLine();
                Console.WriteLine("Ingrese comuna: ");
                string comuna = Console.ReadLine();
                Console.WriteLine("Ingrese patente: ");
                string patente = Console.ReadLine();
                Console.WriteLine("Ingrese año auto: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese cinturones auto: ");
                int cinturones = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese 1 si es diesel, 0 si no es diesel");
                int opcionpatio1 = Convert.ToInt32(Console.ReadLine());
                bool diesel;
                if (opcionpatio1 == 1)
                { diesel = true; }
                else { diesel = false; }

                Car lambo = new Car(marca,modelo,null, patente,cinturones, diesel);
            }




        }
    }
}
