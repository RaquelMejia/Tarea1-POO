using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2POO
{
    
public class MotocicletaClasica : Motocicleta
    {
        public MotocicletaClasica(string modelo, int anioFabricacion, Fabricante fabricante)
            : base(modelo, anioFabricacion, fabricante)
        {
        }

        public override void Describir()
        {
            Console.WriteLine("Motocicleta Clásica:");
            base.Describir();
        }
    }

}
