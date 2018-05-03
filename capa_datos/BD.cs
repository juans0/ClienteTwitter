using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using System.IO;
using capa_entidades;

namespace capa_datos
{
    public class BD
    {
        private SQLiteConnection baseDatos;            

        public BD()
        {
            try
            {
                baseDatos = new SQLiteConnection("MiTwitterApp.db");
                baseDatos.CreateTable<MiTweet>();
                baseDatos.CreateTable<TweetProgramado>();
                baseDatos.CreateTable<UserApp>();
                baseDatos.CreateTable<Mencion>();
                baseDatos.CreateTable<Promocion>();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al crear la BD " + e);
            }
        }

        public int anyadirUsuario(UserApp usuario)
        {
            try
            {
                baseDatos.Insert(usuario);
            }
            catch (Exception e)
            {
                Console.WriteLine("No se ha podido añadir el usario a la " +
                    "base de datos: " + e);
                return 0;
            }
            return 1;
        }

        public List<UserApp> cargarUsuarios()
        {
            List<UserApp> usuarios = new List<UserApp>();

            try
            {
                TableQuery<UserApp> tablaUsuarios = baseDatos.Table<UserApp>();

                for (int i = 0; i < tablaUsuarios.Count(); i++)
                {
                    usuarios.Add(tablaUsuarios.ElementAt(i));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            return usuarios;            
        }

        public List<TweetProgramado> cargarTweetProgramado()
        {
            List<TweetProgramado> tweetsProg = new List<TweetProgramado>();

            try
            {
                TableQuery<TweetProgramado> tweets = 
                    baseDatos.Table<TweetProgramado>();

                for (int i = 0; i < tweets.Count(); i++)
                {
                    tweetsProg.Add(tweets.ElementAt(i));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
            }
            return tweetsProg;
        }

        public int eliminarTweetProgramado(int idTweet)
        {
            try
            {
                baseDatos.Execute("Delete from TweetProgramado where id = '" +
                    idTweet + "'");
            }
            catch(Exception e)
            {
                Console.WriteLine("No se ha podido eliminar el tweet " + e);
                return 0;
            }
            return 1;
        }

        public int modificarTweetProgramado(int idTweet, string titulo,
            string fecha)
        {
            try
            {
                Console.WriteLine();
                baseDatos.Execute("Update TweetProgramado set titulo = '" +
                    titulo + "', " + "fechaProgramacion = '" + fecha +
                    "' where id = '" + idTweet + "'");
            }
            catch(Exception e)
            {
                Console.WriteLine("No se ha podido modificar el tweet " + e);
                return 0;
            }
            return 1;
        }

        public int anyadirTweet(MiTweet miTweet)
        {
            try
            {
                baseDatos.Insert(miTweet);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error al añadir tweet: " + e);
                return 0;
            }
            return 1;
        }

        public int anyadirTweetProgramado(TweetProgramado twProg)
        {
            try
            {
                baseDatos.Insert(twProg);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al programar tweet: " + e);
                return 0;
            }
            return 1;
        }

        public List<Mencion> recibirMenciones(UserApp usuario)
        {
            List<Mencion> aux = new List<Mencion>();
            aux = baseDatos.Query<Mencion>("select * from Mencion where idUsuario = " + usuario.idUsuario);
            return aux;
        }


        public int eliminarMenciones(UserApp usuario)
        {
            try
            {
                baseDatos.Execute("DELETE FROM Mencion where idUsuario = " + "'" + usuario.idUsuario + "'");
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        public int publicarPromociones(Promocion promo)
        {
            try
            {
                baseDatos.Insert(promo);
                return 1;
            }
            catch(Exception e)
            {
                return 0;
            }
        }

        public List<Promocion> cargarPromociones()
        {
            List<Promocion> promos = new List<Promocion>();

            try
            {
                TableQuery<Promocion> listaPromos = baseDatos.Table<Promocion>();

                for (int i = 0; i < listaPromos.Count(); i++)
                {
                    promos.Add(listaPromos.ElementAt(i));
                }
            }
            catch(Exception e)
            {

            }
            return promos;
        }
    }
}
