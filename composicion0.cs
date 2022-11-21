using System;
using System.Collections.Generic;


class Cuarto{
    string tipo;
    double area; //metros cuadrados
    bool amueblado;
    byte cantidad;

    public Cuarto(string tipo, double area, bool amueblado, byte cantidad)
    {
        this.tipo = tipo;
        this.area = area;
        this.amueblado = amueblado;
        this.cantidad = cantidad;
    }

    public void getCuarto()
    {
        Console.WriteLine("\n" + tipo + "\n" + area + " Metros cuadrados\n" + amueblado + "\nCantidad " + cantidad);
    }


}





//Segunda clase
class Casa
{
    string nombre;
    List<Cuarto> listaCuarto;

    public Casa(string nombreCasa)
    {
        nombre = nombreCasa;
        listaCuarto = new List<Cuarto>();//Al crear la casa se crean los cuatos
    }

    public void setCuarto(string tipo, double area, bool amueblado, byte cantidad)
    {
        listaCuarto.Add(new Cuarto(tipo, area, amueblado, 2));
    }

    public void verCuarto()
    {
        for(int i = 0; i<listaCuarto.Count; i++)
        {
            listaCuarto[i].getCuarto();
        }
    }
}

//Tester-Class

class Tester{
    static void Main(string[] args)
    {
        Casa miCasa = new Casa("\nFamilia Mendez");
        miCasa.setCuarto("Dormitorio principal", 74.45, true, 2);
        miCasa.setCuarto("Dormitorio secundario", 50, true, 3);
        miCasa.setCuarto("Bano secundadrio", 11.73, true, 4);
        miCasa.setCuarto("Sala de estudio", 8.33, true, 2);
        miCasa.setCuarto("Gimnasio", 50, false, 1);
        miCasa.setCuarto("Cuarto para conserje", 35, true, 1);
        miCasa.verCuarto();

        miCasa = null; //Casa destruida
        //miCasa.verCuartos(); // Ver nota #1
    }
}