indin using System;

namespace AdministradorPersonajes
    {
        public enum TipoPersonaje
        {
            Guerrero,
            Mago,
            Sanador
        }

        public class Personaje
        {
            public string Nombre { get; set; }
            public int Salud { get; set; }
            public int Ataque { get; set; }
            public int DefensaFisica { get; set; }
            public int DefensaMagica { get; set; }
            public int PoderMagico { get; set; }
            public TipoPersonaje Tipo { get; set; }

            public Personaje(string nombre, int salud, int ataque, int defensaFisica, int defensaMagica, int poderMagico, TipoPersonaje tipo)
            {
                Nombre = nombre;
                Salud = salud;
                Ataque = ataque;
                DefensaFisica = defensaFisica;
                DefensaMagica = defensaMagica;
                PoderMagico = poderMagico;
                Tipo = tipo;
            }
        }
    }




