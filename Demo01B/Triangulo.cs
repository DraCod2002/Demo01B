using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Triangulo
{
  
    public double X1 { get; set; }
    public double Y1 { get; set; }
    public double X2 { get; set; }
    public double Y2 { get; set; }
    public double X3 { get; set; }
    public double Y3 { get; set; }

    public double Perimetro
    {
        get
        {
            return CalcarPerimetro();
        }
    }

    public double Area
    {
        get
        {
            return CalcularArea();
        }
    }

 
    public double CalcarPerimetro()
    {
        double a = Distancia(X1, Y1, X2, Y2);
        double b = Distancia(X2, Y2, X3, Y3);
        double c = Distancia(X3, Y3, X1, Y1);

        return a + b + c;
    }


    public double CalcularArea()
    {
        double a = Distancia(X1, Y1, X2, Y2);
        double b = Distancia(X2, Y2, X3, Y3);
        double c = Distancia(X3, Y3, X1, Y1);

        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

   
    private double Distancia(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }
}
