using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Emprendimiento
{
    class Principal
    {
        public Controlador controlador;
        public Idea idea;

        public Principal(Controlador controlador, Idea idea)
        {
            this.controlador = controlador;
            this.idea = idea;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("---EMPRENDIMIENTOS CON HERRAMIENTAS DE LA CUARTA REVOLUCIÓN INDUSTRIAL (4RI)---");

            Controlador controlador = new Controlador();
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional(); // Crea una instancia de DesarrolloRegional para usar sus datos

            while (true)
            {
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("MENU DE OPCIONES");
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("1. Agregar Idea de Negocio");
                Console.WriteLine("2. Agregar Integrante");
                Console.WriteLine("3. Eliminar Integrante");
                Console.WriteLine("4. Modificar Valor Inversión");
                Console.WriteLine("5. Modificar Valor Total");
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("ESTADISTICAS");
                Console.WriteLine("6. Mostrar Idea que impacte más departamentos");
                Console.WriteLine("7. Idea con más ingresos en los primeros 3 años");
                Console.WriteLine("8. Ideas más rentables");
                Console.WriteLine("9. Ideas de negocio que impactan más de 3 departamentos");
                Console.WriteLine("10. Suma total de ingresos de todas las ideas de negocio");
                Console.WriteLine("11. Suma total de la inversión de todas las ideas de negocio");
                Console.WriteLine("12. Nombre de la idea de negocio con sus integrantes que use más herramientas de 4RI");
                Console.WriteLine("13. Cantidad de ideas de negocio con inteligencia artificial");
                Console.WriteLine("0. Salir");
                Console.WriteLine("------------------------------------------------------------------------------------------");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese los detalles de la Idea de Negocio:");

                        Console.Write("Nombre de la Idea: ");
                        string nombreIdea = Console.ReadLine();

                        Console.Write("Inversión Requerida: ");
                        float inversionRequerida = float.Parse(Console.ReadLine());

                        Console.Write("Total de Ingresos: ");
                        float objetivosIngresos = float.Parse(Console.ReadLine());

                        Idea nuevaIdea = new Idea(nombreIdea, inversionRequerida, objetivosIngresos);

                        Console.WriteLine("Código de la Idea de Negocio: " + nuevaIdea.CódigoIdea);

                        while (true)
                        {
                            Console.WriteLine("Ingrese los detalles del nuevo miembro:");
                            Console.Write("ID: ");
                            int idMiembro = int.Parse(Console.ReadLine());

                            Console.Write("Nombre: ");
                            string nombreMiembro = Console.ReadLine();

                            Console.Write("Apellidos: ");
                            string apellidosMiembro = Console.ReadLine();

                            Console.Write("Rol: ");
                            string rolMiembro = Console.ReadLine();

                            Console.Write("Email: ");
                            string emailMiembro = Console.ReadLine();

                            // Agregar el nuevo miembro a la idea actual
                            nuevaIdea.AgregarMiembro(idMiembro, nombreMiembro, apellidosMiembro, rolMiembro, emailMiembro);

                            Console.WriteLine("Miembro agregado con éxito a la idea de negocio.");

                            // Preguntar si desean agregar más miembros
                            Console.Write("¿Desea agregar otro miembro del equipo? (S/N): ");
                            string respuesta = Console.ReadLine();

                            if (respuesta.ToLower() != "s")
                            {
                                break; 
                            }

                            // Agregar el nuevo miembro a la idea actual
                            nuevaIdea.AgregarMiembro(idMiembro, nombreMiembro, apellidosMiembro, rolMiembro, emailMiembro);

                            Console.WriteLine("Miembro agregado con éxito a la idea de negocio.");
                            break;
                        }

                        while (true)
                        {
                            Console.WriteLine("Ingrese las herramientas 4RI (seleccione el número correspondiente):");
                            Console.WriteLine("1. Inteligencia Artificial y Aprendizaje Automático");
                            Console.WriteLine("2. Internet de las Cosas (IoT)");
                            // Agrega aquí las demás opciones de herramientas

                            int opcionHerramienta = int.Parse(Console.ReadLine());

                            if (opcionHerramienta >= 1 && opcionHerramienta <= 11)
                            {
                                // Llama al método DevolverHerramientas para agregar la herramienta seleccionada
                                nuevaIdea.DevolverHerramientas(opcionHerramienta);

                                Console.WriteLine("Herramienta seleccionada correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida. Ingrese un número del 1 al 11 para seleccionar una herramienta.");
                            }

                            Console.WriteLine("¿Desea agregar otra herramienta? (S/N)");
                            string continuar = Console.ReadLine().Trim().ToUpper();
                            if (continuar != "S")
                            {
                                // El usuario ha terminado de agregar herramientas
                                break;
                            }
                        }

                           
                         Console.WriteLine("Ingrese el color que representa el impacto económico (Verde, Azul, Rojo, Morado, Dorado, Amarillo, Naranja):");
                         string colorSeleccionado = Console.ReadLine().Trim();
                         nuevaIdea.DevolverImpactosEconómicosIdea(colorSeleccionado);
                         Console.WriteLine($"Color seleccionado: {colorSeleccionado}");
                            
                
                        // Resto del código para almacenar la nueva Idea de Negocio y salir del case 1
                        break;

                    case 2:
                        Console.Write("Ingrese el código de la Idea: ");
                        int codigoIdea = int.Parse(Console.ReadLine());

                        // Verifica si la Idea con el código dado existe en el controlador de Ideas
                        if (desarrolloRegional.ExisteIdeaConCodigo(codigoIdea))
                        {
                            Console.WriteLine("La Idea existe en la lista.");

                            // Solicitar detalles del nuevo Integrante
                            Console.Write("Identificación del Integrante: ");
                            int idIntegrante = int.Parse(Console.ReadLine());

                            Console.Write("Nombre del Integrante: ");
                            string nombreIntegrante = Console.ReadLine();

                            Console.Write("Apellidos del Integrante: ");
                            string apellidosIntegrante = Console.ReadLine();

                            Console.Write("Rol del Integrante: ");
                            string rolIntegrante = Console.ReadLine();

                            Console.Write("Email del Integrante: ");
                            string emailIntegrante = Console.ReadLine();

                            // Crear una instancia de Miembro con los datos ingresados
                            Miembro nuevoMiembro = new Miembro(idIntegrante, nombreIntegrante, apellidosIntegrante, rolIntegrante, emailIntegrante);

                            // Obtener la Idea correspondiente usando el código
                            Idea ideaEncontrada = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdea);

                            // Agregar el nuevo Miembro a la Idea
                            controlador.AgregarIntegrante(ideaEncontrada, nuevoMiembro);

                            Console.WriteLine("Nuevo Integrante agregado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("La Idea con el código ingresado no existe.");
                            // Aquí puedes manejar la situación en la que la Idea no existe
                        }
                        break;


                    case 3:
                        Console.WriteLine("Ingrese el código de la idea de la cual desea eliminar un integrante:");
                        int codigoIdeaEliminarIntegrante = int.Parse(Console.ReadLine());

                        // Obtener la idea por su código
                        Idea ideaEliminarIntegrante = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdeaEliminarIntegrante);

                        if (ideaEliminarIntegrante != null)
                        {
                            Console.WriteLine("Ingrese el nombre del miembro que desea eliminar:");
                            string nombreMiembroAEliminar = Console.ReadLine();

                            // Buscar al miembro por su nombre
                            Miembro miembroAEliminar = ideaEliminarIntegrante._Miembros.FirstOrDefault(miembro => miembro.Nombre == nombreMiembroAEliminar);

                            if (miembroAEliminar != null)
                            {
                                controlador.EliminarIntegrante(ideaEliminarIntegrante, miembroAEliminar);
                                Console.WriteLine("Miembro eliminado con éxito de la idea.");
                            }
                            else
                            {
                                Console.WriteLine("No se encontró un miembro con ese nombre en la idea.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontró una idea con el código ingresado.");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Ingrese el código de la idea cuyo valor de inversión desea modificar:");
                        int codigoIdeaModificarInversion = int.Parse(Console.ReadLine());

                        // Obtener la idea por su código
                        Idea ideaModificarInversion = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdeaModificarInversion);

                        if (ideaModificarInversion != null)
                        {
                            Console.WriteLine("Ingrese el nuevo valor de inversión:");
                            int nuevoValorInversion = int.Parse(Console.ReadLine());

                            // Llamar al método para modificar el valor de inversión
                            controlador.ModificarValorInversion(ideaModificarInversion, nuevoValorInversion);

                            Console.WriteLine("Valor de inversión modificado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró una idea con el código ingresado.");
                        }

                        break;


                    case 5:
                        Console.WriteLine("Ingrese el código de la idea cuyo valor de Total desea modificar:");
                        int codigoIdeaModificarTotal = int.Parse(Console.ReadLine());

                        // Obtener la idea por su código
                        Idea ideaModificarTotal = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdeaModificarTotal);

                        if (ideaModificarTotal != null)
                        {
                            Console.WriteLine("Ingrese el nuevo valor del Total:");
                            int nuevoValorTotal = int.Parse(Console.ReadLine());

                            // Llamar al método para modificar el valor de inversión
                            controlador.ModificarValorTotal(ideaModificarTotal, nuevoValorTotal);

                            Console.WriteLine("Valor Total modificado con éxito.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró una idea con el código ingresado.");
                        }

                        break;

                    case 6:
                        
                        Idea ideaMásImpactante = controlador.EncontrarIdeaQueImpactaMásDepartamentos(desarrolloRegional);

                        if (ideaMásImpactante != null)
                        {
                            Console.WriteLine("Idea que impacta a más departamentos:");
                            Console.WriteLine("Código de Idea: " + ideaMásImpactante.CódigoIdea);
                            Console.WriteLine("Nombre de la Idea: " + ideaMásImpactante.NombreIdea);
                            Console.WriteLine("Impactos Económicos:");
                            foreach (string impacto in ideaMásImpactante.ImpactosEconómicosIdea)
                            {
                                Console.WriteLine("- " + impacto);
                            }
                                              
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron ideas que impacten departamentos.");
                        }
                        break;

                    case 7:
                        // Obtener la lista de todas las ideas
                        List<Idea> ingresosTodasLasIdeas = controlador.ObtenerTodasLasIdeas();

                        // Llamar al método para encontrar la idea con más ingresos
                        Idea ideaConMásIngresos = controlador.EncontrarIdeaConMásIngresos(ingresosTodasLasIdeas);

                        // Mostrar la información de la idea encontrada
                        if (ideaConMásIngresos != null)
                        {
                            Console.WriteLine("Idea con más ingresos:");
                            Console.WriteLine("Código de Idea: " + ideaConMásIngresos.CódigoIdea);
                            Console.WriteLine("Nombre de la Idea: " + ideaConMásIngresos.NombreIdea);
                            Console.WriteLine("Objetivos de Ingresos: " + ideaConMásIngresos.ObjetivosDeIngresosIdea);
                            // Mostrar otros detalles de la idea si es necesario
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ninguna idea con ingresos.");
                        }
                        break;


                    case 8:
                        // Llamar a controlador.EncontrarIdeasMásRentables y mostrar la información de las Ideas encontradas
                        List<Idea> rentableTodasLasIdeas = controlador.ObtenerTodasLasIdeas();
                        List<Idea> ideasMásRentables = controlador.EncontrarIdeasMásRentables(rentableTodasLasIdeas);

                        if (ideasMásRentables.Count > 0)
                        {
                            Console.WriteLine("Ideas más rentables:");
                            foreach (Idea idea in ideasMásRentables)
                            {
                                Console.WriteLine("Código de Idea: " + idea.CódigoIdea);
                                Console.WriteLine("Nombre de la Idea: " + idea.NombreIdea);
                                Console.WriteLine("Rentabilidad: " + (idea.ObjetivosDeIngresosIdea / idea.InversiónRequeridaIdea));
                                // Mostrar otros detalles de la idea si es necesario
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron ideas más rentables.");
                        }
                        break;


                    case 9:
                        
                        List<Idea> ideasImpactandoMásDeTresDepartamentos = controlador.EncontrarIdeasImpactandoMásDeTresDepartamentos(desarrolloRegional);

                        if (ideasImpactandoMásDeTresDepartamentos.Count > 0)
                        {
                            Console.WriteLine("Ideas que impactan en más de tres departamentos:");
                            foreach (Idea idea in ideasImpactandoMásDeTresDepartamentos)
                            {
                                Console.WriteLine("Código de Idea: " + idea.CódigoIdea);
                                Console.WriteLine("Nombre de la Idea: " + idea.NombreIdea);
                                Console.WriteLine("Impactos Económicos:");
                                foreach (string impacto in idea.ImpactosEconómicosIdea)
                                {
                                    Console.WriteLine("- " + impacto);
                                }
                             
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron ideas que impacten en más de tres departamentos.");
                        }
                        break;


                    case 10:
                        List<Idea> ingresosTodasIdeas = controlador.ObtenerTodasLasIdeas();
                        float ingresosTotales = controlador.CalcularIngresosTotales(ingresosTodasIdeas);

                        Console.WriteLine("Ingresos totales de todas las ideas: $" + ingresosTotales.ToString("0.00"));
                        break;

                    case 11:

                        List<Idea> totalTodasIdeas = controlador.ObtenerTodasLasIdeas();
                        float inversiónTotal = controlador.CalcularInversiónTotal(totalTodasIdeas);

                        Console.WriteLine("Inversión total de todas las ideas: $" + inversiónTotal.ToString("0.00"));
                        break;

                    case 12:
                        List<Idea> herramientaTodasIdeas = controlador.ObtenerTodasLasIdeas();
                        Idea ideaConMásHerramientas4RI = controlador.EncontrarIdeaConMásHerramientas4RI(herramientaTodasIdeas);

                        if (ideaConMásHerramientas4RI != null)
                        {
                            Console.WriteLine("Idea con más herramientas de la 4RI:");
                            Console.WriteLine("Código de Idea: " + ideaConMásHerramientas4RI.CódigoIdea);
                            Console.WriteLine("Nombre de la Idea: " + ideaConMásHerramientas4RI.NombreIdea);
                           
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ninguna idea con herramientas de la 4RI.");
                        }
                        break;

                    case 13:
                        List<Idea> contarTodasIdeas = controlador.ObtenerTodasLasIdeas();
                        int cantidadIdeasConInteligenciaArtificial = controlador.ContarIdeasConInteligenciaArtificial(contarTodasIdeas);

                        Console.WriteLine("Cantidad de ideas que utilizan Inteligencia Artificial: " + cantidadIdeasConInteligenciaArtificial);
                        break;


                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }
            }
        }
    }
}
