using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capa_datos;
using Tweetinvi;
using capa_entidades;
using System.IO;
using Tweetinvi.Parameters;

namespace capa_negocio
{
    public class Negocio
    {
        // atributos
        private BD bd;        
        private List<UserApp> usuarios;
        private List<TweetProgramado> tweetsProgs;
        private string consumer_key;// = "MUVxm4j9XAdfYKObSFZDRdtW1";
        private string consumer_secret;// =
                                       //"LfCD5r2j5yqXxgEl3oSeQrMzMgVeFZzrL90k7jCaAH2ttFmJv1";
        private string acces_token;//=
                                   //"195856574-MqaLD7G9wnIEWrqVOqGBptX8vRWp6pKEzoUBTHTs";
        private string acces_token_secret; //=
            //"XljsdVJHJtqItKHyvMChqd5pT2bVFJn92Nvyk33uap6nV";
        
        public Negocio()
        {
            bd = new BD();
            
            usuarios = bd.cargarUsuarios();
            tweetsProgs = bd.cargarTweetProgramado();
            consumer_key = usuarios[0].consumerKey.Trim();
            consumer_secret = usuarios[0].consumerSecret.Trim();
            acces_token = usuarios[0].accessToken.Trim();
            acces_token_secret = usuarios[0].accessTokenSecret.Trim();
        }

        //Añadir tweet programado a la BD
        public int guardarTweetBD(int id, string usuario, int programado, 
            string fechaProgramacion, string imagen, string titulo)
        {
            TweetProgramado tweetProg = new TweetProgramado(id, usuario, titulo,
                programado, fechaProgramacion, imagen);

            int guardado = bd.anyadirTweetProgramado(tweetProg);
            tweetsProgs = bd.cargarTweetProgramado();

            return guardado;
        }

        //Cargar usuarios
        public List<UserApp> cargarUsuarios()
        {
            usuarios = bd.cargarUsuarios();
            return usuarios;            
        }
        
        //Cargar tweets programados
        public List<TweetProgramado> cargarTweetsProgramados()
        {
            return tweetsProgs;            
        }

        public string cargarImagen()
        {
            Auth.SetUserCredentials(consumer_key, consumer_secret, acces_token, acces_token_secret);
            var user = User.GetAuthenticatedUser();
            var imgUsuario = user.ProfileImageUrlFullSize;
            return imgUsuario;
        }

        //Mandar tweet
        public void mandarTweet(string texto)
        {
            Auth.SetUserCredentials(consumer_key, consumer_secret, acces_token, acces_token_secret);
            var user = User.GetAuthenticatedUser();            
            var tweet = Tweet.PublishTweet(texto);
        }

        //Eliminar tweet programado
        public int eliminarTweetProgramado(int idTweet)
        {
            int respuesta = bd.eliminarTweetProgramado(idTweet);

            if (respuesta != 0)
            {
                tweetsProgs = bd.cargarTweetProgramado();
            }

            return respuesta;
        }

        //Modificar tweet programado
        public int modificarTweetProgramado(int idTweet, string titulo,
            string fecha)
        {
            int respuesta = bd.modificarTweetProgramado(idTweet, titulo, fecha);

            if (respuesta != 0)
            {
                tweetsProgs = bd.cargarTweetProgramado();
            }
            return respuesta;
        }

        public void cargarFichero()
        {
            string usuario;
            string contrasenia;
            string email;
            string nombre;
            string apellidos;
            int twitter_ID;
            string consumerKey;
            string consumerSecret;
            string accessToken;
            string accessTokenSecret;

            int respuesta;

            if (!File.Exists("usuarios.txt"))
            {
                Console.WriteLine("No existe el fichero");
            }

            else
            {
                try
                {
                    StreamReader fichero = File.OpenText("usuarios.txt");
                    string linea;
                    do
                    {
                        linea = fichero.ReadLine();
                        if (linea != null)
                        {
                            string[] datos = linea.Split(';');
                            usuario = datos[0];
                            contrasenia = datos[1];
                            email = datos[2];
                            nombre = datos[3];
                            apellidos = datos[4];
                            twitter_ID = Convert.ToInt32(datos[5]);
                            consumerKey = datos[6];
                            consumerSecret = datos[7];
                            accessToken = datos[8];
                            accessTokenSecret = datos[9];
                              
                            respuesta = bd.anyadirUsuario(new UserApp(usuario, contrasenia, 
                            email, nombre, apellidos, twitter_ID, consumerKey, 
                            consumerSecret, accessToken, accessTokenSecret));

                            if (respuesta == 1)
                                usuarios = bd.cargarUsuarios();
                        }
                    } while (linea != null);

                    fichero.Close();
                }
                catch (PathTooLongException)
                {
                    Console.WriteLine("Ruta demasiado larga");
                }
                catch (IOException ex)
                {
                    Console.WriteLine("Error entrada/salida: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public List<UsuariosFollowers> obtenerFollowers()
        {
            List<UsuariosFollowers> listaFollowers = new List<UsuariosFollowers>();

            Auth.SetUserCredentials(consumer_key, consumer_secret,
                acces_token, acces_token_secret);
            var user = User.GetAuthenticatedUser();

            var lista = User.GetFollowers(user);

            foreach (var datos in lista)
            {
                string nombre = datos.Name;
                string imagen = datos.ProfileImageUrlFullSize;
                int followers = datos.FollowersCount;

                listaFollowers.Add(new UsuariosFollowers(imagen, nombre, followers));
            }
            return listaFollowers;
        }

        public List<TLineTweets> cargarTimeLine()
        {
            List<TLineTweets> lista = new List<TLineTweets>();

            Auth.SetUserCredentials(consumer_key, consumer_secret,
                acces_token, acces_token_secret);
            var user = User.GetAuthenticatedUser();

            var listaTL = Timeline.GetUserTimeline(user, 40);

            foreach (var tLine in listaTL)
            {
                string texto = tLine.Text;
                DateTime fecha = tLine.CreatedAt;
                string imagen = user.ProfileImageUrl;

                lista.Add(new TLineTweets(texto, imagen, fecha));
            }
            return lista;
        }

        public List<Mencion> obtenerMenciones()
        {
            List<Mencion> menciones = new List<Mencion>();

            Auth.SetUserCredentials(consumer_key, consumer_secret,
                acces_token, acces_token_secret);
            var user = User.GetAuthenticatedUser();
            var mentionsTimelineParameters = new MentionsTimelineParameters();
            var tweets = Timeline.GetMentionsTimeline(mentionsTimelineParameters);

            foreach (var mencion in tweets)
            {
                long id = mencion.Id;
                string texto = mencion.Text;

                menciones.Add(new Mencion(id, texto));
            }
            return menciones;

        }

    }
}
