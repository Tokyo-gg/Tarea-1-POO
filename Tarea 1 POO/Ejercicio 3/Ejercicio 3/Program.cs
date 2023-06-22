using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    public abstract class Persona //Clase abstracta persona
    {
        public string nombre;
        public string direccion;

        public Persona(string nombre, string direccion) //Constructor por defecto persona
        {
            this.nombre = nombre;
            this.direccion = direccion;
        }


        //Metodos abstractos (vacios) que se implementaran en las clases hijas
        public abstract void Divertirse(); 
        public abstract void MostrarDatos();
    }

    public class Estudiante : Persona //Estudiante hereda de persona
    {
        public string numeroCuenta;
        public double indiceAcademico;

        public Estudiante(string nombre, string direccion, string numeroCuenta, double indiceAcademico) : base(nombre, direccion) //Constructor de estudiante
        {
            this.numeroCuenta = numeroCuenta;
            this.indiceAcademico = indiceAcademico;
        }

        public override void Divertirse() //Implementacion de metodo abstracto usando override
        {
            Console.WriteLine(nombre + " está haciendo algo para divertirse.");
        }

        public override void MostrarDatos() //Implementacion de metodo abstracto usando override
        {
            Console.WriteLine($"Nombre: {nombre}, Dirección: {direccion}, Número de Cuenta: {numeroCuenta}, Índice Académico: {indiceAcademico}");
        }
    }

    public class Profesor : Persona //Profesor hereda de persona
    {
        private string numeroEmpleado;
        private string jornada;

        public Profesor(string nombre, string direccion, string numeroEmpleado, string jornada) : base(nombre, direccion) //Constructor de profesor
        {
            this.numeroEmpleado = numeroEmpleado;
            this.jornada = jornada;
        }

        public override void Divertirse() //Implementacion de metodo abstracto usando override
        {
            Console.WriteLine(nombre +" está haciendo algo para divertirse.");
        }

        public override void MostrarDatos() //Implementacion de metodo abstracto usando override
        {
            Console.WriteLine($"Nombre: {nombre}, Dirección: {direccion}, Número de Empleado: {numeroEmpleado}, Jornada: {jornada}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona estudiante = new Estudiante("Juan", "Calle 123", "ABC123", 78.8); //Polimorfismo de persona a estudiante
            Persona profesor = new Profesor("Carlos", "Calle 456", "XYZ789", "Matutina"); // Polimorfismo de persona a profesor
            //Se llama a los metodos de las clases hijas

            estudiante.Divertirse();
            estudiante.MostrarDatos();

            profesor.Divertirse();
            profesor.MostrarDatos();
        }
    }

}
