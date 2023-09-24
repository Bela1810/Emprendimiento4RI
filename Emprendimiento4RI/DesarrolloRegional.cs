using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Emprendimiento
{
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
            Herramientas4RevolucionIndustrial[12] = "Desarrollo sostenible usando una o mas herramientas de la cuarta revolucion industrial";

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
}