using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{

    public class Publicacion
        //Creamos las variables que vamos a utilizar
    {
        public string titulo;
        public float precio;

        public Publicacion(string titulo, float precio)
        //Creamos el constructor de la clase
        {
            this.titulo = titulo;//Hacemos uso de la palabra reservada this para referirnos a la variable de la clase
            this.precio = precio;
        }

        public virtual void mostrarDatos()
            //Creamos el método para mostrar los datos
        {
            Console.WriteLine("Título: {0}", titulo);
            Console.WriteLine("Precio: {0}", precio);
        }
    }

    public class Libro : Publicacion
    //Creamos la clase libro que hereda de la clase publicación
    {
        private int numPaginas;
        private int añoPublicacion;

        public Libro(string titulo, float precio, int numPaginas, int anioPublicacion) : base(titulo, precio)
        {
            this.numPaginas = numPaginas;
            this.añoPublicacion = anioPublicacion;
        }

        public override void mostrarDatos()
        //Creamos el método para mostrar los datos
        //Hacemos uso de la palabra reservada override para sobreescribir el método de la clase padre
        {
            base.mostrarDatos(); //Hacemos uso de la palabra reservada base para llamar al método de la clase padre y usar los datos que ya tenemos
            Console.WriteLine("Número de páginas: {0}", numPaginas);
            Console.WriteLine("Año de publicación: {0}", añoPublicacion);
        }
    }

    public class Disco : Publicacion
    {
        //Creamos la clase disco que hereda de la clase publicación
        private double duracionMinutos;

        public Disco(string titulo, float precio, double duracionMinutos) : base(titulo, precio)
        {
            this.duracionMinutos = duracionMinutos;
        }

        public override void mostrarDatos()
            //Creamos el método para mostrar los datos
            //Hacemos uso de la palabra reservada override para sobreescribir el método de la clase padre
        {
            base.mostrarDatos(); //Hacemos uso de la palabra reservada base para llamar al método de la clase padre y usar los datos que ya tenemos
            Console.WriteLine("Duración en minutos: {0}", duracionMinutos);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro = new Libro("El Quijote", 19.99f, 863, 1605);
            libro.mostrarDatos();

            Disco disco = new Disco("Thriller", 9.99f, 42.4);
            disco.mostrarDatos();
        }
    }
}
