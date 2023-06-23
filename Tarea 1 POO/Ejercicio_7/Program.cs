using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dos instancias de la clase Camion
            Camion camion1 = new Camion("Ford", "F-150", Color.Azul, 1, 200.5, 1234, 1500.0);
            Camion camion2 = new Camion("Chevrolet", "Silverado", Color.Rojo, 2, 180.0, 5678, 1800.0);
            camion1.ImprimirDatos();
            camion2.ImprimirDatos();
        }
    }

    enum Color
    {
        Rojo,
        Verde,
        Azul,
        Negro,
        Amarillo,
        Gris
    }

    class Motor
    {
        private int numero;
        private double potencia;

        public Motor(int numero, double potencia)
        {
            this.numero = numero;
            this.potencia = potencia;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public double Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }
    }

    class Chassis
    {
        private int numero;
        private double peso;

        public Chassis(int numero, double peso)
        {
            this.numero = numero;
            this.peso = peso;
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public double Peso
        {
            get { return peso; }
            set { peso = value; }
        }
    }

    class Camion
    {
        private string marca;
        private string modelo;
        private Color color;
        private Motor motor;
        private Chassis chassis;

        public Camion(string marca, string modelo, Color color, int motorNumero, double motorPotencia, int chassisNumero, double chassisPeso)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.color = color;
            this.motor = new Motor(motorNumero, motorPotencia);
            this.chassis = new Chassis(chassisNumero, chassisPeso);
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Color: " + color.ToString());
            Console.WriteLine("Número de motor: " + motor.Numero);
            Console.WriteLine("Potencia del motor: " + motor.Potencia);
            Console.WriteLine("Número de chasis: " + chassis.Numero);
            Console.WriteLine("Peso del chasis: " + chassis.Peso);
            Console.WriteLine();
        }
    }
}
