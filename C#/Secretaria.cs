using System;

public class Secretaria : Empleado
{
    public string telefono;
    public Secretaria(string telefono, string nombre, string apellidos, DateTime fechaIngreso, Double sueldo, Double incremento) :
    base(nombre, apellidos, fechaIngreso, sueldo, incremento)
    {
        this.telefono = telefono;
    }

    public override String datos()
    {
        string datos = base.datos();
        datos = datos + " Telefono: " + this.telefono;
        return datos;
    }

}