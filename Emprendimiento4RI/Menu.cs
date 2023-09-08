using System;
using System.Collections.Generic;

namespace Emprendimiento
{
    class Program
    {
        static void Main(string[] args)
        {
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional(); // Crea una instancia de DesarrolloRegional
            int numeroIdeasIngresadas = 0; // Variable para mantener un registro del n�mero de ideas ingresadas

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

                // Verifica si se han ingresado al menos dos ideas para habilitar el men� de estad�sticas
                if (numeroIdeasIngresadas >= 2)
                {
                    Console.WriteLine("ESTADISTICAS");
                    Console.WriteLine("6. Mostrar Idea que impacte m�s departamentos");
                    Console.WriteLine("7. Idea con m�s ingresos en los primeros 3 a�os");
                    Console.WriteLine("8. Ideas m�s rentables");
                    Console.WriteLine("9. Ideas de negocio que impactan m�s de 3 departamentos");
                    Console.WriteLine("10. Suma total de ingresos de todas las ideas de negocio");
                    Console.WriteLine("11. Suma total de la inversi�n de todas las ideas de negocio");
                    Console.WriteLine("12. Nombre de la idea de negocio con sus integrantes que use m�s herramientas de 4RI");
                    Console.WriteLine("13. Cantidad de ideas de negocio con inteligencia artificial");
                }

                
                Console.WriteLine("------------------------------------------------------------------------------------------");

                Console.Write("Seleccione una opci�n: ");

                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
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

                            // Crear la nueva idea de negocio
                            Idea nuevaIdea = new Idea(nombreIdea, inversionRequerida, objetivosIngresos);

                            Console.WriteLine("Ingrese el color que representa el impacto econ�mico (Verde, Azul, Rojo, Morado, Dorado, Amarillo, Naranja):");
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

                                Console.WriteLine("Miembro agregado con �xito a la idea de negocio.");

                                // Preguntar si desean agregar m�s miembros
                                Console.Write("�Desea agregar otro miembro del equipo? (S/N): ");
                                string respuesta = Console.ReadLine();

                                if (respuesta.ToLower() != "s")
                                {
                                    break;
                                }
                            }

