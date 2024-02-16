using System;

namespace Tarea_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que opcion requiere \n1.- Automovil\n2.-Tractor");
            byte opcion = Convert.ToByte(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    var auto = new Automovil();
                    break;

                case 2:
                    var tractor = new Tractor();
                    break;
            }
            Console.ReadLine();
        }
    }
}
