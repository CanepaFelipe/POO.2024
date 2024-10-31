using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO._2024
{
    public class Socio : Persona
    {
        public List<Libro> LibrosPrestados { get; set; }
        public Socio(string nombre, string apellido, int edad) : base(nombre, apellido, edad)
        {
            LibrosPrestados = new List<Libro>();
        }

        public void AgregarLibroPrestado(Libro libro)
        {
            LibrosPrestados.Add(libro);
        }

        public void QuitarLibroPrestado(Libro libro)
        {
            LibrosPrestados.Remove(libro);
        }
    }
}
