using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_7
{

    public class Motor
    {
        //campos
        private int _numero;
        private double _potencia;
        //propiedades de la clase Motor
        public int numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public double potencia
        {
            get { return _potencia; }
            set { _potencia = value; }
        }
    }

    public class Chassis
    {
        //campos
        private int _numero;
        private double _peso;

        //propiedades de la clase Chassis
        public int numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public double peso
        {
            get { return _peso; }
            set { _peso = value; }
        }
    }

    public class Camion
    {   //campos
        private string _marca;
        private string _modelo;
        private Color _color;
        private Motor _motor;
        private Chassis _chassis;

        //constructor de la clase Camion
        public Camion(string marca, string modelo, Color color, Motor motor, Chassis chassis)
        {
            _marca = marca;
            _modelo = modelo;
            _color = color;
            _motor = motor;
            _chassis = chassis;
        }
        //metodo que muestra los valores de todos los campos del Camion
        public void imprimirDatos()
        {
            Console.WriteLine("Marca: " + _marca);
            Console.WriteLine("Modelo: " + _modelo);
            Console.WriteLine("Color: " + _color.ToString());
            Console.WriteLine("Motor - Número: " + _motor.numero);
            Console.WriteLine("Motor - Potencia: " + _motor.potencia);
            Console.WriteLine("Chassis - Número: " + _chassis.numero);
            Console.WriteLine("Chassis - Peso: " + _chassis.peso);
        }
        //enumeración llamada 'Color' que define las opciones posibles de color para un objeto de la clase Camion 
        public enum Color
        {
            Rojo,
            Verde,
            Azul,
            Negro,
            Amarillo,
            Gris
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            // Crear instancias de Camion
            Motor motor1 = new Motor();
            motor1.numero = 1;
            motor1.potencia = 200.5;

            Chassis chassis1 = new Chassis();
            chassis1.numero = 1;
            chassis1.peso = 1500.0;

            Camion camion1 = new Camion("Marca1", "Modelo1", Camion.Color.Rojo, motor1, chassis1);

            Motor motor2 = new Motor();
            motor2.numero = 2;
            motor2.potencia = 300.0;

            Chassis chassis2 = new Chassis();
            chassis2.numero = 2;
            chassis2.peso = 2000.0;

            Camion camion2 = new Camion("Marca2", "Modelo2", Camion.Color.Azul, motor2, chassis2);

            // Imprimir datos de los camiones
            Console.WriteLine("Datos del Camión 1:");
            camion1.imprimirDatos();

            Console.WriteLine();

            Console.WriteLine("Datos del Camión 2:");
            camion2.imprimirDatos();
        }
    }


}

