using Ejercicio2POO;
using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fabricante fabricante = new Fabricante("Honda");

        MotocicletaDeportiva deportiva = new MotocicletaDeportiva("CBR1000RR", 2020, fabricante);

        MotocicletaClasica clasica = new MotocicletaClasica("CB750", 1975, fabricante);

        deportiva.Describir();
        clasica.Describir();

       
        int antiguedad = Motocicleta.CalcularAntiguedad(clasica.AnioFabricacion);
        Console.WriteLine($"Antigüedad de la motocicleta clásica: {antiguedad} años");
    }
}

