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
        public List<Miembro> _Miembros { get; set; } = new List<Miembro>();
        public int CódigoIdea { get; private set; }
        public string NombreIdea { get; set; }

        /* Aquí tendremos el color o colores que impacta la idea */
        public List<string> ImpactosEconómicosIdea { get; set; } = new List<string>();

        public float InversiónRequeridaIdea { get; set; }
        public float ObjetivosDeIngresosIdea { get; set; }

        /* Aquí tendremos la herramienta o herramientas que tiene la idea */
        public List<int> Herramientas4RevoluciónIndustrialIdea { get; set; } = new List<int>();

        public Idea(string nombreIdea, float inversiónRequeridaIdea, float objetivosDeIngresosIdea)
        {
            CódigoIdea = GenerarCodigoUnico();
            this.NombreIdea = nombreIdea;
            this.InversiónRequeridaIdea = inversiónRequeridaIdea;
            this.ObjetivosDeIngresosIdea = objetivosDeIngresosIdea;
        }

        public List<int> DevolverHerramientas(int herramientas4RI)
        {
            Herramientas4RevoluciónIndustrialIdea.Add(herramientas4RI);
            return Herramientas4RevoluciónIndustrialIdea;
        }

        public List<string> DevolverImpactosEconómicosIdea(string color)
        {
            ImpactosEconómicosIdea.Add(color);
            return ImpactosEconómicosIdea;
        }

        private static Random random = new Random();
        private int GenerarCodigoUnico()
        {
            int codigoNuevo = random.Next(100, 999);
            return codigoNuevo;
        }

        public void AgregarMiembro(int id, string nombre, string apellidos, string rol, string email)
        {
            Miembro nuevoMiembro = new Miembro(id, nombre, apellidos, rol, email);
            _Miembros.Add(nuevoMiembro);
        }


    }

    public class DesarrolloRegional
    {
        public List<Idea> IdeasDesarrolloRegional { get; set; } = new List<Idea>();

        public Dictionary<string, string> ColoresEconomía = new Dictionary<string, string>();

        public Dictionary<int, string> Herramientas4RevoluciónIndustrial = new Dictionary<int, string>();

        public Dictionary<string, string> Departamentos = new Dictionary<string, string>();

        public Dictionary<string, List<string>> DepartamentoColores = new Dictionary<string, List<string>>();

        public Dictionary<string, List<string>> ColoresDepartamentos = new Dictionary<string, List<string>>();

        public DesarrolloRegional()
        {
            ColoresEconomía["Verde"] = "Relacionado con la agricultura, ganadería, pesca y minería.";
            ColoresEconomía["Azul"] = "Incluye industria y manufactura, contribuye al crecimiento económico mediante la producción de bienes.";
            ColoresEconomía["Rojo"] = "Compuesto por servicios como educación, salud y finanzas, es esencial para el bienestar económico y social.";
            ColoresEconomía["Morado"] = "Centrado en la investigación y desarrollo, impulsa la innovación y la tecnología avanzada.";
            ColoresEconomía["Dorado"] = "Involucra al gobierno y organizaciones sin fines de lucro, proporciona servicios públicos y sociales.";
            ColoresEconomía["Amarillo"] = "Representa el sector de la construcción y obras públicas, impulsando el desarrollo de infraestructura.";
            ColoresEconomía["Naranja"] = "Incluye el sector de la energía, contribuyendo a la producción y distribución de energía.";

            Herramientas4RevoluciónIndustrial[1] = "Inteligencia Artificial y Aprendizaje Automático";
            Herramientas4RevoluciónIndustrial[2] = "Internet de las Cosas (IoT)";
            Herramientas4RevoluciónIndustrial[3] = "Blockchain y Criptomonedas";
            Herramientas4RevoluciónIndustrial[4] = "Realidad Virtual (VR) y Realidad Aumentada (AR)";
            Herramientas4RevoluciónIndustrial[5] = "Impresión 3D (Fabricación Aditiva)";
            Herramientas4RevoluciónIndustrial[6] = "Robótica Avanzada";
            Herramientas4RevoluciónIndustrial[7] = "Computación Cuántica";
            Herramientas4RevoluciónIndustrial[8] = "Biología Sintética y Genómica";
            Herramientas4RevoluciónIndustrial[9] = "Nanotecnología";
            Herramientas4RevoluciónIndustrial[10] = "Big Data y Análisis Predictivo";
            Herramientas4RevoluciónIndustrial[11] = "Automatización Industrial y Robótica Industrial";

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

        public bool ExisteIdeaConCodigo(int codigo)
        {
            // Itera a través de la lista de Ideas y verifica si alguno tiene el código dado
            foreach (Idea idea in IdeasDesarrolloRegional)
            {
                if (idea.CódigoIdea == codigo)
                {
                    return true; // El código existe en la lista
                }
            }
            return false; // El código no existe en la lista
        }

        public Idea ObtenerIdeaPorCodigo(int codigo)
        {
            return IdeasDesarrolloRegional.FirstOrDefault(idea => idea.CódigoIdea == codigo);
        }

       




    }

    public class Controlador
    {
        private DesarrolloRegional desarrolloRegional;
        public Idea EncontrarIdeaQueImpactaMásDepartamentos(DesarrolloRegional desarrolloRegional)
        {

            Idea ideaMásImpactante = null;
            int máximoConteoDepartamentos = 0;

            foreach (Idea idea in desarrolloRegional.IdeasDesarrolloRegional)
            {
                int conteoDepartamentos = 0;
                foreach (string color in idea.ImpactosEconómicosIdea)
                {
                    if (desarrolloRegional.ColoresDepartamentos.ContainsKey(color))
                    {
                        conteoDepartamentos += desarrolloRegional.ColoresDepartamentos[color].Count;
                    }
                }

                if (conteoDepartamentos > máximoConteoDepartamentos)
                {
                    ideaMásImpactante = idea;
                    máximoConteoDepartamentos = conteoDepartamentos;
                }
            }

            return ideaMásImpactante;
        }

        public List<string> DevolverDepartamentosAfectados(List<Idea> ideas, DesarrolloRegional desarrolloRegional)
        {
            List<string> departamentosAfectados = new List<string>();

            foreach (Idea idea in ideas)
            {
                foreach (string color in idea.ImpactosEconómicosIdea)
                {
                    if (desarrolloRegional.ColoresDepartamentos.ContainsKey(color))
                    {
                        departamentosAfectados.AddRange(desarrolloRegional.ColoresDepartamentos[color]);
                    }
                }
            }

            return departamentosAfectados.Distinct().ToList();
        }

        public Idea EncontrarIdeaConMásIngresos(List<Idea> ideas)
        {
            Idea ideaConMásIngresos = null;

            foreach (Idea idea in ideas)
            {
                if (ideaConMásIngresos == null || idea.ObjetivosDeIngresosIdea > ideaConMásIngresos.ObjetivosDeIngresosIdea)
                {
                    ideaConMásIngresos = idea;
                }
            }

            return ideaConMásIngresos;
        }

        public List<Idea> EncontrarIdeasMásRentables(List<Idea> ideas)
        {
            var ideasOrdenadas = ideas.OrderByDescending(idea => idea.ObjetivosDeIngresosIdea / idea.InversiónRequeridaIdea);
            var rentabilidadMáxima = ideasOrdenadas.First().ObjetivosDeIngresosIdea / ideasOrdenadas.First().InversiónRequeridaIdea;

            var ideasMásRentables = ideasOrdenadas.TakeWhile(idea => idea.ObjetivosDeIngresosIdea / idea.InversiónRequeridaIdea == rentabilidadMáxima).ToList();

            return ideasMásRentables;     
        }


        public List<Idea> EncontrarIdeasImpactandoMásDeTresDepartamentos(DesarrolloRegional desarrolloRegional)
        {
            List<Idea> ideasImpactandoMásDeTresDepartamentos = new List<Idea>();

            // Encontrar los colores que están asociados con más de 3 departamentos
            List<string> coloresImpactandoMásDeTresDepartamentos = new List<string>();
            foreach (KeyValuePair<string, List<string>> par in desarrolloRegional.ColoresDepartamentos)
            {
                if (par.Value.Count > 3)
                {
                    coloresImpactandoMásDeTresDepartamentos.Add(par.Key);
                }
            }

            // Buscar en la lista de ideas para encontrar las ideas que tengan esos colores en su lista de impactos económicos
            for (int i = 0; i < desarrolloRegional.IdeasDesarrolloRegional.Count; i++)
            {
                Idea idea = desarrolloRegional.IdeasDesarrolloRegional[i];
                for (int j = 0; j < idea.ImpactosEconómicosIdea.Count; j++)
                {
                    string color = idea.ImpactosEconómicosIdea[j];
                    if (coloresImpactandoMásDeTresDepartamentos.Contains(color))
                    {
                        ideasImpactandoMásDeTresDepartamentos.Add(idea);
                        break;
                    }
                }
            }

            return ideasImpactandoMásDeTresDepartamentos;
        }

        public float CalcularIngresosTotales(List<Idea> ideas)
        {
            float ingresosTotales = 0;

            foreach (Idea idea in ideas)
            {
                ingresosTotales += idea.ObjetivosDeIngresosIdea;
            }

            return ingresosTotales;
        }

        public float CalcularInversiónTotal(List<Idea> ideas)
        {
            float inversiónTotal = 0;

            foreach (Idea idea in ideas)
            {
                inversiónTotal += idea.InversiónRequeridaIdea;
            }

            return inversiónTotal;
        }

        public Idea EncontrarIdeaConMásHerramientas4RI(List<Idea> ideas)
        {
            Idea ideaConMásHerramientas4RI = null;

            foreach (Idea idea in ideas)
            {
                if (ideaConMásHerramientas4RI == null || idea.Herramientas4RevoluciónIndustrialIdea.Count > ideaConMásHerramientas4RI.Herramientas4RevoluciónIndustrialIdea.Count)
                {
                    ideaConMásHerramientas4RI = idea;
                }
            }

            return ideaConMásHerramientas4RI;
        }

        public int ContarIdeasConInteligenciaArtificial(List<Idea> ideas)
        {
            int conteo = 0;

            foreach (Idea idea in ideas)
            {
                if (idea.Herramientas4RevoluciónIndustrialIdea.Contains(1))
                {
                    conteo++;
                }
            }

            return conteo;
        }

        public void AgregarIntegrante(Idea idea, Miembro miembro)
        {
            idea._Miembros.Add(miembro);
        }

        public void EliminarIntegrante(Idea idea, Miembro miembro)
        {
            idea._Miembros.Remove(miembro);
        }

        public void ModificarValorInversion(Idea idea, int nuevoValorInversion)
        {
            idea.InversiónRequeridaIdea = nuevoValorInversion;
        }

        public void ModificarValorTotal(Idea idea, int nuevoValorTotal)
        {
            idea.ObjetivosDeIngresosIdea = nuevoValorTotal;
        }

        public List<Idea> ObtenerTodasLasIdeas()
        {
            // Retorna todas las ideas almacenadas en forma de lista
            return desarrolloRegional.IdeasDesarrolloRegional;
        }



    }
}
