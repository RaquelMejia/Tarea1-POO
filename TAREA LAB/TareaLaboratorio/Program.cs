using AdministradorPersonajes;
using System;
using System.Collections.Generic;

namespace TareaLaboratorio
{
    class Program
    {
        static List<Personaje> listaPersonajes = new List<Personaje>();

        static void Main(string[] args)
        {
            int opciones;

            do
            {
                Console.WriteLine("Bienvenido al administrador de personajes de juego \n");
                Console.WriteLine("1. Agregar nuevo personaje");
                Console.WriteLine("2. Mostrar todos los personajes");
                Console.WriteLine("3. Mostrar personajes por categoría");
                Console.WriteLine("4. Editar personaje");
                Console.WriteLine("5. Eliminar personaje");
                Console.WriteLine("6. Salir \n");
                Console.Write("Seleccione una opción (1-6): ");

                if (int.TryParse(Console.ReadLine(), out opciones))
                {

                    switch (opciones)
                    {
                        case 1:
                            AgregarNuevoPersonaje();
                            break;
                        case 2:
                            MostrarTodosPersonajes();
                            break;
                        case 3:
                            MostrarPersonajesPorCategoria();
                            break;
                        case 4:
                            EditarPersonaje();
                            break;
                        case 5:
                            EliminarPersonaje();
                            break;
                        case 6:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            break;
                    }

                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }
            } while (opciones != 6);
        }

        static void MostrarTodosPersonajes()
        {
            Console.WriteLine("Listado de todos los personajes: \n");

            foreach (var personaje in listaPersonajes)
            {
                Console.WriteLine($"Nombre: {personaje.Nombre}, Tipo: {personaje.Tipo}, Salud: {personaje.Salud}, Ataque: {personaje.Ataque}, " +
                                  $"Defensa Física: {personaje.DefensaFisica}, Defensa Mágica: {personaje.DefensaMagica}, " +
                                  $"Poder Mágico: {personaje.PoderMagico}");
            }
        }

        static void MostrarPersonajesPorCategoria()
        {
            Console.WriteLine("Listado de personajes por categoría: \n");

            foreach (TipoPersonaje tipo in Enum.GetValues(typeof(TipoPersonaje)))
            {
                Console.WriteLine($"Categoría: {tipo}");
                foreach (var personaje in listaPersonajes)
                {
                    if (personaje.Tipo == tipo)
                    {
                        Console.WriteLine($"Nombre: {personaje.Nombre}, Salud: {personaje.Salud}, Ataque: {personaje.Ataque}, " +
                                          $"Defensa Física: {personaje.DefensaFisica}, Defensa Mágica: {personaje.DefensaMagica}, " +
                                          $"Poder Mágico: {personaje.PoderMagico}");
                    }
                }
            }
        }

        static void AgregarNuevoPersonaje()
        {
            Console.WriteLine("Ingrese el nombre del personaje: \n");
            string nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de salud del personaje (Ejm.5, 20, 70..):");
            int salud = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje del ataque del personaje:");
            int ataque = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de la defensa física del personaje:");
            int defensaFisica = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje de la defensa mágica del personaje:");
            int defensaMagica = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el porcentaje del poder mágico del personaje:");
            int poderMagico = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el tipo de personaje (Guerrero, Mago, Sanador):");
            string tipoString = Convert.ToString(Console.ReadLine());

            if (Enum.TryParse<TipoPersonaje>(tipoString, out TipoPersonaje tipo))
            {
                Personaje nuevoPersonaje = new Personaje(nombre, salud, ataque, defensaFisica, defensaMagica, poderMagico, tipo);
                listaPersonajes.Add(nuevoPersonaje);

                Console.WriteLine("¡Personaje agregado correctamente!");
            }
            else
            {
                Console.WriteLine("Tipo de personaje no válido.");
            }
        }

        static void EditarPersonaje()
        {
            Console.WriteLine("Ingrese el nombre del personaje que desea editar: \n");
            string nombreEditar = Convert.ToString(Console.ReadLine());

            Personaje personajeEditar = listaPersonajes.Find(p => p.Nombre == nombreEditar);

            if (personajeEditar != null)
            {
                Console.WriteLine("Ingrese el nuevo porcentaje de salud del personaje (Ejm.5, 20, 70..)");
                personajeEditar.Salud = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el nuevo porcentaje del ataque del personaje:");
                personajeEditar.Ataque = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el porcentaje de la nueva defensa física del personaje:");
                personajeEditar.DefensaFisica = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el porcentaje dee la nueva defensa mágica del personaje:");
                personajeEditar.DefensaMagica = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el porcentaje del nuevo poder mágico del personaje:");
                personajeEditar.PoderMagico = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("¡Personaje editado correctamente!");
            }
            else
            {
                Console.WriteLine("No se encontró ningún personaje con ese nombre.");
            }
        }

        static void EliminarPersonaje()
        {
            Console.WriteLine("Ingrese el nombre del personaje que desea eliminar: \n");
            string nombreEliminar = Convert.ToString(Console.ReadLine());

            Personaje personajeEliminar = listaPersonajes.Find(p => p.Nombre == nombreEliminar);

            if (personajeEliminar != null)
            {
                listaPersonajes.Remove(personajeEliminar);
                Console.WriteLine("¡Personaje eliminado correctamente!");
            }
            else
            {
                Console.WriteLine("No se encontró ningún personaje con ese nombre.");
            }
        }
    }
}