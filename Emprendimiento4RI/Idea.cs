using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using System.Linq;

namespace Emprendimiento
{

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
            return ++ultimoCodigoGenerado;
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
}