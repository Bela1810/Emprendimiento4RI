using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Emprendimiento
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PruebaCodigoIdea()
        {

            int variableEsperada = 1;
            Idea pruebaIdea = new Idea("Robotica", 300, 400);
            pruebaIdea.AgregarImpactosEconomicosIdea("Verde");
            pruebaIdea.AgregarMiembro(45, "Juan", "Gomez", "Jefe", "juangomez@");
            pruebaIdea.AgregarHerramientas(3);
            pruebaIdea.AgregarHerramientas(10);
            int variableCodigo = pruebaIdea.CodigoIdea;


            Assert.AreEqual(variableEsperada, variableCodigo, 0, "El codigo no se esta generando correctamente");
        }

        [TestMethod]
        public void PruebaEstadistica1()
        {
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional();

            string nombreIdeaEsperada = "Robotica";
            Idea pruebaIdea = new Idea("Robotica", 300, 400);
            pruebaIdea.AgregarImpactosEconomicosIdea("Verde");
            pruebaIdea.AgregarMiembro(45, "Juan", "Gomez", "Jefe", "juangomez@");
            pruebaIdea.AgregarHerramientas(3);
            pruebaIdea.AgregarHerramientas(10);


            desarrolloRegional.AgregarIdeaAdesarrollo(pruebaIdea);

            Idea pruebaIdea2 = new Idea("Habeas Data", 900, 100);
            pruebaIdea2.AgregarImpactosEconomicosIdea("Rojo");
            pruebaIdea2.AgregarMiembro(78, "Karla", "lopez", "Developer", "karla6565@");
            pruebaIdea2.AgregarHerramientas(6);

            desarrolloRegional.AgregarIdeaAdesarrollo(pruebaIdea2);

            Idea ideaImpacteMasDepartamentos = Controlador.EncontrarIdeaQueImpactaMasDepartamentos(desarrolloRegional);

            Assert.AreEqual(nombreIdeaEsperada, ideaImpacteMasDepartamentos.NombreIdea);


        }

        [TestMethod]
        public void PruebaEstadistica2()
        {
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional();

            int inversionEsperada = 300;
            Idea pruebaIdea = new Idea("Robotica", 300, 400);
            pruebaIdea.AgregarImpactosEconomicosIdea("Verde");
            pruebaIdea.AgregarMiembro(45, "Juan", "Gomez", "Jefe", "juangomez@");
            pruebaIdea.AgregarHerramientas(3);
            pruebaIdea.AgregarHerramientas(10);


            desarrolloRegional.AgregarIdeaAdesarrollo(pruebaIdea);

            Idea pruebaIdea2 = new Idea("Habeas Data", 900, 100);
            pruebaIdea2.AgregarImpactosEconomicosIdea("Rojo");
            pruebaIdea2.AgregarMiembro(78, "Karla", "lopez", "Developer", "karla6565@");
            pruebaIdea2.AgregarHerramientas(6);

            desarrolloRegional.AgregarIdeaAdesarrollo(pruebaIdea2);

            Idea ideaImpacteMasDepartamentos = Controlador.EncontrarIdeaConMasIngresos(desarrolloRegional);

            Assert.AreEqual(inversionEsperada, ideaImpacteMasDepartamentos.InversionRequeridaIdea);


        }

        [TestMethod]
        public void PruebaEstadistica3()
        {
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional();

            string nombrePosicion1 = "Robotica";
            Idea pruebaIdea = new Idea("Robotica", 300, 400);
            pruebaIdea.AgregarImpactosEconomicosIdea("Verde");
            pruebaIdea.AgregarMiembro(45, "Juan", "Gomez", "Jefe", "juangomez@");
            pruebaIdea.AgregarHerramientas(3);
            pruebaIdea.AgregarHerramientas(10);


            desarrolloRegional.AgregarIdeaAdesarrollo(pruebaIdea);

            Idea pruebaIdea2 = new Idea("Habeas Data", 900, 100);
            pruebaIdea2.AgregarImpactosEconomicosIdea("Rojo");
            pruebaIdea2.AgregarMiembro(78, "Karla", "lopez", "Developer", "karla6565@");
            pruebaIdea2.AgregarHerramientas(6);

            desarrolloRegional.AgregarIdeaAdesarrollo(pruebaIdea2);

            List<Idea> listaIdeasMasRentables = Controlador.EncontrarIdeasMasRentables(desarrolloRegional);

            Assert.AreEqual(nombrePosicion1, listaIdeasMasRentables[0].NombreIdea);


        }
    }
}