                            while (true)
                            {
                                Console.WriteLine("Ingrese las herramientas 4RI (seleccione el n�mero correspondiente):");
                                Console.WriteLine("1. Inteligencia Artificial y Aprendizaje Autom�tico");
                                Console.WriteLine("2. Internet de las Cosas (IoT)");
                                Console.WriteLine("3. Blockchain y Criptomonedas");
                                Console.WriteLine("4. Realidad Virtual (VR) y Realidad Aumentada (AR)");
                                Console.WriteLine("5. Impresi�n 3D (Fabricaci�n Aditiva)");
                                Console.WriteLine("6. Rob�tica Avanzada");
                                Console.WriteLine("7. Computaci�n Cu�ntica");
                                Console.WriteLine("8. Biolog�a Sint�tica y Gen�mica");
                                Console.WriteLine("9. Nanotecnolog�a");
                                Console.WriteLine("10.Big Data y An�lisis Predictivo");
                                Console.WriteLine("11.Automatizaci�n Industrial y Rob�tica Industrial ");

                                int opcionHerramienta = int.Parse(Console.ReadLine());

                                if (opcionHerramienta >= 1 && opcionHerramienta <= 11)
                                {
                                    // Llama al m�todo DevolverHerramientas para agregar la herramienta seleccionada
                                    nuevaIdea.AgregarHerramientas(opcionHerramienta);

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

                            Console.WriteLine("Detalles de la Idea de Negocio:");
                            Console.WriteLine($"C�digo de Idea: {nuevaIdea.CodigoIdea}");
                            Console.WriteLine($"Nombre de la Idea: {nuevaIdea.NombreIdea}");
                            Console.WriteLine($"Inversi�n Requerida: {nuevaIdea.InversionRequeridaIdea}");
                            Console.WriteLine($"Total de Ingresos: {nuevaIdea.ObjetivosDeIngresosIdea}");
                            Console.WriteLine($"Impacto Econ�mico: {string.Join(", ", nuevaIdea.ImpactosEconomicosIdea)}");

                            Console.WriteLine("Miembros del Equipo:");
                            foreach (var miembro in nuevaIdea.Miembros)
                            {
                                Console.WriteLine($"- ID: {miembro.Id}, Nombre: {miembro.Nombre}, Apellidos: {miembro.Apellidos}, Rol: {miembro.Rol}, Email: {miembro.Email}");
                            }

                            Console.WriteLine("Herramientas de la 4� Revoluci�n Industrial:");
                            foreach (var herramientaId in nuevaIdea.Herramientas4RevolucionIndustrialIdea)
                            {
                                if (desarrolloRegional.Herramientas4RevolucionIndustrial.ContainsKey(herramientaId))
                                {
                                    Console.WriteLine($"- {desarrolloRegional.Herramientas4RevolucionIndustrial[herramientaId]}");
                                }
                            }

                            // Implementar l�gica para agregar una idea de negocio
                            desarrolloRegional.AgregarIdeaAdesarrollo(nuevaIdea);
                            numeroIdeasIngresadas++; // Incrementar el contador de ideas ingresadas
                            break;

                        case 2:
                            Console.WriteLine("Agregar Integrante a una Idea de Negocio:");
                            Console.Write("Ingrese el c�digo de la Idea de Negocio: ");
                            int codigoIdea = int.Parse(Console.ReadLine());

                            // Buscar la idea de negocio por su c�digo
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
                                    Console.WriteLine("Miembro agregado con �xito a la idea de negocio.");

                                    // Imprimir la idea con los miembros, incluyendo el nuevo miembro
                                    Console.WriteLine("Detalles de la Idea de Negocio:");
                                    Console.WriteLine($"C�digo de Idea: {ideaExistente.CodigoIdea}");
                                    Console.WriteLine($"Nombre de la Idea: {ideaExistente.NombreIdea}");
                                    Console.WriteLine($"Inversi�n Requerida: {ideaExistente.InversionRequeridaIdea}");
                                    Console.WriteLine($"Total de Ingresos: {ideaExistente.ObjetivosDeIngresosIdea}");
                                    Console.WriteLine($"Impacto Econ�mico: {string.Join(", ", ideaExistente.ImpactosEconomicosIdea)}");

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
                                Console.WriteLine($"No se encontr� una Idea de Negocio con el c�digo {codigoIdea}.");
                            }
                            break;


                        case 3:
                            Console.WriteLine("Eliminar Integrante de una Idea de Negocio:");
                            Console.Write("Ingrese el c�digo de la Idea de Negocio: ");
                            int codigoIdeaEliminar = int.Parse(Console.ReadLine());

                            // Buscar la idea de negocio por su c�digo
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
                                    Console.WriteLine("Miembro eliminado con �xito.");

                                    // Imprimir la idea actualizada sin el miembro eliminado
                                    Console.WriteLine("Detalles de la Idea de Negocio:");
                                    Console.WriteLine($"C�digo de Idea: {ideaEliminarIntegrante.CodigoIdea}");
                                    Console.WriteLine($"Nombre de la Idea: {ideaEliminarIntegrante.NombreIdea}");
                                    Console.WriteLine($"Inversi�n Requerida: {ideaEliminarIntegrante.InversionRequeridaIdea}");
                                    Console.WriteLine($"Total de Ingresos: {ideaEliminarIntegrante.ObjetivosDeIngresosIdea}");
                                    Console.WriteLine($"Impacto Econ�mico: {string.Join(", ", ideaEliminarIntegrante.ImpactosEconomicosIdea)}");

                                    Console.WriteLine("Miembros del Equipo:");
                                    foreach (var miembro in ideaEliminarIntegrante.Miembros)
                                    {
                                        Console.WriteLine($"- ID: {miembro.Id}, Nombre: {miembro.Nombre}, Apellidos: {miembro.Apellidos}, Rol: {miembro.Rol}, Email: {miembro.Email}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"No se encontr� un Miembro con el ID {idMiembroEliminar} en la Idea de Negocio.");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No se encontr� una Idea de Negocio con el c�digo {codigoIdeaEliminar}.");
                            }
                            break;

                        case 4:
                            Console.WriteLine("Modificar Valor de Inversi�n de una Idea de Negocio:");
                            Console.Write("Ingrese el c�digo de la Idea de Negocio: ");
                            int codigoIdeaModificarInversion = int.Parse(Console.ReadLine());

                            // Buscar la idea de negocio por su c�digo
                            Idea ideaExistenteModificarInversion = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdeaModificarInversion);

