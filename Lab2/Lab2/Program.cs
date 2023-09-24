using Lab2.Vista;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcion = true;
            ArbolB<Persona> obj = new ArbolB<Persona>(2);
            Persona obj2 = new Persona();
            string empresa;
            string union; 
            while (opcion)
            {
                Console.Clear();
                Console.WriteLine("         Prueba de eficiencia Talent Hub");
                Console.WriteLine("Seleccione una de las siguientes opciones para realizar ");
                Console.WriteLine(" 1. Insertar registro de persona");
                Console.WriteLine(" 2. Eliminar registro de persona por el nombre y DPI");
                Console.WriteLine(" 3. Mostrar datos codificados");
                Console.WriteLine(" 4. Buscar regisrtos asociados a un DPI ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.Clear();
                        string nombreIngreso;
                        string Cumpleaños;
                        string Direccio;
                        Console.WriteLine("Personas info ingrese los datos o escriba Salir para terminar");
                            Console.WriteLine("Ingrese el nombre");
                            nombreIngreso = Console.ReadLine();
                            Console.WriteLine("Ingrese el DPI");
                            long DPI = long.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese fecha de cumpleaños mm/dd/yyy");
                            Cumpleaños = Console.ReadLine();
                            Console.WriteLine("Ingrese la direccion");
                            Direccio = Console.ReadLine();
                            Console.WriteLine("Ingrese la empresa");
                            empresa = Console.ReadLine();
                            obj2.Nombre = nombreIngreso;
                            obj2.Identificador = DPI;
                            obj2.Cumpleaños = Cumpleaños;
                            obj2.Direccion = Direccio;
                            obj2.Empresa = empresa;
                        union = empresa + nombreIngreso; 
                        Console.WriteLine("Se guardo el nombre " + obj2.Nombre + " Identificado con el DPI: " + obj2.Identificador + " Con fecha de cumpleaños " + obj2.Cumpleaños + " Y direccion: " + obj2.Direccion);
                        //string PersonasJson = JsonSerializer.Serialize(obj2); //Serealizar a formato JSON 
                        obj.Insertar(obj2);
                        System.Threading.Thread.Sleep(2000);
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Escriba el DPI y nombre de la persona que quiere eliminar");
                        string NOMElim;
                        long DPIElim;
                        NOMElim = Console.ReadLine();
                        DPIElim = long.Parse(Console.ReadLine());
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Compreso");
                        List<string> compresion = Codi.Codificacion(union = obj2.Empresa + obj2.Identificador);
                        Console.WriteLine("Mensaje sin comprimir");
                        Console.WriteLine("Empresa:  " + obj2.Empresa + " "+ " Identificador " + obj2.Identificador);
                        //"compadre_no_compro_coco"
                        System.Threading.Thread.Sleep(10000);

                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Escriba el DPI de la persona para buscar en el registro");
                        long DIP;
                        DIP = long.Parse(Console.ReadLine());
                        obj2.Identificador = DIP;
                        Persona Enco = obj.Buscar(obj.raiz2, obj2);
                        Console.WriteLine(Enco.Nombre);
                        Console.WriteLine(Enco.Identificador);
                        Console.WriteLine(Enco.Direccion);
                        Console.WriteLine(Enco.Cumpleaños);
                        Console.WriteLine(Enco.Empresa);
                        System.Threading.Thread.Sleep(9000);
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        System.Threading.Thread.Sleep(3000);
                        break;
                }
            }
        }
    }
}
