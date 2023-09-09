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

            int variableEsperada = 5;
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

        [TestMethod]
        public void PruebaEncontrarIdeasImpactandoMasDeTresDepartamentos()
        {
            // Arrange: Configuración inicial
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional();

            Idea pruebaIdea1 = new Idea("Idea1", 300, 400);
            pruebaIdea1.AgregarImpactosEconomicosIdea("Verde");
            pruebaIdea1.AgregarImpactosEconomicosIdea("Rojo");
            pruebaIdea1.AgregarMiembro(45, "Juan", "Gomez", "Jefe", "juangomez@");
            pruebaIdea1.AgregarHerramientas(3);
            pruebaIdea1.AgregarHerramientas(10);

            desarrolloRegional.AgregarIdeaAdesarrollo(pruebaIdea1);

            Idea pruebaIdea2 = new Idea("Idea2", 900, 100);
            pruebaIdea2.AgregarImpactosEconomicosIdea("Rojo");
            pruebaIdea2.AgregarMiembro(78, "Karla", "Lopez", "Developer", "karla6565@");
            pruebaIdea2.AgregarHerramientas(6);

            desarrolloRegional.AgregarIdeaAdesarrollo(pruebaIdea2);

            
            List<Idea> ideasImpactandoMasDeTresDepartamentos = Controlador.EncontrarIdeasImpactandoMasDeTresDepartamentos(desarrolloRegional);

            // Assert: Verificar los resultados
            Assert.AreEqual(2, ideasImpactandoMasDeTresDepartamentos.Count); // Ninguna de las ideas cumple con la condición
        }

        [TestMethod]
        public void PruebaCalcularIngresosTotales()
        {
            // Arrange: 
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional();

            
            Idea idea1 = new Idea("Idea1", 300, 400);
            idea1.AgregarMiembro(45, "Juan", "Gomez", "Jefe", "juangomez@");
            idea1.AgregarHerramientas(3);
            idea1.AgregarHerramientas(10);

            Idea idea2 = new Idea("Idea2", 900, 100);
            idea2.AgregarMiembro(78, "Karla", "Lopez", "Developer", "karla6565@");
            idea2.AgregarHerramientas(6);

            desarrolloRegional.AgregarIdeaAdesarrollo(idea1);
            desarrolloRegional.AgregarIdeaAdesarrollo(idea2);

            // Act: 
            float ingresosTotales = Controlador.CalcularIngresosTotales(desarrolloRegional);

            // Assert: Verificar los resultados
          
            float ingresosEsperados = idea1.ObjetivosDeIngresosIdea + idea2.ObjetivosDeIngresosIdea;

            Assert.AreEqual(ingresosEsperados, ingresosTotales);
        }

        [TestMethod]
        public void PruebaCalcularInversionTotal()
        {
            // Arrange: 
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional();

            // Crear algunas ideas con inversiones requeridas
            Idea idea1 = new Idea("Idea1", 300, 400);
            idea1.AgregarMiembro(45, "Juan", "Gomez", "Jefe", "juangomez@");
            idea1.AgregarHerramientas(3);
            idea1.AgregarHerramientas(10);

            Idea idea2 = new Idea("Idea2", 900, 100);
            idea2.AgregarMiembro(78, "Karla", "Lopez", "Developer", "karla6565@");
            idea2.AgregarHerramientas(6);

            desarrolloRegional.AgregarIdeaAdesarrollo(idea1);
            desarrolloRegional.AgregarIdeaAdesarrollo(idea2);

            // Act: 
            float inversionTotal = Controlador.CalcularInversionTotal(desarrolloRegional);

            // Assert: Verificar los resultados
           

            float inversionEsperada = idea1.InversionRequeridaIdea + idea2.InversionRequeridaIdea;

            Assert.AreEqual(inversionEsperada, inversionTotal);
        }

        [TestMethod]
        public void PruebaEncontrarIdeaConMasHerramientas4RI()
        {
            // Arrange: Configuración inicial
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional();

            // Crear algunas ideas con herramientas de la 4RI
            Idea idea1 = new Idea("Idea1", 300, 400);
            idea1.AgregarMiembro(45, "Juan", "Gomez", "Jefe", "juangomez@");
            idea1.AgregarHerramientas(3);
            idea1.AgregarHerramientas(10);

            Idea idea2 = new Idea("Idea2", 900, 100);
            idea2.AgregarMiembro(78, "Karla", "Lopez", "Developer", "karla6565@");
            idea2.AgregarHerramientas(8);

            desarrolloRegional.AgregarIdeaAdesarrollo(idea1);
            desarrolloRegional.AgregarIdeaAdesarrollo(idea2);

            // Act: Llamar al método que estamos probando
            Idea? ideaConMasHerramientas4RI = Controlador.EncontrarIdeaConMasHerramientas4RI(desarrolloRegional);

            // Assert: Verificar los resultados
           
            Assert.AreEqual(idea1, ideaConMasHerramientas4RI);
        }

        [TestMethod]
        public void PruebaContarIdeasConInteligenciaArtificial()
        {
            // Arrange: Configuración inicial
            DesarrolloRegional desarrolloRegional = new DesarrolloRegional();

            // Crear algunas ideas con herramientas de la 4RI, incluyendo la de Inteligencia Artificial (1)
            Idea idea1 = new Idea("Idea1", 300, 400);
            idea1.AgregarMiembro(45, "Juan", "Gomez", "Jefe", "juangomez@");
            idea1.AgregarHerramientas(1);

            Idea idea2 = new Idea("Idea2", 900, 100);
            idea2.AgregarMiembro(78, "Karla", "Lopez", "Developer", "karla6565@");
            idea2.AgregarHerramientas(2);

            Idea idea3 = new Idea("Idea3", 500, 600);
            idea3.AgregarMiembro(32, "Ana", "Perez", "Analista", "anaperez@");
            idea3.AgregarHerramientas(1);

            desarrolloRegional.AgregarIdeaAdesarrollo(idea1);
            desarrolloRegional.AgregarIdeaAdesarrollo(idea2);
            desarrolloRegional.AgregarIdeaAdesarrollo(idea3);

            // Act: Llamar al método que estamos probando
            int conteoIdeasConInteligenciaArtificial = Controlador.ContarIdeasConInteligenciaArtificial(desarrolloRegional);

            // Assert: Verificar los resultados
            // Las ideas 1 y 3 deberían contener herramientas de Inteligencia Artificial (1)
            // Por lo tanto, esperamos un conteo de 2
            Assert.AreEqual(2, conteoIdeasConInteligenciaArtificial);
        }








    }
}