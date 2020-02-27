using System;

public class Empleado
{

    public string nombre;

    public string apellidos;

    public DateTime fechaIngreso;

    public Double sueldo;

    public Double incremento;

    public Empleado(string nombre, string apellidos, DateTime fechaIngreso, Double sueldo, Double incremento)
    {
        this.nombre = nombre;
        this.apellidos = apellidos;
        this.fechaIngreso = fechaIngreso;
        this.sueldo = sueldo;
        this.incremento = incremento;
    }

    public virtual String datos()
    {
        string datos = "Nombre: " + this.nombre + " Apellidos: " +
        this.apellidos + " Fecha Ingreso: " + this.fechaIngreso + " Sueldo: "
        + this.sueldo + " Incremento: " + this.incremento;
        return datos;
    }

    public void setIncremento(Double incremento)
    {
        this.incremento = incremento;
        this.sueldo = this.sueldo + this.sueldo * this.incremento;
    }
}