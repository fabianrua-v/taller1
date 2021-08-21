using System;

namespace PromedioNota
{
    class Program
    {
        static void Main(string[] args)
        {
            char repetir='s';
            float nota1, nota2, nota3;

            Console.WriteLine("    PROMEDIOS UPC ");
            do
            {
                Console.WriteLine("Escriba la primera nota del alumno: "); nota1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escriba la segunda nota del alumno: "); nota2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Escriba la tercera nota del alumno: "); nota3 = float.Parse(Console.ReadLine());

                float totalNota =( nota1 +nota2 +nota3) /3;
                Console.WriteLine("El promedio de sus notas del alumno: "+ totalNota);
                Console.WriteLine("------------------------");
                if (totalNota < 3)
                {
                    Console.WriteLine("    El alumno ha sido reprobado su nota es menor a 3.0   ");
                }
                else
                {
                    Console.WriteLine("    Su alumbo aprobo satisfactoriamente");
                };
                Console.WriteLine("------------------------");
                Console.WriteLine("      Quieres seguir anotando mas notas s-> si o n->no: "); repetir= char.Parse(Console.ReadLine());

            } while(repetir == 's');

            if (repetir!='s')
            {
                Console.WriteLine("     Ha sido un placer atenderte.... ");
            }
        }
    }
}
