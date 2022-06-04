using System;

namespace Geometria
{    public class GeometriaArea
    {
        public double Area { get; set; }
        public String cor { get; set; }

       public double CalcularAreaRetangulo(Double basev,double altura){
           double resultado = basev * altura;
           this.Area = resultado;

           return resultado;

        }
        // tipo é I = isoceles, E = equiulatero , R = Triangulo retangulo
        public double CalcularAreaTriangulo(double a,double b,double c ,string tipo) {
           double resultado ;
           if (tipo == "r") {
              resultado = (a* b)/2;
            } else if (tipo == "e"){
              resultado =(b *b* Math.Sqrt(3))/4;
            } else if (tipo == "i"){
                resultado =2;
            }else{
                resultado =1;
            }
            return resultado;


        }
      public double CalcularAreaTrapezio(double b,double B,double h) {
         return ((Bb)h)/2;
      }
    }
}
