using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_entidades
{
    public class TLineTweets
    {
        private string texto;
        private string imagen;
        private DateTime fecha;

        public TLineTweets(string texto, string imagen, DateTime fecha)
        {
            this.texto = texto;
            this.imagen = imagen;
            this.fecha = fecha;
        }

        public string Texto
        {
            get
            {
                return texto;
            }
            set
            {
                texto = value;
            }
        }
        public string Imagen
        {
            get
            {
                return imagen;
            }
            set
            {
                imagen = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
    }
}
