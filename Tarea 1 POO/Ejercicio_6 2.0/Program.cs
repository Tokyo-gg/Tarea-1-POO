using System;

namespace Ejercicio_6
{
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
        private Color color;

        public Motor(int numero, double potencia, Color color)
        {
            this.numero = numero;
            this.potencia = potencia;
            this.color = color;
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

        public Color Color
        {
            get { return color; }
            set { color = value; }
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
        private Motor motor;
        private Chassis chassis;

        public Camion(string marca, string modelo, Color motorColor, int motorNumero, double motorPotencia, int chassisNumero, double chassisPeso)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.motor = new Motor(motorNumero, motorPotencia, motorColor);
            this.chassis = new Chassis(chassisNumero, chassisPeso);
        }
    

        public void ImprimirDatos()
        {
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + modelo);
            Console.WriteLine("Color del motor: " + motor.Color.ToString());
            Console.WriteLine("Número de motor: " + motor.Numero);
            Console.WriteLine("Potencia del motor: " + motor.Potencia);
            Console.WriteLine("Número de chasis: " + chassis.Numero);
            Console.WriteLine("Peso del chasis: " + chassis.Peso);
            Console.WriteLine();
        }



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
    }
}