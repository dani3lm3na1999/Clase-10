using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {

        // Crear una clase Libro -
        public class Libro
        {
            // Propiedades de mi clase
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public string Editorial { get; set; }
            public int Anio { get; set; }

            public Libro(string titulo, string autor, string editorial, int anio)
            {
                Titulo = titulo;
                Autor = autor;
                Editorial = editorial;
                Anio = anio;
            }   

            // Sobreescribir el método ToString()
            public override string ToString()
            {
                return $"\nTitulo: {Titulo}\nAutor: {Autor}\nAño de Publicación: {Anio}\n" + new string('-',20);
            }
        }

        static void Main(string[] args)
        {

            //int[] numeros = { 1, 2, 3, 4, 5, 6 };

            //Libro[] libros2 =
            //{
            //   new Libro("Harry Potter", "Jk Rolling", "N/A", 1990),
            //   new Libro("Harry Potter", "Jk Rolling", "N/A", 1990)
            //}; 

            // Esto es un Array.

            //ArrayList numeros = new ArrayList() { 1,2,3,4,5,6,7,8,9,10 };

            ArrayList libros = new ArrayList() // Esto es un Array List.
            {
                new Libro("El Principito", "Antonie de Saint-Exupéry", "Reynal & Hitchcock", 1943),
                new Libro("Moby Dick", "Herman Melville", "Harper & Brothers", 1851)
            };

            // menú para poder interactuar con el usuario
            int opcion = 0;
            
            do
            {
                Console.WriteLine("Bivenido a la biblioteca.");
                Console.WriteLine("Selecciona una opción: ");
                Console.WriteLine("1. Ingresar libros.\n2. Mostrar libros.\n3. Eliminar\n4. Salir");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Ingrese el titulo: ");
                    string titulo = Console.ReadLine();

                    Console.Write("Ingrese el autor: ");
                    string autor = Console.ReadLine();

                    Console.Write("Ingrese el editorial: ");
                    string editorial = Console.ReadLine();

                    Console.Write("Ingrese el año de publicación: ");
                    int anio = int.Parse(Console.ReadLine());

                    Libro newLibro = new Libro(titulo, autor, editorial, anio);

                    if (!string.IsNullOrEmpty(newLibro.Titulo) && !string.IsNullOrEmpty(newLibro.Autor) && !string.IsNullOrEmpty(newLibro.Editorial))
                    {
                        libros.Add(newLibro);
                    }
                    else
                    {
                        Console.WriteLine("\nEl titulo, autor y editorial son requeridos para poder almacenar un libro\n");
                    }

                    //libros.Add(new Libro(titulo, autor, editorial, anio));
                }
                else if(opcion == 2)
                {
                    Console.WriteLine("\nListado de libros\n");

                    // foreach
                    foreach (var libro in libros)
                    {
                        Console.WriteLine(libro.ToString());
                    }

                    //var numero = "10"; // int
                    //var mensaje = "Hola mundo"; // string
                    //var funciona = true; // booleano


                    //for (int i = 0; i < libros.Count; i++)
                    //{
                    //    Console.WriteLine(libros[i].ToString());
                    //}
                }
                else if(opcion == 3)
                {
                    Console.Write("Ingrese el titulo del libro a eliminar: ");
                    string titulo = Console.ReadLine();

                    bool encontrado = false;

                    foreach(Libro libro in libros)
                    {
                        if (libro.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase)) // libro.Titulo == titulo
                        {
                            libros.Remove(libro);
                            encontrado = true;
                            Console.WriteLine("Libro eliminado con exito.");
                            break;
                        }
                    }

                    if (!encontrado)
                    {
                        Console.WriteLine("No se encontro el libro con el titulo: {0}", titulo);
                    }
                }
                else if(opcion == 4)
                {
                    Console.WriteLine("Gracias por visitarnos.");
                }
                else
                {
                    Console.WriteLine("Opción Incorrecta. Vuelve a intentarlo.");
                }

            } while (opcion != 4);

            Console.ReadLine();
        }

        // CRUD -- CREATE, READ, UPDATE, DELETE
    }
}
