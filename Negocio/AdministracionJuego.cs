using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class AdministracionJuego
    {
        public List<Categoria> ObtenerCategorias()
        {
            List<Datos.Categoria> categoriasbd = null;
            List<Categoria> categorias = new List<Categoria>();

            using (JuegoPreguntasEntities context = new JuegoPreguntasEntities())
            {
                categoriasbd = context.Categoria.ToList();
            }

            foreach (var categoria in categoriasbd)
            {
                var cat = new Categoria
                {
                    NumeroCategoria = categoria.NumeroCategoria
                };

                categorias.Add(cat);
            }

            return categorias;
        }

        public void GuardarPreguntas(Pregunta pregunta)
        {
            using (JuegoPreguntasEntities context = new JuegoPreguntasEntities())
            {
                var respuestasDatos = new List<Respuestas>();

                foreach (var opcion in pregunta.OpcionRespueta)
                {
                    var respuestaDatos = new Respuestas
                    {
                        TextoRespuesta = opcion.TextoRespuesta,
                        Correcta = opcion.EsCorrecta
                    };
                    respuestasDatos.Add(respuestaDatos);
                }

                Datos.Pregunta preguntaDatos = new Datos.Pregunta
                {
                    NumCategoria = pregunta.NumCategoria,
                    TextoPregunta = pregunta.TextoPreguntaa,
                    Respuestas = respuestasDatos
                };

                context.Pregunta.Add(preguntaDatos);
                context.SaveChanges();
            }
        }
    }


}
