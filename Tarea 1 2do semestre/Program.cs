using System;

namespace Tarea_1_2do_semestre
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string Nom_Alumno, Estatura, Peso, Grado, Seccion;


            Console.WriteLine("BIENVENIDO A DATOS ESCOLARES, POR FAVOR INGRESA TUS DATOS PARA GUADARLOS EN CONSOLA");
            Console.WriteLine("POR FAVOR ESCRIBE TU NOMBLE COMPLETO A CONTINUACION");
            Nom_Alumno = Console.ReadLine();
            Console.WriteLine("INGRESA POR FAVOR TU ESTATURA");
            Estatura = Console.ReadLine();
            Console.WriteLine("INGRESA TU PESO CORPORAL");
            Peso = Console.ReadLine();
            Console.WriteLine("A CONTINUACION ESCRIBE TU GRADO POR FAVOR");
            Grado = Console.ReadLine();
            Console.WriteLine("POSTERIORMENTE INGRESA EN QUE SECCION ESTAS");
            Seccion = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("TU NOMBRE ES " + Nom_Alumno);
            Console.WriteLine("TU ESTATURA ES " + Estatura);
            Console.WriteLine("TU PESO ES " + Peso);
            Console.WriteLine("TU GRADO ES " + Grado);
            Console.WriteLine("TU SECCION ES " + Seccion);
            Console.WriteLine("");
            Console.WriteLine("TU INFORMACION ES CORRECTA? \n1. SI \n2. NO");
            string respuesta = Console.ReadLine();

            if (respuesta == "1")
            {
                Console.WriteLine("PERFECTO SUBIREMOS TUS DATOS AL SISTEMA \n MUCHAS GRACIAS POR LLENAR LOS DATOS");
            }
            if (respuesta == "2")
            {
                Console.WriteLine("POR FAVOR CHECA BIEN Y CORRIGELOS :D");
            }

            Console.ReadKey();

        }
    }
}
