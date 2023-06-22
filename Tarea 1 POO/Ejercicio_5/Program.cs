using System;

namespace Ejercicio_5
{
    public class Publicacion
    {
        protected string titulo; // Campo protegido para almacenar el título
        protected float precio; // Campo protegido para almacenar el precio

        public Publicacion(string titulo, float precio)
        {
            this.titulo = titulo;
            this.precio = precio;
        }

        public virtual void mostrarDatos()
        {
            Console.WriteLine("Título: {0}", titulo);
            Console.WriteLine("Precio: {0}", precio);
        }
    }

    public class Libro : Publicacion
    {
        private int numPaginas; // Campo privado para almacenar el número de páginas
        private int anioPublicacion; // Campo privado para almacenar el año de publicación

        public Libro(string titulo, float precio, int numPaginas, int anioPublicacion)
            : base(titulo, precio)
        {
            this.numPaginas = numPaginas;
            this.anioPublicacion = anioPublicacion;
        }

        public Libro()
            : this("Título por defecto", 0f, 0, 0) // Constructor que no recibe parámetros y asigna valores por defecto
        {
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Número de páginas: {0}", numPaginas);
            Console.WriteLine("Año de publicación: {0}", anioPublicacion);
        }
    }

    public class Disco : Publicacion
    {
        private double duracionMinutos; // Campo privado para almacenar la duración en minutos

        public Disco(string titulo, float precio, double duracionMinutos)
            : base(titulo, precio)
        {
            this.duracionMinutos = duracionMinutos;
        }

        public Disco()
            : this("Título por defecto", 0f, 0.0) // Constructor que no recibe parámetros y asigna valores por defecto
        {
        }

        public override void mostrarDatos()
        {
            base.mostrarDatos();
            Console.WriteLine("Duración en minutos: {0}", duracionMinutos);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("El Quijote", 19.99f, 863, 1605);
            Libro libro2 = new Libro();

            Disco disco1 = new Disco("Thriller", 9.99f, 42.4);
            Disco disco2 = new Disco();

            libro1.mostrarDatos();
            Console.WriteLine();

            libro2.mostrarDatos();
            Console.WriteLine();

            disco1.mostrarDatos();
            Console.WriteLine();

            disco2.mostrarDatos();
        }
    }
}