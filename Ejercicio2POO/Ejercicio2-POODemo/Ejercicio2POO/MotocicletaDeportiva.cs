using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2POO
{
public class MotocicletaDeportiva : Motocicleta
    {
        public MotocicletaDeportiva(string modelo, int anioFabricacion, Fabricante fabricante)
            : base(modelo, anioFabricacion, fabricante)
        {
        }

        public override void Describir()
        {
            Console.WriteLine("Motocicleta Deportiva:");
            base.Describir();
        }
    }

}

