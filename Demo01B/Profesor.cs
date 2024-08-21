using System;

namespace Demo01B
{
    internal class Profesor : Persona
    {
        public double Sueldo { get; set; }

        public double CalcularSueldoNeto()
        {
            double descuento = CalcularDescuento();
            return Sueldo - descuento;
        }

        public double CalcularDescuento()
        {
            double descuento = 0.0;

            if (Sueldo > 0 && Sueldo <= 2000)
            {
                descuento = Sueldo * 0.08;
            }
            else if (Sueldo > 2000 && Sueldo <= 5000)
            {
                descuento = Sueldo * 0.14;
            }
            else if (Sueldo > 5000 && Sueldo <= 7000)
            {
                descuento = Sueldo * 0.30;
            }
            else if (Sueldo > 7000)
            {
                descuento = Sueldo * 0.30; 
            }

            return descuento;
        }
    }
}
