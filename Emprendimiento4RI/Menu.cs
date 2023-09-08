using System;
using System.Collections.Generic;

namespace Emprendimiento
{
    class Program
    {
        static void Main(string[] args)
        {
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional(); // Crea una instancia de DesarrolloRegional
            int numeroIdeasIngresadas = 0; // Variable para mantener un registro del número de ideas ingresadas

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

                // Verifica si se han ingresado al menos dos ideas para habilitar el menú de estadísticas
                if (numeroIdeasIngresadas >= 2)
                {
                    Console.WriteLine("ESTADISTICAS");
                    Console.WriteLine("6. Mostrar Idea que impacte más departamentos");
                    Console.WriteLine("7. Idea con más ingresos en los primeros 3 años");
                    Console.WriteLine("8. Ideas más rentables");
                    Console.WriteLine("9. Ideas de negocio que impactan más de 3 departamentos");
                    Console.WriteLine("10. Suma total de ingresos de todas las ideas de negocio");
                    Console.WriteLine("11. Suma total de la inversión de todas las ideas de negocio");
                    Console.WriteLine("12. Nombre de la idea de negocio con sus integrantes que use más herramientas de 4RI");
                    Console.WriteLine("13. Cantidad de ideas de negocio con inteligencia artificial");
                }

                
                Console.WriteLine("------------------------------------------------------------------------------------------");

                Console.Write("Seleccione una opción: ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
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

                            // Crear la nueva idea de negocio
                            Idea nuevaIdea = new Idea(nombreIdea, inversionRequerida, objetivosIngresos);

                            Console.WriteLine("Ingrese el color que representa el impacto económico (Verde, Azul, Rojo, Morado, Dorado, Amarillo, Naranja):");
                            string colorSeleccionado = Console.ReadLine().Trim();
                            nuevaIdea.AgregarImpactosEconomicosIdea(colorSeleccionado);
                            Console.WriteLine($"Color seleccionado: {colorSeleccionado}");

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
                            }

                            while (true)
                            {
                                Console.WriteLine("Ingrese las herramientas 4RI (seleccione el número correspondiente):");
                                Console.WriteLine("1. Inteligencia Artificial y Aprendizaje Automático");
                                Console.WriteLine("2. Internet de las Cosas (IoT)");
                                Console.WriteLine("3. Blockchain y Criptomonedas");
                                Console.WriteLine("4. Realidad Virtual (VR) y Realidad Aumentada (AR)");
                                Console.WriteLine("5. Impresión 3D (Fabricación Aditiva)");
                                Console.WriteLine("6. Robótica Avanzada");
                                Console.WriteLine("7. Computación Cuántica");
                                Console.WriteLine("8. Biología Sintética y Genómica");
                                Console.WriteLine("9. Nanotecnología");
                                Console.WriteLine("10.Big Data y Análisis Predictivo");
                                Console.WriteLine("11.Automatización Industrial y Robótica Industrial ");

                                int opcionHerramienta = int.Parse(Console.ReadLine());

                                if (opcionHerramienta >= 1 && opcionHerramienta <= 11)
                                {
                                    // Llama al método DevolverHerramientas para agregar la herramienta seleccionada
                                    nuevaIdea.AgregarHerramientas(opcionHerramienta);

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

                            Console.WriteLine("Detalles de la Idea de Negocio:");
                            Console.WriteLine($"Código de Idea: {nuevaIdea.CodigoIdea}");
                            Console.WriteLine($"Nombre de la Idea: {nuevaIdea.NombreIdea}");
                            Console.WriteLine($"Inversión Requerida: {nuevaIdea.InversionRequeridaIdea}");
                            Console.WriteLine($"Total de Ingresos: {nuevaIdea.ObjetivosDeIngresosIdea}");
                            Console.WriteLine($"Impacto Económico: {string.Join(", ", nuevaIdea.ImpactosEconomicosIdea)}");

                            Console.WriteLine("Miembros del Equipo:");
                            foreach (var miembro in nuevaIdea.Miembros)
                            {
                                Console.WriteLine($"- ID: {miembro.Id}, Nombre: {miembro.Nombre}, Apellidos: {miembro.Apellidos}, Rol: {miembro.Rol}, Email: {miembro.Email}");
                            }

                            Console.WriteLine("Herramientas de la 4ª Revolución Industrial:");
                            foreach (var herramientaId in nuevaIdea.Herramientas4RevolucionIndustrialIdea)
                            {
                                if (desarrolloRegional.Herramientas4RevolucionIndustrial.ContainsKey(herramientaId))
                                {
                                    Console.WriteLine($"- {desarrolloRegional.Herramientas4RevolucionIndustrial[herramientaId]}");
                                }
                            }

                            // Implementar lógica para agregar una idea de negocio
                            desarrolloRegional.AgregarIdeaAdesarrollo(nuevaIdea);
                            numeroIdeasIngresadas++; // Incrementar el contador de ideas ingresadas
                            break;

                        case 2:
                            Console.WriteLine("Agregar Integrante a una Idea de Negocio:");
                            Console.Write("Ingrese el código de la Idea de Negocio: ");
                            int codigoIdea = int.Parse(Console.ReadLine());

                            // Buscar la idea de negocio por su código
                            Idea ideaExistente = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdea);

                            if (ideaExistente != null)
                            {
                                Console.WriteLine("Ingrese los detalles del nuevo miembro:");
                                Console.Write("ID: ");
                                int idNuevoIntegrante = int.Parse(Console.ReadLine());

                                Console.Write("Nombre: ");
                                string nombreNuevoIntegrante = Console.ReadLine();

                                Console.Write("Apellidos: ");
                                string apellidosNuevoIntegrante = Console.ReadLine();

                                Console.Write("Rol: ");
                                string rolNuevoIntegrante = Console.ReadLine();

                                Console.Write("Email: ");
                                string emailNuevoIntegrante = Console.ReadLine();

                                Miembro nuevoIntegrante = new Miembro(idNuevoIntegrante, nombreNuevoIntegrante, apellidosNuevoIntegrante, rolNuevoIntegrante, emailNuevoIntegrante);
                                
                                // Agregar el nuevo miembro a la idea actual
                                if (ideaExistente.AgregarIntegrante(nuevoIntegrante))
                                {
                                    Console.WriteLine("Miembro agregado con éxito a la idea de negocio.");

                                    // Imprimir la idea con los miembros, incluyendo el nuevo miembro
                                    Console.WriteLine("Detalles de la Idea de Negocio:");
                                    Console.WriteLine($"Código de Idea: {ideaExistente.CodigoIdea}");
                                    Console.WriteLine($"Nombre de la Idea: {ideaExistente.NombreIdea}");
                                    Console.WriteLine($"Inversión Requerida: {ideaExistente.InversionRequeridaIdea}");
                                    Console.WriteLine($"Total de Ingresos: {ideaExistente.ObjetivosDeIngresosIdea}");
                                    Console.WriteLine($"Impacto Económico: {string.Join(", ", ideaExistente.ImpactosEconomicosIdea)}");

                                    Console.WriteLine("Miembros del Equipo:");
                                    foreach (var miembro in ideaExistente.Miembros)
                                    {
                                        Console.WriteLine($"- ID: {miembro.Id}, Nombre: {miembro.Nombre}, Apellidos: {miembro.Apellidos}, Rol: {miembro.Rol}, Email: {miembro.Email}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Error: No se pudo agregar al miembro. Compruebe si el ID ya existe.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No se encontró una Idea de Negocio con el código {codigoIdea}.");
                            }
                            break;


                        case 3:
                            Console.WriteLine("Eliminar Integrante de una Idea de Negocio:");
                            Console.Write("Ingrese el código de la Idea de Negocio: ");
                            int codigoIdeaEliminar = int.Parse(Console.ReadLine());

                            // Buscar la idea de negocio por su código
                            Idea ideaEliminarIntegrante = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdeaEliminar);

                            if (ideaEliminarIntegrante != null)
                            {
                                Console.Write("Ingrese el ID del Miembro a eliminar: ");
                                int idMiembroEliminar = int.Parse(Console.ReadLine());

                                // Buscar el miembro por su ID en la idea de negocio
                                Miembro miembroAEliminar = ideaEliminarIntegrante.ObtenerMiembroPorId(idMiembroEliminar);

                                if (miembroAEliminar != null)
                                {
                                    // Eliminar el miembro de la idea de negocio
                                    ideaEliminarIntegrante.EliminarIntegrante(miembroAEliminar);
                                    Console.WriteLine("Miembro eliminado con éxito.");

                                    // Imprimir la idea actualizada sin el miembro eliminado
                                    Console.WriteLine("Detalles de la Idea de Negocio:");
                                    Console.WriteLine($"Código de Idea: {ideaEliminarIntegrante.CodigoIdea}");
                                    Console.WriteLine($"Nombre de la Idea: {ideaEliminarIntegrante.NombreIdea}");
                                    Console.WriteLine($"Inversión Requerida: {ideaEliminarIntegrante.InversionRequeridaIdea}");
                                    Console.WriteLine($"Total de Ingresos: {ideaEliminarIntegrante.ObjetivosDeIngresosIdea}");
                                    Console.WriteLine($"Impacto Económico: {string.Join(", ", ideaEliminarIntegrante.ImpactosEconomicosIdea)}");

                                    Console.WriteLine("Miembros del Equipo:");
                                    foreach (var miembro in ideaEliminarIntegrante.Miembros)
                                    {
                                        Console.WriteLine($"- ID: {miembro.Id}, Nombre: {miembro.Nombre}, Apellidos: {miembro.Apellidos}, Rol: {miembro.Rol}, Email: {miembro.Email}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"No se encontró un Miembro con el ID {idMiembroEliminar} en la Idea de Negocio.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No se encontró una Idea de Negocio con el código {codigoIdeaEliminar}.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Modificar Valor de Inversión de una Idea de Negocio:");
                            Console.Write("Ingrese el código de la Idea de Negocio: ");
                            int codigoIdeaModificarInversion = int.Parse(Console.ReadLine());

                            // Buscar la idea de negocio por su código
                            Idea ideaExistenteModificarInversion = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdeaModificarInversion);

                            if (ideaExistenteModificarInversion != null)
                            {
                                Console.Write("Ingrese el nuevo valor de inversión: ");
                                int nuevaInversion = int.Parse(Console.ReadLine());

                                // Llamar al método para modificar el valor de inversión
                                ideaExistenteModificarInversion.ModificarValorInversion(nuevaInversion);

                                Console.WriteLine("Valor de inversión modificado con éxito.");

                                // Imprimir la idea actualizada con el nuevo valor de inversión
                                Console.WriteLine("Detalles de la Idea de Negocio después de modificar la inversión:");
                                Console.WriteLine($"Código de Idea: {ideaExistenteModificarInversion.CodigoIdea}");
                                Console.WriteLine($"Nombre de la Idea: {ideaExistenteModificarInversion.NombreIdea}");
                                Console.WriteLine($"Inversión Requerida: {ideaExistenteModificarInversion.InversionRequeridaIdea}");
                                Console.WriteLine($"Total de Ingresos: {ideaExistenteModificarInversion.ObjetivosDeIngresosIdea}");
                                Console.WriteLine($"Impacto Económico: {string.Join(", ", ideaExistenteModificarInversion.ImpactosEconomicosIdea)}");

                                Console.WriteLine("Miembros del Equipo:");
                                foreach (var miembro in ideaExistenteModificarInversion.Miembros)
                                {
                                    Console.WriteLine($"- ID: {miembro.Id}, Nombre: {miembro.Nombre}, Apellidos: {miembro.Apellidos}, Rol: {miembro.Rol}, Email: {miembro.Email}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No se encontró una Idea de Negocio con el código {codigoIdeaModificarInversion}.");
                            }
                            break;


                        case 5:
                            Console.WriteLine("Modificar el Valor Total de una Idea de Negocio:");
                            Console.Write("Ingrese el código de la Idea de Negocio: ");
                            int codigoIdeaModificarTotal = int.Parse(Console.ReadLine());

                            // Buscar la idea de negocio por su código
                            Idea ideaExistenteModificarTotal = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdeaModificarTotal);

                            if (ideaExistenteModificarTotal != null)
                            {
                                Console.Write("Ingrese el nuevo valor total de ingresos: ");
                                int nuevoValorTotal = int.Parse(Console.ReadLine());

                                // Llamar al método para modificar el valor total de ingresos
                                ideaExistenteModificarTotal.ModificarValorTotal(nuevoValorTotal);

                                Console.WriteLine("Valor total de ingresos modificado con éxito.");

                                // Imprimir la idea actualizada
                                Console.WriteLine("Detalles de la Idea de Negocio:");
                                Console.WriteLine($"Código de Idea: {ideaExistenteModificarTotal.CodigoIdea}");
                                Console.WriteLine($"Nombre de la Idea: {ideaExistenteModificarTotal.NombreIdea}");
                                Console.WriteLine($"Inversión Requerida: {ideaExistenteModificarTotal.InversionRequeridaIdea}");
                                Console.WriteLine($"Total de Ingresos: {ideaExistenteModificarTotal.ObjetivosDeIngresosIdea}");
                                Console.WriteLine($"Impacto Económico: {string.Join(", ", ideaExistenteModificarTotal.ImpactosEconomicosIdea)}");

                                Console.WriteLine("Miembros del Equipo:");
                                foreach (var miembro in ideaExistenteModificarTotal.Miembros)
                                {
                                    Console.WriteLine($"- ID: {miembro.Id}, Nombre: {miembro.Nombre}, Apellidos: {miembro.Apellidos}, Rol: {miembro.Rol}, Email: {miembro.Email}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No se encontró una Idea de Negocio con el código {codigoIdeaModificarTotal}.");
                            }
                            break;

                        case 6:
                            Console.WriteLine("Mostrar la Idea de Negocio que impacta más departamentos:");


                            Idea ideaMasImpactante = Controlador.EncontrarIdeaQueImpactaMasDepartamentos(desarrolloRegional);

                            if (ideaMasImpactante != null)
                            {
                                Console.WriteLine("La idea que impacta más departamentos es:");
                                Console.WriteLine($"Código de Idea: {ideaMasImpactante.CodigoIdea}");
                                Console.WriteLine($"Nombre de la Idea: {ideaMasImpactante.NombreIdea}");
                                
                            }
                            else

                            {
                                Console.WriteLine("No se encontraron ideas de negocio o ninguna impacta a departamentos.");
                            }
                            break;

                        case 7:
                
                            Idea? ideaMasIngresos = Controlador.EncontrarIdeaConMasIngresos(desarrolloRegional);

                            if (ideaMasIngresos != null)
                            {
                                Console.WriteLine("La idea con más ingresos en los primeros 3 años es:");
                                Console.WriteLine($"Nombre de la Idea: {ideaMasIngresos.NombreIdea}");
                                Console.WriteLine($"Ingresos en los primeros 3 años: {ideaMasIngresos.ObjetivosDeIngresosIdea}");
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron ideas de negocio.");
                            }
                            break;

                        case 8:
                            
                            List<Idea> ideasMasRentables = Controlador.EncontrarIdeasMasRentables(desarrolloRegional);

                            if (ideasMasRentables.Count > 0)
                            {
                                Console.WriteLine("Las ideas más rentables son:");
                                foreach (var idea in ideasMasRentables)
                                {
                                    Console.WriteLine($"Nombre de la Idea: {idea.NombreIdea}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron ideas de negocio.");
                            }
                            break;

                        case 9:
                            
                            List<Idea> ideasImpactandoMasDeTresDepartamentos = Controlador.EncontrarIdeasImpactandoMasDeTresDepartamentos(desarrolloRegional);

                            if (ideasImpactandoMasDeTresDepartamentos.Count > 0)
                            {
                                Console.WriteLine("Las ideas que impactan a más de 3 departamentos son:");
                                foreach (var idea in ideasImpactandoMasDeTresDepartamentos)
                                {
                                    Console.WriteLine($"Nombre de la Idea: {idea.NombreIdea}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron ideas que impacten a más de 3 departamentos.");
                            }
                            break;

                        case 10:        
                            float ingresosTotales = Controlador.CalcularIngresosTotales(desarrolloRegional);

                            Console.WriteLine($"La suma total de ingresos de todas las ideas de negocio es: {ingresosTotales}");
                            break;

                        case 11:
                            float inversionTotal = Controlador.CalcularInversionTotal(desarrolloRegional);

                            Console.WriteLine($"La suma total de la inversión que se debe hacer en todas las ideas de negocio es: {inversionTotal}");
                            break;

                        case 12:
                           
                            Idea ideaConMasHerramientas4RI = Controlador.EncontrarIdeaConMasHerramientas4RI(desarrolloRegional);

                            if (ideaConMasHerramientas4RI != null)
                            {
                                Console.WriteLine("Idea con más herramientas de 4ª Revolución Industrial:");
                                Console.WriteLine($"Código de Idea: {ideaConMasHerramientas4RI.CodigoIdea}");
                                Console.WriteLine($"Nombre de la Idea: {ideaConMasHerramientas4RI.NombreIdea}");
                                Console.WriteLine($"Cantidad de Herramientas 4RI: {ideaConMasHerramientas4RI.Herramientas4RevolucionIndustrialIdea.Count}");

                                Console.WriteLine("Miembros del Equipo:");
                                foreach (var miembro in ideaConMasHerramientas4RI.Miembros)
                                {
                                    Console.WriteLine($"- ID: {miembro.Id}, Nombre: {miembro.Nombre}, Apellidos: {miembro.Apellidos}, Rol: {miembro.Rol}, Email: {miembro.Email}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron ideas con herramientas de 4ª Revolución Industrial.");
                            }
                            break;

                        case 13:
                      
                            int cantidadIdeasInteligenciaArtificial = Controlador.ContarIdeasConInteligenciaArtificial(desarrolloRegional);

                            Console.WriteLine($"Cantidad de Ideas de Negocio con Inteligencia Artificial: {cantidadIdeasInteligenciaArtificial}");
                            break;


                        default:
                            Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número válido.");
                }
            }
        }
    }
}


















