using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2POO
{
    
public class Motocicleta
    {
        public string Modelo { get; set; }
        public int AnioFabricacion { get; set; }
        public Fabricante Fabricante { get; set; }


        public Motocicleta(string modelo, int anioFabricacion, Fabricante fabricante)
        {
            Modelo = modelo;
            AnioFabricacion = anioFabricacion;
            Fabricante = fabricante;
        }

        public virtual void Describir()
        {
            Console.WriteLine($"Modelo: {Modelo}, Año: {AnioFabricacion}, Fabricante: {Fabricante.Nombre}");
        }

        public static int CalcularAntiguedad(int anioFabricacion)
        {
            int anioActual = DateTime.Now.Year;
            return anioActual - anioFabricacion;
        }
    }

}
