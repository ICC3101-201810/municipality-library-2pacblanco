using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Reflection;

namespace Assemblys
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly a = Assembly.LoadFile("C:\\Users\\usuario\\Desktop\\municipality-library-2pacblanco\\ClassLibrary1.dll");

            Type[] typeInfos = a.GetTypes(); 

            foreach(Type t in typeInfos)
            {
                Console.WriteLine("Tipos: \n");
                Console.WriteLine(t.FullName);
                MethodInfo[] methods = t.GetMethods();
                PropertyInfo[] properties = t.GetProperties();
                Console.WriteLine("Clases {0}", t.FullName);
                foreach(PropertyInfo propiedad in properties)
                {
                    Console.WriteLine("nombre propiedad: {0}", propiedad.Name);
                    Console.WriteLine("tipo propiedad:{0} ", propiedad.PropertyType.Name);
                    Console.WriteLine("la podemos leer?: {0}", propiedad.CanRead.ToString());
                    Console.WriteLine("la podemos escribir?: {0}", propiedad.CanWrite.ToString());

                }
                foreach (MethodInfo m in methods)
                {
                    Console.WriteLine("Nombre methodo: {0} ", m.Name);
                    Console.WriteLine("que tipo de metodo es?: {0}", m.ReturnType);
                    ParameterInfo[] parametros = m.GetParameters();
                    foreach(ParameterInfo p in parametros)
                    {
                        Console.WriteLine("que tipo de dato entra?: {0}", p.ParameterType );
                    }
                    
                }

            }

            Console.ReadKey();

        }
    }
}
