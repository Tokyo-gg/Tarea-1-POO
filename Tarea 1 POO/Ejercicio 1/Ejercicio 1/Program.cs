using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
//Ejercicio 1
{
    public class ObjetoGeometrico
    {
        public int centroX;
        public int centroY;

        public ObjetoGeometrico(int x, int y) //Constructor por defecto de la clase ObjetoGeometrico
        {
            centroX = x;
            centroY = y;
        }

        public void mostrarCentro()
        {
            Console.WriteLine("El centro de la figura es X={0} Y={1}", centroX, centroY);
        }

    }
    //Se crea la clase Circulo que hereda de la clase ObjetoGeometrico
    public class Circulo : ObjetoGeometrico
    {

        public double radio;
        public Circulo(int x, int y, double r) : base(x, y) //Usamos la palabra clave base para heredar los atributos de la clase ObjetoGeometrico
        {
            centroX = x;
            centroY = y;
            radio = r; //Variable radio para calcular el area del circulo, exclusiva de esta clase
        }
        public double calcularArea()
        {
            return Math.PI * Math.Pow(radio, 2); //Funcion para calcular el area del circulo (pi*r^2)
        }


    }

    //Se crea la clase Cuadrado que hereda de la clase ObjetoGeometrico
    public class Cuadrado : ObjetoGeometrico
    {
        public double lado;
        public Cuadrado(int x, int y, double l) : base(x, y) //Usamos la palabra clave base para heredar los atributos de la clase ObjetoGeometrico
        {
            centroX = x;
            centroY = y;
            lado = l; //Variable lado para calcular el area del cuadrado, exclusiva de esta clase
        }
        public double calcularArea()
        {
            return Math.Pow(lado, 2);//Funcion para calcular el area del cuadrado (lado^2)
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Prueba de funcionamiento de las clases
            Circulo circulo = new Circulo(3, 2, 5); //Parametros editables para el circulo
            Cuadrado cuadrado = new Cuadrado(2, 6, 4);//Parametros editables para el cuadrado
            ObjetoGeometrico triangulo = new ObjetoGeometrico(2, 3); //Objeto por defecto de la clase ObjetoGeometrico

            triangulo.mostrarCentro();

            circulo.mostrarCentro();
            Console.WriteLine("El área del círculo es: {0}", circulo.calcularArea());

            cuadrado.mostrarCentro();
            Console.WriteLine("El área del cuadrado es: {0}", cuadrado.calcularArea());
        }
    }
}
