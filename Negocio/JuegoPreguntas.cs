using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class JuegoPreguntas
    {
        public Datos.Pregunta ObtenerPreguntas(int categoria)
        {
            Random Num = new Random();
            int aleatorio;
            List<Datos.Pregunta> preguntasbd = null;
            

            using (JuegoPreguntasEntities context = new JuegoPreguntasEntities())
            {
                preguntasbd = context.Pregunta.Include("Respuestas")
                                                .Include("Categoria").Where(t=>t.NumCategoria == categoria).ToList();
            }

            

            aleatorio = Num.Next(0, preguntasbd.Count());
            

            return preguntasbd[aleatorio];
        }

        public Datos.premio ObtenerPremio(int categoria)
        {
            Datos.premio Premiobd; 
            using (JuegoPreguntasEntities context = new JuegoPreguntasEntities())
            {
                Premiobd = context.premio.Where(t => t.IdCategotia == categoria).FirstOrDefault();
            }
            return Premiobd;
        }

        public void GuardarHistorial(string nombre, int categoria, double premio, bool retiroVoluntario = false)
        {
            Datos.Historial historial = new Datos.Historial
            {
                NombreParticipante = nombre,
                RondaAlcanzada = categoria,
                PremioConseguido = Convert.ToDecimal(premio),
                RetiroVoluntario = retiroVoluntario
            };
            using (JuegoPreguntasEntities context = new JuegoPreguntasEntities())
            {
                context.Historial.Add(historial);
                context.SaveChanges();
            }
        }

    }
}
