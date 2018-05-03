using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace capa_entidades
{
    public class Tablas
    {
    }

    public class MiTweet : IComparable
    {
        [PrimaryKey]
        public long id { get; set; }
        public string text { get; set; }
        public string time { get; set; }
        public int retweets { get; set; }
        public int favourites { get; set; }
        public int quote { get; set; }
        public string user { get; set; }

        public MiTweet() { }

        public MiTweet(long id, string text, string time, int retweets,
            int favourites, int quotes, string user)
        {
            this.id = id;
            this.text = text;
            this.time = time;
            this.retweets = retweets;
            this.favourites = favourites;
            this.quote = quote;
            this.user = user;
        }

        public int CompareTo(object obj)
        {
            MiTweet miTweet = (MiTweet)obj;
            int respuesta = this.id.CompareTo(miTweet.id);
            if (respuesta == 0)
            {
                return 0;
            }
            else
            {
                return respuesta;
            }
        }
    }

    public class TweetProgramado
    {
        [PrimaryKey]
        public int id { get; set; }
        public string usuario { get; set; }
        public string titulo { get; set; }
        public int programado { get; set; }
        public string fechaProgramacion { get; set; }
        public string imagen { get; set; }

        public TweetProgramado() { }

        public TweetProgramado(int id, string usuario, string titulo, 
            int programado, string fechaProgramacion, string imagen)
        {
            this.id = id;
            this.usuario = usuario;
            this.titulo = titulo;
            this.programado = programado;
            this.fechaProgramacion = fechaProgramacion;
            this.imagen = imagen;
        }

        public int CompareTo(object obj)
        {
            TweetProgramado twProg = (TweetProgramado)obj;
            int respuesta = this.titulo.CompareTo(twProg.titulo);

            if (respuesta == 0)
            {
                return 0;
            }
            else
            {
                return respuesta;
            }
        }
    }

    public class UserApp
    {
        [PrimaryKey] [AutoIncrement]
        public int idUsuario { get; set; }
        public string usuario { get; set; }
        public string contrasenia { get; set; }
        public string email { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int twitter_ID { get; set; }
        public string consumerKey { get; set; }
        public string consumerSecret { get; set; }
        public string accessToken { get; set; }
        public string accessTokenSecret { get; set; }

        public UserApp()
        {

        }

        public UserApp(string usuario, string contrasenia, string email,
           string nombre, string apellidos, int twitter_ID, string consumerKey,
           string consumerSecret, string accessToken, string accessTokenSecret)
        {
            this.usuario = usuario;
            this.contrasenia = contrasenia;
            this.email = email;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.twitter_ID = twitter_ID;
            this.consumerKey = consumerKey;
            this.consumerSecret = consumerSecret;
            this.accessToken = accessToken;
            this.accessTokenSecret = accessTokenSecret;
        }

        public int CompareTo(object obj)
        {
            UserApp userApp = (UserApp)obj;
            int respuesta = this.idUsuario.CompareTo(userApp.idUsuario);

            if (respuesta == 0)
            {
                return 0;
            }
            else
            {
                return respuesta;
            }
        }
    }

    public class Promocion
    {
        [PrimaryKey] [AutoIncrement]
        public int idPromocion { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fechaDesde { get; set; }
        public DateTime fechaHasta { get; set; }
        public string idUsulFollow { get; set; }
        public long idTweetRetweet { get; set; }
        public bool finalizada { get; set; }
        public byte[] imagen { get; set; }

        public Promocion() { }

        public Promocion(int idPromocion, string nombre, string descripcion,
            DateTime fechaDesde, DateTime fechaHasta, string idUsulFollow, 
            long idTweetRetweet, bool finalizada)
        {
            this.idPromocion = idPromocion;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.fechaDesde = fechaDesde;
            this.fechaHasta = fechaHasta;
            this.idUsulFollow = idUsulFollow;
            this.idTweetRetweet = idTweetRetweet;
            this.finalizada = finalizada;
        }
        public Promocion(string nombre, DateTime fIni, DateTime fFin, byte[] imagen)
        {
            this.nombre = nombre;
            fechaDesde = fIni;
            fechaHasta = fFin;
            this.imagen = imagen;
        }

        public int CompareTo(object obj)
        {
            Promocion promo = (Promocion)obj;
            int respuesta = this.idPromocion.CompareTo(promo.idPromocion);

            if (respuesta == 0)
            {
                return 0;
            }
            else
            {
                return respuesta;
            }
        }
    }

    public class TweetPromocion
    {
        public long idTweet { get; set; }
        public string idPromocion { get; set; }

        public TweetPromocion() { }

        public TweetPromocion(long idTweet, string idPromocion)
        {
            this.idTweet = idTweet;
            this.idPromocion = idPromocion;
        }
       
    }

    public class Mencion
    {
        public long idMencion { get; set; }
        public string texto { get; set; }
        public string foto { get;  set;}

        public Mencion() { }

        public Mencion(long idMencion, string texto)
        {
            this.idMencion = idMencion;
            this.texto = texto;
        }

        public Mencion(long idMencion, string texto, string foto)
        {
            this.idMencion = idMencion;
            this.texto = texto;
        }

    }

    public class TweetMencion
    {
        public long idTweet { get; set; }
        public long idMencion { get; set; }

        public TweetMencion() { }

        public TweetMencion(long idTweet, long idMencion)
        {
            this.idTweet = idTweet;
            this.idMencion = idMencion;
        }
    }
}
