using System;

namespace Financiera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("         BIENVENIDO BANCOS UPC    ");
            Console.WriteLine("    ");
            

            string Nombre;
            long numeroCuenta,totalCuenta = 0, puesto, Retiro,
                    saldoApertura ;
            int Op;
            char repetir;

            Console.Write("    Escriba su nombre:  "); Nombre = Console.ReadLine();
            Console.Write("    Numero de cuenta: "); numeroCuenta = long.Parse(Console.ReadLine());
            Console.Write("    Cual es su saldo de apertura:   "); saldoApertura = long.Parse(Console.ReadLine());
            Console.WriteLine("    ");

            do
            {
                Console.WriteLine("¿QUE DESEAS HACER EL DIA DE HOY?");
                Console.WriteLine("    ");

                Console.WriteLine("1.Consignar a cuenta ");
                Console.WriteLine("2.Retirar saldo de la cuenta ");
                Console.WriteLine("3.Ver saldo de la cuenta ");

                Console.WriteLine("    ");

                Console.Write("digite la opcion que desea realizar: "); Op = int.Parse(Console.ReadLine());
                switch (Op){

                    case 1:
                        Console.Clear();
                        Console.Write("Cuanto desea consignar: "); puesto = long.Parse(Console.ReadLine());
                        totalCuenta = puesto + saldoApertura;
                        Console.WriteLine("su consignacion se ha realizado con exito......");

                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("Cuanto desea retirar: "); Retiro = long.Parse(Console.ReadLine());
                        

                        if (totalCuenta > Retiro)
                        {
                           totalCuenta = saldoApertura - Retiro;
                            Console.WriteLine("su retiro se ha realizado con exito......");
                        }
                        else
                        {
                            Console.WriteLine("no se puede realizar operacion......");
                        }
                        
                           break;
                        
                    case 3:
                        Console.Clear();
                        if(totalCuenta==0){
             
                            Console.WriteLine("su saldo de cuenta es: " + saldoApertura);
                        }
                        else
                        {
                            Console.WriteLine("su saldo de cuenta es: " + totalCuenta);
                        }
                        
                        break;
                };
                
                Console.Write(" desea repetir operaciones s->si n->no:   "); repetir = char.Parse(Console.ReadLine());

            }while(repetir=='s');
        }

    }
}
