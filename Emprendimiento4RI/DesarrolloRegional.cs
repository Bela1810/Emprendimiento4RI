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
            Herramientas4RevolucionIndustrial[12] = "Desarrollo sostenible usando una o mas herramientas de la cuarta revolucion industrial";

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
}