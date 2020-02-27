using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            // Empleado
            Empleado empleado =
            new Empleado("Maria", "Perez Juarez", new DateTime(2012, 2, 2), 1500, 0.0);
            string datos = empleado.datos();
            Console.WriteLine(datos);
            empleado.setIncremento(0.05);
            datos = empleado.datos();
            Console.WriteLine(datos);

            // Secretaria
            Empleado secretaria =
            new Secretaria("1234 ", "Juana", "Velazques", new DateTime(2015, 3, 12), 152300, 0.5);
            datos = secretaria.datos();
            Console.WriteLine(datos);
            secretaria.setIncremento(0.05);
            datos = secretaria.datos();
            Console.WriteLine(datos);

            // vendedor
            Empleado vendedor = new Vendedor
            (new Vehiculo("toyota", "yaris", "PD125-q"), "77663480", "Pedro", "X",
            new DateTime(2019, 12, 31), 152300, 0.1);
            datos = vendedor.datos();
            Console.WriteLine(datos);
            vendedor.setIncremento(0.1);
            datos = vendedor.datos();
            Console.WriteLine(datos);


        }
    }
}
