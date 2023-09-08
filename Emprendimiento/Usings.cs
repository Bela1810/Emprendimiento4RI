using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Emprendimiento
{
    public class Miembro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Rol { get; set; }
        public string Email { get; set; }

        public Miembro(int id, string nombre, string apellidos, string rol, string email)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Rol = rol;
            this.Email = email;
        }
    }

    public class Idea
    {
        public List<Miembro> Miembros { get; set; } = new List<Miembro>();
        public int CodigoIdea { get; private set; }
        public string NombreIdea { get; set; }

        /* Aqu� tendremos el color o colores que impacta la idea */
        public List<string> ImpactosEconomicosIdea { get; set; } = new List<string>();

        public float InversionRequeridaIdea { get; set; }
        public float ObjetivosDeIngresosIdea { get; set; }

        /* Aqu� tendremos la herramienta o herramientas que tiene la idea */
        public List<int> Herramientas4RevolucionIndustrialIdea { get; set; } = new List<int>();

        private static int ultimoCodigoGenerado = 0;



        public Idea(string nombreIdea, float inversionRequeridaIdea, float objetivosDeIngresosIdea)
        {

            CodigoIdea = GenerarCodigoUnico();
            this.NombreIdea = nombreIdea;
            this.InversionRequeridaIdea = inversionRequeridaIdea;
            this.ObjetivosDeIngresosIdea = objetivosDeIngresosIdea;



        }

        public List<int> AgregarHerramientas(int herramientas4RI)
        {
            Herramientas4RevolucionIndustrialIdea.Add(herramientas4RI);
            return Herramientas4RevolucionIndustrialIdea;
        }

        public List<string> AgregarImpactosEconomicosIdea(string color)
        {
            ImpactosEconomicosIdea.Add(color);
            return ImpactosEconomicosIdea;
        }

        private static int GenerarCodigoUnico()
        {
            ultimoCodigoGenerado++;
            return ultimoCodigoGenerado;
        }

        public Miembro ObtenerMiembroPorId(int idMiembro)
        {
            return Miembros.FirstOrDefault(miembro => miembro.Id == idMiembro);
        }


        public void AgregarMiembro(int id, string nombre, string apellidos, string rol, string email)
        {
            Miembro nuevoMiembro = new Miembro(id, nombre, apellidos, rol, email);
            Miembros.Add(nuevoMiembro);
        }

        public bool AgregarIntegrante(Miembro miembro)
        {
            if (Miembros.Contains(miembro) || miembro == null)
            {
                return false;
            }

            else
            {
                Miembros.Add(miembro);
                return true;
            }

        }

        public void EliminarIntegrante(Miembro miembro)
        {
            Miembros.Remove(miembro);
        }

        public void ModificarValorInversion(int nuevoValorInversion)
        {
            InversionRequeridaIdea = nuevoValorInversion;
        }

        public void ModificarValorTotal(int nuevoValorTotal)
        {
            ObjetivosDeIngresosIdea = nuevoValorTotal;
        }


    }

    public class DesarrolloRegional
    {
        public List<Idea> IdeasDesarrolloRegional { get; set; } = new List<Idea>();

        public Dictionary<string, string> ColoresEconomia = new Dictionary<string, string>();

        public Dictionary<int, string> Herramientas4RevolucionIndustrial = new Dictionary<int, string>();

        public Dictionary<string, string> Departamentos = new Dictionary<string, string>();

        public Dictionary<string, List<string>> DepartamentoColores = new Dictionary<string, List<string>>();

        public Dictionary<string, List<string>> ColoresDepartamentos = new Dictionary<string, List<string>>();

        public Idea miIdeaEnDesarrolloRegional;

        public DesarrolloRegional()
        {

            ColoresEconomia["Verde"] = "Relacionado con la agricultura, ganader�a, pesca y miner�a.";
            ColoresEconomia["Azul"] = "Incluye industria y manufactura, contribuye al crecimiento econ�mico mediante la producci�n de bienes.";
            ColoresEconomia["Rojo"] = "Compuesto por servicios como educaci�n, salud y finanzas, es esencial para el bienestar econ�mico y social.";
            ColoresEconomia["Morado"] = "Centrado en la investigaci�n y desarrollo, impulsa la innovaci�n y la tecnolog�a avanzada.";
            ColoresEconomia["Dorado"] = "Involucra al gobierno y organizaciones sin fines de lucro, proporciona servicios p�blicos y sociales.";
            ColoresEconomia["Amarillo"] = "Representa el sector de la construcci�n y obras p�blicas, impulsando el desarrollo de infraestructura.";
            ColoresEconomia["Naranja"] = "Incluye el sector de la energ�a, contribuyendo a la producci�n y distribuci�n de energ�a.";

            Herramientas4RevolucionIndustrial[1] = "Inteligencia Artificial y Aprendizaje Autom�tico";
            Herramientas4RevolucionIndustrial[2] = "Internet de las Cosas (IoT)";
            Herramientas4RevolucionIndustrial[3] = "Blockchain y Criptomonedas";
            Herramientas4RevolucionIndustrial[4] = "Realidad Virtual (VR) y Realidad Aumentada (AR)";
            Herramientas4RevolucionIndustrial[5] = "Impresi�n 3D (Fabricaci�n Aditiva)";
            Herramientas4RevolucionIndustrial[6] = "Rob�tica Avanzada";
            Herramientas4RevolucionIndustrial[7] = "Computaci�n Cu�ntica";
            Herramientas4RevolucionIndustrial[8] = "Biolog�a Sint�tica y Gen�mica";
            Herramientas4RevolucionIndustrial[9] = "Nanotecnolog�a";
            Herramientas4RevolucionIndustrial[10] = "Big Data y An�lisis Predictivo";
            Herramientas4RevolucionIndustrial[11] = "Automatizaci�n Industrial y Rob�tica Industrial";

            Departamentos["91000"] = "Amazonas";
            Departamentos["05000"] = "Antioquia";
            Departamentos["81000"] = "Arauca";
            Departamentos["08000"] = "Atl�ntico";
            Departamentos["11000"] = "Bogot� D.C.";
            Departamentos["13000"] = "Bol�var";
            Departamentos["15000"] = "Boyac�";
            Departamentos["17000"] = "Caldas";
            Departamentos["18000"] = "Caquet�";
            Departamentos["85000"] = "Casanare";
            Departamentos["19000"] = "Cauca";
            Departamentos["20000"] = "Cesar";
            Departamentos["27000"] = "Choc�";
            Departamentos["23000"] = "C�rdoba";
            Departamentos["25000"] = "Cundinamarca";
            Departamentos["94000"] = "Guain�a";
            Departamentos["95000"] = "Guaviare";
            Departamentos["41000"] = "Huila";
            Departamentos["44000"] = "La Guajira";
            Departamentos["47000"] = "Magdalena";
            Departamentos["50000"] = "Meta";
            Departamentos["52000"] = "Nari�o";
            Departamentos["54000"] = "Norte de Santander";
            Departamentos["86000"] = "Putumayo";
            Departamentos["63000"] = "Quind�o";
            Departamentos["66000"] = "Risaralda";
            Departamentos["88000"] = "San Andr�s y Providencia";
            Departamentos["68000"] = "Santander";
            Departamentos["70000"] = "Sucre";
            Departamentos["73000"] = "Tolima";
            Departamentos["76000"] = "Valle del Cauca";
            Departamentos["97000"] = "Vaup�s";
            Departamentos["99000"] = "Vichada";

            DepartamentoColores["Amazonas"] = new List<string> { "Verde" };
            DepartamentoColores["Antioquia"] = new List<string> { "Morado", "Naranja" };
            DepartamentoColores["Arauca"] = new List<string> { "Verde", "Naranja" };
            DepartamentoColores["Atl�ntico"] = new List<string> { "Azul", "Rojo" };
            DepartamentoColores["Bogot� D.C."] = new List<string> { "Rojo", "Morado", "Dorado" };
            DepartamentoColores["Bol�var"] = new List<string> { "Verde", "Azul", "Rojo" };
            DepartamentoColores["Boyac�"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Caldas"] = new List<string> { "Verde", "Azul", "Rojo" };
            DepartamentoColores["Caquet�"] = new List<string> { "Verde" };
            DepartamentoColores["Casanare"] = new List<string> { "Verde", "Naranja" };
            DepartamentoColores["Cauca"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Cesar"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Choc�"] = new List<string> { "Verde" };
            DepartamentoColores["C�rdoba"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Cundinamarca"] = new List<string> { "Verde", "Azul", "Rojo" };
            DepartamentoColores["Guain�a"] = new List<string> { "Verde" };
            DepartamentoColores["Guaviare"] = new List<string> { "Verde" };
            DepartamentoColores["Huila"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["La Guajira"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Magdalena"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Meta"] = new List<string> { "Verde", "Naranja" };
            DepartamentoColores["Nari�o"] = new List<string> { "Verde", "Azul" };


            ColoresDepartamentos["Verde"] = new List<string> { "Amazonas", "Arauca", "Bol�var", "Boyac�", "Caldas", "Caquet�", "Casanare", "Cauca", "Cesar", "Choc�",
                "C�rdoba", "Cundinamarca", "Guain�a", "Guaviare", "Huila", "La Guajira", "Magdalena" };
            ColoresDepartamentos["Morado"] = new List<string> { "Antioquia", "Bogot� D.C." };
            ColoresDepartamentos["Naranja"] = new List<string> { "Antioquia", "Arauca", "Casanare" };
            ColoresDepartamentos["Azul"] = new List<string> { "Atl�ntico", "Bol�var", "Boyac�", "Caldas", "Cauca", "Cesar", "C�rdoba", "Cundinamarca" };
            ColoresDepartamentos["Rojo"] = new List<string> { "Atl�ntico", "Bogot� D.C.", "Bol�var", "Caldas" };
            ColoresDepartamentos["Dorado"] = new List<string> { "Bogot� D.C." };

        }



        public Idea? ObtenerIdeaPorCodigo(int codigo)
        {
            if (codigo < 0)
            {
                return null;
            }
            else
            {
                return IdeasDesarrolloRegional.FirstOrDefault(idea => idea.CodigoIdea == codigo);

            }

        }



        public void AgregarIdeaAdesarrollo(Idea idea)
        {
            IdeasDesarrolloRegional.Add(idea);

        }

    }

    public class Controlador
    {


        public static Idea? EncontrarIdeaQueImpactaMasDepartamentos(DesarrolloRegional desarrolloRegional)
        {

            Idea? ideaMasImpactante = null;
            int maximoConteoDepartamentos = 0;

            foreach (Idea? idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                int conteoDepartamentos = 0;
                foreach (string color in idea.ImpactosEconomicosIdea)
                {
                    if (desarrolloRegional.ColoresDepartamentos.ContainsKey(color))
                    {
                        conteoDepartamentos += desarrolloRegional.ColoresDepartamentos[color].Count;
                    }
                }

                if (conteoDepartamentos > maximoConteoDepartamentos)
                {
                    ideaMasImpactante = idea;
                    maximoConteoDepartamentos = conteoDepartamentos;
                }
            }

            return ideaMasImpactante;
        }

        public static List<string> DevolverDepartamentosAfectados(DesarrolloRegional desarrolloRegional)
        {
            List<string> departamentosAfectados = new();

            foreach (Idea idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                foreach (string color in idea.ImpactosEconomicosIdea)
                {
                    if (desarrolloRegional.ColoresDepartamentos.ContainsKey(color))
                    {
                        departamentosAfectados.AddRange(desarrolloRegional.ColoresDepartamentos[color]);
                    }
                }
            }

            return departamentosAfectados.Distinct().ToList();
        }

        public static Idea? EncontrarIdeaConMasIngresos(DesarrolloRegional desarrolloRegional)
        {
            Idea? ideaConMasIngresos = null;

            foreach (Idea idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                if (ideaConMasIngresos == null || idea.ObjetivosDeIngresosIdea > ideaConMasIngresos.ObjetivosDeIngresosIdea)
                {
                    ideaConMasIngresos = idea;
                }
            }

            return ideaConMasIngresos;
        }

        public static List<Idea> EncontrarIdeasMasRentables(DesarrolloRegional desarrolloRegional)
        {
            var ideasOrdenadas = desarrolloRegional.IdeasDesarrolloRegional.OrderByDescending(idea => idea.ObjetivosDeIngresosIdea / idea.InversionRequeridaIdea);
            var ideasMasRentables = ideasOrdenadas.Take(3).ToList();
            return ideasMasRentables;
        }



        public static List<Idea> EncontrarIdeasImpactandoMasDeTresDepartamentos(DesarrolloRegional desarrolloRegional)
        {
            List<Idea> ideasImpactandoMasDeTresDepartamentos = new();

            // Buscar en la lista de ideas para encontrar las ideas que impacten a m�s de 3 departamentos
            for (int i = 0; i < desarrolloRegional.IdeasDesarrolloRegional.Count; i++)
            {
                Idea idea = desarrolloRegional.IdeasDesarrolloRegional[i];
                int conteoDepartamentos = 0;
                for (int j = 0; j < idea.ImpactosEconomicosIdea.Count; j++)
                {
                    string color = idea.ImpactosEconomicosIdea[j];
                    if (desarrolloRegional.ColoresDepartamentos.ContainsKey(color))
                    {
                        conteoDepartamentos += desarrolloRegional.ColoresDepartamentos[color].Count;
                    }
                }
                if (conteoDepartamentos > 3)
                {
                    ideasImpactandoMasDeTresDepartamentos.Add(idea);
                }
            }

            return ideasImpactandoMasDeTresDepartamentos;
        }




        public static float CalcularIngresosTotales(DesarrolloRegional desarrolloRegional)
        {
            float ingresosTotales = 0;

            foreach (Idea idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                ingresosTotales += idea.ObjetivosDeIngresosIdea;
            }

            return ingresosTotales;
        }

        public static float CalcularInversionTotal(DesarrolloRegional desarrolloRegional)
        {
            float inversionTotal = 0;

            foreach (Idea idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                inversionTotal += idea.InversionRequeridaIdea;
            }

            return inversionTotal;
        }

        public static Idea? EncontrarIdeaConMasHerramientas4RI(DesarrolloRegional desarrolloRegional)
        {
            Idea? ideaConMasHerramientas4RI = null;

            foreach (Idea idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                if (ideaConMasHerramientas4RI == null || idea.Herramientas4RevolucionIndustrialIdea.Count > ideaConMasHerramientas4RI.Herramientas4RevolucionIndustrialIdea.Count)
                {
                    ideaConMasHerramientas4RI = idea;
                }
            }

            return ideaConMasHerramientas4RI;
        }

        public static int ContarIdeasConInteligenciaArtificial(DesarrolloRegional desarrolloRegional)
        {
            int conteo = 0;

            foreach (Idea idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                if (idea.Herramientas4RevolucionIndustrialIdea.Contains(1))
                {
                    conteo++;
                }
            }

            return conteo;
        }



        public static List<Idea> ObtenerTodasLasIdeas(DesarrolloRegional desarrolloRegional)
        {
            // Retorna todas las ideas almacenadas en forma de lista
            return desarrolloRegional.IdeasDesarrolloRegional;
        }



    }




}