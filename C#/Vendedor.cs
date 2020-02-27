using System;

public class Vendedor : Empleado
{
    public string telefono;
    public Vehiculo vehiculo;
    public Vendedor(Vehiculo vehiculo, string telefono, string nombre, string apellidos, DateTime fechaIngreso, Double sueldo, Double incremento) :
    base(nombre, apellidos, fechaIngreso, sueldo, incremento)
    {
        this.telefono = telefono;
        this.vehiculo = vehiculo;
    }

    public override String datos()
    {
        string datos = base.datos();
        datos = datos + " Telefono: " +
        this.telefono + "Vehiculo: marca " + this.vehiculo.marca + " modelo: "
        + this.vehiculo.modelo + " matricula" + this.vehiculo.matricula;
        return datos;
    }

}