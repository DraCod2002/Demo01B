﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01B
{
    internal class Program
    {
        static void Main(string[] args)

            
        {
            Persona persona = new Persona();
            persona.Nombres = "Pedro";
            persona.Apellidos = "Hernandez Carhuajulca";

            Persona persona1 = new Persona("Luisa", "Herrera");

            Persona persona2 = new Persona
            {
                Nombres = "Luisa",
                Apellidos = "Herrera",
                Edad = 5
            };
            persona.AsignarNombresCompletos();

            //Triangulo triangulo = new Triangulo();
            //triangulo.Altura = 5;
            //triangulo.Base = 6;
            //triangulo.CalcularArea();


            //Console.WriteLine(triangulo.CalcularArea());
            //Console.WriteLine(persona.NombresCompletos);
            //Console.WriteLine("Hola Mundo");
            Console.Read();


            Estudiante estudiante = new Estudiante
            {
                Nombres = "Pedro",
                Apellidos = "Hernandez",
                Nota = 20
            };



            Triangulo tri = new Triangulo
            {
                X1 = 0,
                Y1 = 0,
                X2 = 4,
                Y2 = 0,
                X3 = 4,
                Y3 = 3
            };

  
            Console.WriteLine($"Perímetro del triángulo: {tri.Perimetro}");
            Console.WriteLine($"Área del triángulo: {tri.Area}");

        }

    }
}
