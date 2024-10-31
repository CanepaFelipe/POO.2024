﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO._2024
{
    public class Estudiante : Persona
    {
        public string Carrera { get; set; }
        public decimal Promedio { get; private set; }

        public Estudiante(string nombre, string apellido, int edad, string carrera, decimal promedio) : base(nombre, apellido, edad)
        {
            Carrera = carrera;
            Promedio = promedio;
        }

        public void ActualizarPromedio(decimal nuevoPromedio)
        {
            Promedio = nuevoPromedio;
        }
    }
}
