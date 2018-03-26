using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capa_negocio
{
    public class UsuariosFollowers
    {
        private string imagen;
        private string nombre;
        private int followers;

        public UsuariosFollowers(string imagen, string nombre, int followers)
        {
            this.imagen = imagen;
            this.nombre = nombre;
            this.followers = followers;
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

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public int Followers
        {
            get
            {
                return followers;
            }
            set
            {
                followers = value;
            }
        }
    }
}
