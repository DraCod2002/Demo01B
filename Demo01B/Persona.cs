using System;

namespace Demo01B
{
    public class Persona
    {
        public Persona (string nombres, string apellidos)
        {
            Nombres = nombres;
            Apellidos = apellidos;
        }

        public Persona()
        {
        }

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public int Edad { get; set; }

        public string NombresCompletos { get; set; }

        public string EsMayorEdad()
        {
            if (Edad >= 18)
            {
                return "La persona es mayor de edad";
            }
            else
            {
                return "La persona es menor de edad";
            }

        }
        public void AsignarNombresCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }
    }
}
