using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crea persona
            Persona persona1 = new Persona("juan", "lol", 19);
       
            // Presentarse
            persona1.Presentarse();
          

            // Crear dirección
            Direccion direccion = new Direccion("metan", 2233, "Ciudad", "Barrio");

            // Crear casa
            Casa casa = new Casa(4, "Rojo", direccion);
            casa.Habitantes.Add(persona1);
          

            // Describir casa y presentar habitantes
            Console.WriteLine(casa.DescribirCasa());
            casa.PresentarHabitantes();

            // Presentar mayores de edad
            Console.WriteLine("Mayores de edad:");
            casa.PresentarMayoresDeEdad();

            // Crear cuenta bancaria
            CuentaBancaria cuenta = new CuentaBancaria(persona1, 1000);
            cuenta.Depositar(500);
            Console.WriteLine($"Saldo actual: {cuenta.ObtenerSaldo()}");
            cuenta.Retirar(200);
            Console.WriteLine($"Saldo  del retiro: {cuenta.ObtenerSaldo()}");

            // Crear productos
            Producto producto1 = new Producto("notebook", 1000, 5);
            Producto producto2 = new Producto("tablet", 500, 10);

            // Mostrar información de productos
            producto1.MostrarInformacion();
            producto2.MostrarInformacion();

            // Crear carrito de compras
            CarritoDeCompras carrito = new CarritoDeCompras();
            carrito.AgregarProducto(producto1);
            carrito.AgregarProducto(producto2);
            Console.WriteLine($"Total del carrito: {carrito.CalculoTotal()}");

            // Crear empleado
            Empleado empleado = new Empleado("ñando", "paredes", 30, "Desarrollador", 3000);
            empleado.AumentarSalario(10);
            Console.WriteLine($"Nuevo salario de {empleado.Nombre}: {empleado.Salario}");

            // Crear estudiante
            Estudiante estudiante = new Estudiante("galio", "mordekaiser", 22, "Ingeniería", 8.5m);
            estudiante.ActualizarPromedio(9.0m);
            Console.WriteLine($"Nuevo promedio de {estudiante.Nombre}: {estudiante.Promedio}");


            //Crear biblioteca
            Biblioteca biblioteca = new Biblioteca();

            // Crear libros
            Libro libro1 = new Libro("El principito", "luis");
            Libro libro2 = new Libro("martin fierro", "jose hernandez");

            // Agregar libros a la biblioteca
            biblioteca.AgregarLibros(libro1);
            biblioteca.AgregarLibros(libro2);

            // Crear socios
            Socio socio1 = new Socio("angie", "diaz", 30);
            Socio socio2 = new Socio("jackelin", "ventura", 25);

            // Prestar libros
            biblioteca.PrestarLibro(libro1, socio1);
            biblioteca.PrestarLibro(libro2, socio2);

            // Intentar prestar un libro no disponible
            biblioteca.PrestarLibro(libro1, socio2);

            // Devolver libros
            biblioteca.DevolverLibro(libro1, socio1);
            biblioteca.DevolverLibro(libro2, socio2);

            // Intentar devolver un libro que no fue prestado
            biblioteca.DevolverLibro(libro1, socio2);

            // Mostrar libros disponibles en la biblioteca
            Console.WriteLine("\n disponibles en la biblioteca:");
            foreach (var libro in biblioteca.libros)
            {
                Console.WriteLine($"- {libro.Titulo} de {libro.Autor}");
            }
        }
    }
}
