using System;

namespace Pulsacion
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            string nombre;
            int edad;
            char sexo;
            char repetir = 's';
            Console.WriteLine("   CALCULADORA DE PULSACIONES   ");
            Console.WriteLine("    ");
            do
            {
                Console.WriteLine("INGRESE EL NOMBRE DE DEL PACIENTE: "); nombre = Console.ReadLine();
                Console.WriteLine("INGRESE LA EDAD DEL PACIENTE: "); edad = int.Parse(Console.ReadLine());
                Console.WriteLine("INGRESE EL SEXO M-> MASCULINO O F->FEMENINO: "); sexo =char.ToUpper( char.Parse(Console.ReadLine()));
                Console.WriteLine("    ");

                if (sexo == 'M')
                {
                    int pulsacion = (220-edad)/10;
                    Console.WriteLine(nombre+ " sus pulsaciones son: " + pulsacion);
                }
                else
                {
                    int pulsacion = (210 - edad) / 10;
                    Console.WriteLine(nombre + " sus pulsaciones son: " + pulsacion);
                }
                Console.WriteLine("    ");
                Console.WriteLine("quiere seguir calculando las pulsaciones s->si o n->no : "); repetir = char.Parse(Console.ReadLine());

            } while (repetir=='s');
        }
    }
}
