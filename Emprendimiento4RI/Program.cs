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

        /* Aquí tendremos el color o colores que impacta la idea */
        public List<string> ImpactosEconomicosIdea { get; set; } = new List<string>();

        public float InversionRequeridaIdea { get; set; }
        public float ObjetivosDeIngresosIdea { get; set; }

        /* Aquí tendremos la herramienta o herramientas que tiene la idea */
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

            ColoresEconomia["Verde"] = "Relacionado con la agricultura, ganadería, pesca y minería.";
            ColoresEconomia["Azul"] = "Incluye industria y manufactura, contribuye al crecimiento económico mediante la producción de bienes.";
            ColoresEconomia["Rojo"] = "Compuesto por servicios como educación, salud y finanzas, es esencial para el bienestar económico y social.";
            ColoresEconomia["Morado"] = "Centrado en la investigación y desarrollo, impulsa la innovación y la tecnología avanzada.";
            ColoresEconomia["Dorado"] = "Involucra al gobierno y organizaciones sin fines de lucro, proporciona servicios públicos y sociales.";
            ColoresEconomia["Amarillo"] = "Representa el sector de la construcción y obras públicas, impulsando el desarrollo de infraestructura.";
            ColoresEconomia["Naranja"] = "Incluye el sector de la energía, contribuyendo a la producción y distribución de energía.";

            Herramientas4RevolucionIndustrial[1] = "Inteligencia Artificial y Aprendizaje Automático";
            Herramientas4RevolucionIndustrial[2] = "Internet de las Cosas (IoT)";
            Herramientas4RevolucionIndustrial[3] = "Blockchain y Criptomonedas";
            Herramientas4RevolucionIndustrial[4] = "Realidad Virtual (VR) y Realidad Aumentada (AR)";
            Herramientas4RevolucionIndustrial[5] = "Impresión 3D (Fabricación Aditiva)";
            Herramientas4RevolucionIndustrial[6] = "Robótica Avanzada";
            Herramientas4RevolucionIndustrial[7] = "Computación Cuántica";
            Herramientas4RevolucionIndustrial[8] = "Biología Sintética y Genómica";
            Herramientas4RevolucionIndustrial[9] = "Nanotecnología";
            Herramientas4RevolucionIndustrial[10] = "Big Data y Análisis Predictivo";
            Herramientas4RevolucionIndustrial[11] = "Automatización Industrial y Robótica Industrial";

            Departamentos["91000"] = "Amazonas";
            Departamentos["05000"] = "Antioquia";
            Departamentos["81000"] = "Arauca";
            Departamentos["08000"] = "Atlántico";
            Departamentos["11000"] = "Bogotá D.C.";
            Departamentos["13000"] = "Bolívar";
            Departamentos["15000"] = "Boyacá";
            Departamentos["17000"] = "Caldas";
            Departamentos["18000"] = "Caquetá";
            Departamentos["85000"] = "Casanare";
            Departamentos["19000"] = "Cauca";
            Departamentos["20000"] = "Cesar";
            Departamentos["27000"] = "Chocó";
            Departamentos["23000"] = "Córdoba";
            Departamentos["25000"] = "Cundinamarca";
            Departamentos["94000"] = "Guainía";
            Departamentos["95000"] = "Guaviare";
            Departamentos["41000"] = "Huila";
            Departamentos["44000"] = "La Guajira";
            Departamentos["47000"] = "Magdalena";
            Departamentos["50000"] = "Meta";
            Departamentos["52000"] = "Nariño";
            Departamentos["54000"] = "Norte de Santander";
            Departamentos["86000"] = "Putumayo";
            Departamentos["63000"] = "Quindío";
            Departamentos["66000"] = "Risaralda";
            Departamentos["88000"] = "San Andrés y Providencia";
            Departamentos["68000"] = "Santander";
            Departamentos["70000"] = "Sucre";
            Departamentos["73000"] = "Tolima";
            Departamentos["76000"] = "Valle del Cauca";
            Departamentos["97000"] = "Vaupés";
            Departamentos["99000"] = "Vichada";

            DepartamentoColores["Amazonas"] = new List<string> { "Verde" };
            DepartamentoColores["Antioquia"] = new List<string> { "Morado", "Naranja" };
            DepartamentoColores["Arauca"] = new List<string> { "Verde", "Naranja" };
            DepartamentoColores["Atlántico"] = new List<string> { "Azul", "Rojo" };
            DepartamentoColores["Bogotá D.C."] = new List<string> { "Rojo", "Morado", "Dorado" };
            DepartamentoColores["Bolívar"] = new List<string> { "Verde", "Azul", "Rojo" };
            DepartamentoColores["Boyacá"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Caldas"] = new List<string> { "Verde", "Azul", "Rojo" };
            DepartamentoColores["Caquetá"] = new List<string> { "Verde" };
            DepartamentoColores["Casanare"] = new List<string> { "Verde", "Naranja" };
            DepartamentoColores["Cauca"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Cesar"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Chocó"] = new List<string> { "Verde" };
            DepartamentoColores["Córdoba"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Cundinamarca"] = new List<string> { "Verde", "Azul", "Rojo" };
            DepartamentoColores["Guainía"] = new List<string> { "Verde" };
            DepartamentoColores["Guaviare"] = new List<string> { "Verde" };
            DepartamentoColores["Huila"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["La Guajira"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Magdalena"] = new List<string> { "Verde", "Azul" };
            DepartamentoColores["Meta"] = new List<string> { "Verde", "Naranja" };
            DepartamentoColores["Nariño"] = new List<string> { "Verde", "Azul" };


            ColoresDepartamentos["Verde"] = new List<string> { "Amazonas", "Arauca", "Bolívar", "Boyacá", "Caldas", "Caquetá", "Casanare", "Cauca", "Cesar", "Chocó",
                "Córdoba", "Cundinamarca", "Guainía", "Guaviare", "Huila", "La Guajira", "Magdalena" };
            ColoresDepartamentos["Morado"] = new List<string> { "Antioquia", "Bogotá D.C." };
            ColoresDepartamentos["Naranja"] = new List<string> { "Antioquia", "Arauca", "Casanare" };
            ColoresDepartamentos["Azul"] = new List<string> { "Atlántico", "Bolívar", "Boyacá", "Caldas", "Cauca", "Cesar", "Córdoba", "Cundinamarca" };
            ColoresDepartamentos["Rojo"] = new List<string> { "Atlántico", "Bogotá D.C.", "Bolívar", "Caldas" };
            ColoresDepartamentos["Dorado"] = new List<string> { "Bogotá D.C." };

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

            // Buscar en la lista de ideas para encontrar las ideas que impacten a más de 3 departamentos
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