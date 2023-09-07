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
            Console.WriteLine("---EMPRENDIMIENTOS CON HERRAMIENTAS DE LA CUARTA REVOLUCI�N INDUSTRIAL (4RI)---");

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
                Console.WriteLine("4. Modificar Valor Inversi�n");
                Console.WriteLine("5. Modificar Valor Total");
                Console.WriteLine("------------------------------------------------------------------------------------------");
                Console.WriteLine("ESTADISTICAS");
                Console.WriteLine("6. Mostrar Idea que impacte m�s departamentos");
                Console.WriteLine("7. Idea con m�s ingresos en los primeros 3 a�os");
                Console.WriteLine("8. Ideas m�s rentables");
                Console.WriteLine("9. Ideas de negocio que impactan m�s de 3 departamentos");
                Console.WriteLine("10. Suma total de ingresos de todas las ideas de negocio");
                Console.WriteLine("11. Suma total de la inversi�n de todas las ideas de negocio");
                Console.WriteLine("12. Nombre de la idea de negocio con sus integrantes que use m�s herramientas de 4RI");
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

                        Console.Write("Inversi�n Requerida: ");
                        float inversionRequerida = float.Parse(Console.ReadLine());

                        Console.Write("Total de Ingresos: ");
                        float objetivosIngresos = float.Parse(Console.ReadLine());

                        Idea nuevaIdea = new Idea(nombreIdea, inversionRequerida, objetivosIngresos);

                        Console.WriteLine("C�digo de la Idea de Negocio: " + nuevaIdea.C�digoIdea);

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

                            Console.WriteLine("Miembro agregado con �xito a la idea de negocio.");

                            // Preguntar si desean agregar m�s miembros
                            Console.Write("�Desea agregar otro miembro del equipo? (S/N): ");
                            string respuesta = Console.ReadLine();

                            if (respuesta.ToLower() != "s")
                            {
                                break; 
                            }

                            // Agregar el nuevo miembro a la idea actual
                            nuevaIdea.AgregarMiembro(idMiembro, nombreMiembro, apellidosMiembro, rolMiembro, emailMiembro);

                            Console.WriteLine("Miembro agregado con �xito a la idea de negocio.");
                            break;
                        }

                        while (true)
                        {
                            Console.WriteLine("Ingrese las herramientas 4RI (seleccione el n�mero correspondiente):");
                            Console.WriteLine("1. Inteligencia Artificial y Aprendizaje Autom�tico");
                            Console.WriteLine("2. Internet de las Cosas (IoT)");
                            // Agrega aqu� las dem�s opciones de herramientas

                            int opcionHerramienta = int.Parse(Console.ReadLine());

                            if (opcionHerramienta >= 1 && opcionHerramienta <= 11)
                            {
                                // Llama al m�todo DevolverHerramientas para agregar la herramienta seleccionada
                                nuevaIdea.DevolverHerramientas(opcionHerramienta);

                                Console.WriteLine("Herramienta seleccionada correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("Opci�n no v�lida. Ingrese un n�mero del 1 al 11 para seleccionar una herramienta.");
                            }

                            Console.WriteLine("�Desea agregar otra herramienta? (S/N)");
                            string continuar = Console.ReadLine().Trim().ToUpper();
                            if (continuar != "S")
                            {
                                // El usuario ha terminado de agregar herramientas
                                break;
                            }
                        }

                           
                         Console.WriteLine("Ingrese el color que representa el impacto econ�mico (Verde, Azul, Rojo, Morado, Dorado, Amarillo, Naranja):");
                         string colorSeleccionado = Console.ReadLine().Trim();
                         nuevaIdea.DevolverImpactosEcon�micosIdea(colorSeleccionado);
                         Console.WriteLine($"Color seleccionado: {colorSeleccionado}");
                            
                
                        // Resto del c�digo para almacenar la nueva Idea de Negocio y salir del case 1
                        break;

                    case 2:
                        Console.Write("Ingrese el c�digo de la Idea: ");
                        int codigoIdea = int.Parse(Console.ReadLine());

                        // Verifica si la Idea con el c�digo dado existe en el controlador de Ideas
                        if (desarrolloRegional.ExisteIdeaConCodigo(codigoIdea))
                        {
                            Console.WriteLine("La Idea existe en la lista.");

                            // Solicitar detalles del nuevo Integrante
                            Console.Write("Identificaci�n del Integrante: ");
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

                            // Obtener la Idea correspondiente usando el c�digo
                            Idea ideaEncontrada = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdea);

                            // Agregar el nuevo Miembro a la Idea
                            controlador.AgregarIntegrante(ideaEncontrada, nuevoMiembro);

                            Console.WriteLine("Nuevo Integrante agregado con �xito.");
                        }
                        else
                        {
                            Console.WriteLine("La Idea con el c�digo ingresado no existe.");
                            // Aqu� puedes manejar la situaci�n en la que la Idea no existe
                        }
                        break;


                    case 3:
                        Console.WriteLine("Ingrese el c�digo de la idea de la cual desea eliminar un integrante:");
                        int codigoIdeaEliminarIntegrante = int.Parse(Console.ReadLine());

                        // Obtener la idea por su c�digo
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
                                Console.WriteLine("Miembro eliminado con �xito de la idea.");
                            }
                            else
                            {
                                Console.WriteLine("No se encontr� un miembro con ese nombre en la idea.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontr� una idea con el c�digo ingresado.");
                        }

                        break;

                    case 4:
                        Console.WriteLine("Ingrese el c�digo de la idea cuyo valor de inversi�n desea modificar:");
                        int codigoIdeaModificarInversion = int.Parse(Console.ReadLine());

                        // Obtener la idea por su c�digo
                        Idea ideaModificarInversion = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdeaModificarInversion);

                        if (ideaModificarInversion != null)
                        {
                            Console.WriteLine("Ingrese el nuevo valor de inversi�n:");
                            int nuevoValorInversion = int.Parse(Console.ReadLine());

                            // Llamar al m�todo para modificar el valor de inversi�n
                            controlador.ModificarValorInversion(ideaModificarInversion, nuevoValorInversion);

                            Console.WriteLine("Valor de inversi�n modificado con �xito.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontr� una idea con el c�digo ingresado.");
                        }

                        break;


                    case 5:
                        Console.WriteLine("Ingrese el c�digo de la idea cuyo valor de Total desea modificar:");
                        int codigoIdeaModificarTotal = int.Parse(Console.ReadLine());

                        // Obtener la idea por su c�digo
                        Idea ideaModificarTotal = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdeaModificarTotal);

                        if (ideaModificarTotal != null)
                        {
                            Console.WriteLine("Ingrese el nuevo valor del Total:");
                            int nuevoValorTotal = int.Parse(Console.ReadLine());

                            // Llamar al m�todo para modificar el valor de inversi�n
                            controlador.ModificarValorTotal(ideaModificarTotal, nuevoValorTotal);

                            Console.WriteLine("Valor Total modificado con �xito.");
                        }
                        else
                        {
                            Console.WriteLine("No se encontr� una idea con el c�digo ingresado.");
                        }

                        break;

                    case 6:
                        
                        Idea ideaM�sImpactante = controlador.EncontrarIdeaQueImpactaM�sDepartamentos(desarrolloRegional);

                        if (ideaM�sImpactante != null)
                        {
                            Console.WriteLine("Idea que impacta a m�s departamentos:");
                            Console.WriteLine("C�digo de Idea: " + ideaM�sImpactante.C�digoIdea);
                            Console.WriteLine("Nombre de la Idea: " + ideaM�sImpactante.NombreIdea);
                            Console.WriteLine("Impactos Econ�micos:");
                            foreach (string impacto in ideaM�sImpactante.ImpactosEcon�micosIdea)
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

                        // Llamar al m�todo para encontrar la idea con m�s ingresos
                        Idea ideaConM�sIngresos = controlador.EncontrarIdeaConM�sIngresos(ingresosTodasLasIdeas);

                        // Mostrar la informaci�n de la idea encontrada
                        if (ideaConM�sIngresos != null)
                        {
                            Console.WriteLine("Idea con m�s ingresos:");
                            Console.WriteLine("C�digo de Idea: " + ideaConM�sIngresos.C�digoIdea);
                            Console.WriteLine("Nombre de la Idea: " + ideaConM�sIngresos.NombreIdea);
                            Console.WriteLine("Objetivos de Ingresos: " + ideaConM�sIngresos.ObjetivosDeIngresosIdea);
                            // Mostrar otros detalles de la idea si es necesario
                        }
                        else
                        {
                            Console.WriteLine("No se encontr� ninguna idea con ingresos.");
                        }
                        break;


                    case 8:
                        // Llamar a controlador.EncontrarIdeasM�sRentables y mostrar la informaci�n de las Ideas encontradas
                        List<Idea> rentableTodasLasIdeas = controlador.ObtenerTodasLasIdeas();
                        List<Idea> ideasM�sRentables = controlador.EncontrarIdeasM�sRentables(rentableTodasLasIdeas);

                        if (ideasM�sRentables.Count > 0)
                        {
                            Console.WriteLine("Ideas m�s rentables:");
                            foreach (Idea idea in ideasM�sRentables)
                            {
                                Console.WriteLine("C�digo de Idea: " + idea.C�digoIdea);
                                Console.WriteLine("Nombre de la Idea: " + idea.NombreIdea);
                                Console.WriteLine("Rentabilidad: " + (idea.ObjetivosDeIngresosIdea / idea.Inversi�nRequeridaIdea));
                                // Mostrar otros detalles de la idea si es necesario
                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron ideas m�s rentables.");
                        }
                        break;


                    case 9:
                        
                        List<Idea> ideasImpactandoM�sDeTresDepartamentos = controlador.EncontrarIdeasImpactandoM�sDeTresDepartamentos(desarrolloRegional);

                        if (ideasImpactandoM�sDeTresDepartamentos.Count > 0)
                        {
                            Console.WriteLine("Ideas que impactan en m�s de tres departamentos:");
                            foreach (Idea idea in ideasImpactandoM�sDeTresDepartamentos)
                            {
                                Console.WriteLine("C�digo de Idea: " + idea.C�digoIdea);
                                Console.WriteLine("Nombre de la Idea: " + idea.NombreIdea);
                                Console.WriteLine("Impactos Econ�micos:");
                                foreach (string impacto in idea.ImpactosEcon�micosIdea)
                                {
                                    Console.WriteLine("- " + impacto);
                                }
                             
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se encontraron ideas que impacten en m�s de tres departamentos.");
                        }
                        break;


                    case 10:
                        List<Idea> ingresosTodasIdeas = controlador.ObtenerTodasLasIdeas();
                        float ingresosTotales = controlador.CalcularIngresosTotales(ingresosTodasIdeas);

                        Console.WriteLine("Ingresos totales de todas las ideas: $" + ingresosTotales.ToString("0.00"));
                        break;

                    case 11:

                        List<Idea> totalTodasIdeas = controlador.ObtenerTodasLasIdeas();
                        float inversi�nTotal = controlador.CalcularInversi�nTotal(totalTodasIdeas);

                        Console.WriteLine("Inversi�n total de todas las ideas: $" + inversi�nTotal.ToString("0.00"));
                        break;

                    case 12:
                        List<Idea> herramientaTodasIdeas = controlador.ObtenerTodasLasIdeas();
                        Idea ideaConM�sHerramientas4RI = controlador.EncontrarIdeaConM�sHerramientas4RI(herramientaTodasIdeas);

                        if (ideaConM�sHerramientas4RI != null)
                        {
                            Console.WriteLine("Idea con m�s herramientas de la 4RI:");
                            Console.WriteLine("C�digo de Idea: " + ideaConM�sHerramientas4RI.C�digoIdea);
                            Console.WriteLine("Nombre de la Idea: " + ideaConM�sHerramientas4RI.NombreIdea);
                           
                        }
                        else
                        {
                            Console.WriteLine("No se encontr� ninguna idea con herramientas de la 4RI.");
                        }
                        break;

                    case 13:
                        List<Idea> contarTodasIdeas = controlador.ObtenerTodasLasIdeas();
                        int cantidadIdeasConInteligenciaArtificial = controlador.ContarIdeasConInteligenciaArtificial(contarTodasIdeas);

                        Console.WriteLine("Cantidad de ideas que utilizan Inteligencia Artificial: " + cantidadIdeasConInteligenciaArtificial);
                        break;


                    default:
                        Console.WriteLine("Opci�n no v�lida. Por favor, seleccione una opci�n v�lida.");
                        break;
                }
            }
        }
    }
}
