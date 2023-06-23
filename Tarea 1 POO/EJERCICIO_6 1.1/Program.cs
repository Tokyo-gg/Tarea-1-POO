using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace EJERCICIO_6_1._1
{

    // Ejercicio 6 intento 5 

    // Clase Motor
    class Motor
    {
        private int _numero; // número de serie del motor (accesibilidad privada)
        private double _potencia; // potencia en caballos de fuerza del motor (accesibilidad privada)

        public double Numero // propiedad pública que devuelve el numero del motor
        {
            get { return _numero; }
        }


        public double Potencia // propiedad pública que devuelve la potencia del motor
        {
            get { return _potencia; }
        }

        public Motor(int numero, double potencia) // constructor que asigna valores iniciales para los campos del motor
        {
            _numero = numero;
            _potencia = potencia;
        }
    }

    // Clase Chassis
    class Chassis
    {
        private int _numero; // número de serie del chassis (accesibilidad privada)
        private double _peso; // peso en toneladas del chassis (accesibilidad privada)

        public int Numero // propiedad pública que devuelve el número de serie del chassis
        {
            get { return _numero; }
        }

        public double Peso // propiedad pública que devuelve el peso del chassis
        {
            get { return _peso; }
        }

        public Chassis(int numero, double peso) // constructor que asigna valores iniciales para los campos del chassis
        {
            _numero = numero;
            _peso = peso;
        }
    }

    // Clase Camión
    class Camion
    {
        public enum Color { Rojo, Verde, Azul, Negro, Amarillo, Gris }; // enumeración con los colores disponibles para el camión

        private string _marca; // marca del camión (accesibilidad privada)
        private string _modelo; // modelo del camión (accesibilidad privada)
        private Color _color; // color del camión (accesibilidad privada)
        private Motor _motor; // instancia de la clase Motor que representa el motor del camión (accesibilidad privada)
        private Chassis _chassis; // instancia de la clase Chassis que representa el chassis del camión (accesibilidad privada)

        public Camion(string marca, string modelo, Color color, Motor motor, Chassis chassis) // constructor que asigna valores iniciales para todos los campos incluyendo los datos del motor y del chassis
        {
            _marca = marca;
            _modelo = modelo;
            _color = color;
            _motor = motor;
            _chassis = chassis;
        }

        public void ImprimirDatos() // método público que muestra los valores de todos los campos del camión, incluyendo los datos del motor y del chassis
        {
            Console.WriteLine("Marca: " + _marca);
            Console.WriteLine("Modelo: " + _modelo);
            Console.WriteLine("Color: " + _color);
            Console.WriteLine("Número de serie del motor: " + _motor.Numero);
            Console.WriteLine("Potencia del motor (en caballos de fuerza): " + _motor.Potencia);
            Console.WriteLine("Número de serie del chassis: " + _chassis.Numero);
            Console.WriteLine("Peso del chassis (en toneladas): " + _chassis.Peso);
        }
    }

    // Programa principal
    class Program
    {
        static void Main(string[] args)
        {
            // Crear dos instancias de la clase Camion con diferentes valores para sus campos
            Motor motor1 = new Motor(123456, 500.0);
            Chassis chassis1 = new Chassis(654321, 10.0);
            Camion camion1 = new Camion("Volvo", "FH16", Camion.Color.Azul, motor1, chassis1);

            Motor motor2 = new Motor(789012, 600.0);
            Chassis chassis2 = new Chassis(210987, 15.0);
            Camion camion2 = new Camion("Scania", "R730", Camion.Color.Rojo, motor2, chassis2);

            // Mostrar los valores de todos los campos de cada camión
            camion1.ImprimirDatos();
            Console.WriteLine();
            camion2.ImprimirDatos();
        }
    }
}