                            if (ideaExistenteModificarInversion != null)
                            {
                                Console.Write("Ingrese el nuevo valor de inversi�n: ");
                                int nuevaInversion = int.Parse(Console.ReadLine());

                                // Llamar al m�todo para modificar el valor de inversi�n
                                ideaExistenteModificarInversion.ModificarValorInversion(nuevaInversion);

                                Console.WriteLine("Valor de inversi�n modificado con �xito.");

                                // Imprimir la idea actualizada con el nuevo valor de inversi�n
                                Console.WriteLine("Detalles de la Idea de Negocio despu�s de modificar la inversi�n:");
                                Console.WriteLine($"C�digo de Idea: {ideaExistenteModificarInversion.CodigoIdea}");
                                Console.WriteLine($"Nombre de la Idea: {ideaExistenteModificarInversion.NombreIdea}");
                                Console.WriteLine($"Inversi�n Requerida: {ideaExistenteModificarInversion.InversionRequeridaIdea}");
                                Console.WriteLine($"Total de Ingresos: {ideaExistenteModificarInversion.ObjetivosDeIngresosIdea}");
                                Console.WriteLine($"Impacto Econ�mico: {string.Join(", ", ideaExistenteModificarInversion.ImpactosEconomicosIdea)}");

                                Console.WriteLine("Miembros del Equipo:");
                                foreach (var miembro in ideaExistenteModificarInversion.Miembros)
                                {
                                    Console.WriteLine($"- ID: {miembro.Id}, Nombre: {miembro.Nombre}, Apellidos: {miembro.Apellidos}, Rol: {miembro.Rol}, Email: {miembro.Email}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No se encontr� una Idea de Negocio con el c�digo {codigoIdeaModificarInversion}.");
                            }
                            break;


                        case 5:
                            Console.WriteLine("Modificar el Valor Total de una Idea de Negocio:");
                            Console.Write("Ingrese el c�digo de la Idea de Negocio: ");
                            int codigoIdeaModificarTotal = int.Parse(Console.ReadLine());

                            // Buscar la idea de negocio por su c�digo
                            Idea ideaExistenteModificarTotal = desarrolloRegional.ObtenerIdeaPorCodigo(codigoIdeaModificarTotal);

                            if (ideaExistenteModificarTotal != null)
                            {
                                Console.Write("Ingrese el nuevo valor total de ingresos: ");
                                int nuevoValorTotal = int.Parse(Console.ReadLine());

                                // Llamar al m�todo para modificar el valor total de ingresos
                                ideaExistenteModificarTotal.ModificarValorTotal(nuevoValorTotal);

                                Console.WriteLine("Valor total de ingresos modificado con �xito.");

                                // Imprimir la idea actualizada
                                Console.WriteLine("Detalles de la Idea de Negocio:");
                                Console.WriteLine($"C�digo de Idea: {ideaExistenteModificarTotal.CodigoIdea}");
                                Console.WriteLine($"Nombre de la Idea: {ideaExistenteModificarTotal.NombreIdea}");
                                Console.WriteLine($"Inversi�n Requerida: {ideaExistenteModificarTotal.InversionRequeridaIdea}");
                                Console.WriteLine($"Total de Ingresos: {ideaExistenteModificarTotal.ObjetivosDeIngresosIdea}");
                                Console.WriteLine($"Impacto Econ�mico: {string.Join(", ", ideaExistenteModificarTotal.ImpactosEconomicosIdea)}");

                                Console.WriteLine("Miembros del Equipo:");
                                foreach (var miembro in ideaExistenteModificarTotal.Miembros)
                                {
                                    Console.WriteLine($"- ID: {miembro.Id}, Nombre: {miembro.Nombre}, Apellidos: {miembro.Apellidos}, Rol: {miembro.Rol}, Email: {miembro.Email}");
                                }
                            }
                            else
                            {
                                Console.WriteLine($"No se encontr� una Idea de Negocio con el c�digo {codigoIdeaModificarTotal}.");
                            }
                            break;

                        case 6:
                            Console.WriteLine("Mostrar la Idea de Negocio que impacta m�s departamentos:");


                            Idea ideaMasImpactante = Controlador.EncontrarIdeaQueImpactaMasDepartamentos(desarrolloRegional);

                            if (ideaMasImpactante != null)
                            {
                                Console.WriteLine("La idea que impacta m�s departamentos es:");
                                Console.WriteLine($"C�digo de Idea: {ideaMasImpactante.CodigoIdea}");
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
                                Console.WriteLine("La idea con m�s ingresos en los primeros 3 a�os es:");
                                Console.WriteLine($"Nombre de la Idea: {ideaMasIngresos.NombreIdea}");
                                Console.WriteLine($"Ingresos en los primeros 3 a�os: {ideaMasIngresos.ObjetivosDeIngresosIdea}");
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
                                Console.WriteLine("Las ideas m�s rentables son:");
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
                                Console.WriteLine("Las ideas que impactan a m�s de 3 departamentos son:");
                                foreach (var idea in ideasImpactandoMasDeTresDepartamentos)
                                {
                                    Console.WriteLine($"Nombre de la Idea: {idea.NombreIdea}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("No se encontraron ideas que impacten a m�s de 3 departamentos.");
                            }
                            break;

                        case 10:        
                            float ingresosTotales = Controlador.CalcularIngresosTotales(desarrolloRegional);

                            Console.WriteLine($"La suma total de ingresos de todas las ideas de negocio es: {ingresosTotales}");
                            break;

                        case 11:
                            float inversionTotal = Controlador.CalcularInversionTotal(desarrolloRegional);

                            Console.WriteLine($"La suma total de la inversi�n que se debe hacer en todas las ideas de negocio es: {inversionTotal}");
                            break;

                        case 12:
                           
                            Idea ideaConMasHerramientas4RI = Controlador.EncontrarIdeaConMasHerramientas4RI(desarrolloRegional);

                            if (ideaConMasHerramientas4RI != null)
                            {
                                Console.WriteLine("Idea con m�s herramientas de 4� Revoluci�n Industrial:");
                                Console.WriteLine($"C�digo de Idea: {ideaConMasHerramientas4RI.CodigoIdea}");
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
                                Console.WriteLine("No se encontraron ideas con herramientas de 4� Revoluci�n Industrial.");
                            }
                            break;

                        case 13:
                      
                            int cantidadIdeasInteligenciaArtificial = Controlador.ContarIdeasConInteligenciaArtificial(desarrolloRegional);

                            Console.WriteLine($"Cantidad de Ideas de Negocio con Inteligencia Artificial: {cantidadIdeasInteligenciaArtificial}");
                            break;


                        default:
                            Console.WriteLine("Opci�n no v�lida. Por favor, seleccione una opci�n v�lida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada no v�lida. Por favor, ingrese un n�mero v�lido.");
                }
            }
        }
    }
}


















