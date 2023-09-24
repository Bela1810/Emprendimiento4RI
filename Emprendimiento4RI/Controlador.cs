using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Emprendimiento
{
  
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

        public static List<Idea> PromedioIdeasMasRentables(DesarrolloRegional desarrolloRegional)
        {
            List<Idea> IdeasRentables = new();
            float PromedioAcumulado = 0;

            foreach (Idea idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                float acumulado = idea.ObjetivosDeIngresosIdea / idea.InversionRequeridaIdea;
                PromedioAcumulado = PromedioAcumulado + acumulado;

            }

            PromedioAcumulado /= desarrolloRegional.IdeasDesarrolloRegional.Count();


            foreach (Idea idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                float actual = idea.ObjetivosDeIngresosIdea / idea.InversionRequeridaIdea;

                if (actual > PromedioAcumulado)
                    IdeasRentables.Add(idea);
            }


            return IdeasRentables;
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


        public static List<Idea> ContarIdeasConDesarrolloSostenible(DesarrolloRegional desarrolloRegional)
        {
            List<Idea> IdeasConDesarrolloSostenible = new();

            foreach (Idea idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                if (idea.Herramientas4RevolucionIndustrialIdea.Contains(12))
                {
                    IdeasConDesarrolloSostenible.Add(idea);
                }
            }

            return IdeasConDesarrolloSostenible;
        }



    }

            


}