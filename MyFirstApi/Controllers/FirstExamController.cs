using MyFirstApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyFirstApi.Controllers
{
    public class FirstExamController : ApiController
    {

        //Instancias de la coneccion al EF y realizar las consutas y todo hacia la base de datos
        private readonly BZafEntities db = new BZafEntities();
        private readonly MyFirstDbEntities db1 = new MyFirstDbEntities();

        //Aqui creamos metodo de tipo list para traer a todos los usuarios
        public List<tbm_Usr> Get()
        {
            var usu = db.tbm_Usr.ToList();

            return usu;
        }

        //En este metodo tremos el usuario segun el filtro y solo traemos el nombre con Linq
        //public string Get(int Id)
        //{

        //    var usuarios = db.tbm_Usr.Where(w => w.co_usr == Id).Select(s => s.tx_nom).FirstOrDefault();

        //    return usuarios;
        //}
        //Aqui creamos un metodo get que recibe id y retorna codigo, nombre,apellido,correo de usuario
        public UsuarioModel Get(int Id)
        {
            /*  Aqui creamos la variable dnd vamos almacenar
             *  el resultado del query realizado por medio de Linq
             *  y lambda expression para acceder a los atributos del objeto
             */
            var usuarios = db.tbm_Usr.Where(w => w.co_usr == Id).Select(s => new{s.co_usr,s.tx_nom,s.tx_ape,s.tx_corr }).FirstOrDefault();
            //La varieble res contiene el resultado serializado es decir en formato json pero de tipo string
            string res = JsonConvert.SerializeObject(usuarios);
            //La variable rr contiene el formato json de tipo string y lo deserializa para trasformarlo de tipo UsuarioModel
            var rr = JsonConvert.DeserializeObject<UsuarioModel>(res);
            return rr;
        }

        ////Metodo get que filtra con un parametroy devuelve un usuario
        //public tbm_Usr Get(int Id)
        //{
        ////    Aqui guardamos el resultado del firtro simple
        //    var usuarios = db.tbm_Usr.Where(w => w.co_usr==Id).FirstOrDefault();

        //    return usuarios;
        //}

        //public tbm_usu Get(int id)
        //{
        //    var Busqueda = db1.tbm_usu.Where(w => w.co_usr == id).FirstOrDefault();

        //    return Busqueda;
        //}

        //Metodo get Creamos una lista con el modelo creado usuario y agregamos los valos y devolvemos la misma lista
        //public List<UsuarioModel> Get()
        //{
        //    List<UsuarioModel> Usuario = new List<UsuarioModel>();
        ////Se crea el objeto y se asigna valores a sus propiedades
        //    Usuario.Add(new UsuarioModel()
        //    {
        //        co_usr=1,
        //        tx_nom="Boris",
        //        tx_ape="Parrales",
        //        tx_ema="boris_parales@hotmail.com"
        //    });

        //    Usuario.Add(new UsuarioModel()
        //    {
        //        co_usr = 2,
        //        tx_nom = "Jose",
        //        tx_ape = "Parrales",
        //        tx_ema = "jose_parales@hotmail.com"
        //    });

        //    Usuario.Add(new UsuarioModel()
        //    {
        //        co_usr = 3,
        //        tx_nom = "Leomaris",
        //        tx_ape = "Reyes",
        //        tx_ema = "leoReyes@hotmail.com"
        //    });

        //    Usuario.Add(new UsuarioModel()
        //    {
        //        co_usr = 4,
        //        tx_nom = "Paola",
        //        tx_ape = "Diaz",
        //        tx_ema = "pdiaz@hotmail.com"
        //    });



        //    return Usuario;
        //}



        //Aqui creamos un metodo Get que recibe el Id del usuario y lo retorna incluimos una coleccion dentro del metodo
        //public UsuarioModel Get(int Id)
        //{
        //    List<UsuarioModel> Usuario = new List<UsuarioModel>();

        //    Usuario.Add(new UsuarioModel()
        //    {
        //        co_usr = 1,
        //        tx_nom = "Boris",
        //        tx_ape = "Parrales",
        //        tx_ema = "boris_parales@hotmail.com"
        //    });

        //    Usuario.Add(new UsuarioModel()
        //    {
        //        co_usr = 2,
        //        tx_nom = "Jose",
        //        tx_ape = "Parrales",
        //        tx_ema = "jose_parales@hotmail.com"
        //    });

        //    Usuario.Add(new UsuarioModel()
        //    {
        //        co_usr = 3,
        //        tx_nom = "Leomaris",
        //        tx_ape = "Reyes",
        //        tx_ema = "leoReyes@hotmail.com"
        //    });

        //    Usuario.Add(new UsuarioModel()
        //    {
        //        co_usr = 4,
        //        tx_nom = "Paola",
        //        tx_ape = "Diaz",
        //        tx_ema = "pdiaz@hotmail.com"
        //    });

        //    UsuarioModel usuarioBusqueda = Usuario.Where(usu => usu.co_usr == Id).FirstOrDefault();


        //    return usuarioBusqueda;
        //}

        //Metodo get donde obtenemos una lista con un arreglo de string
        //public IEnumerable<string> Get()
        //{
        //    string[] Datos = new string[]
        //    {
        //        "uno",
        //        "dos",
        //        "tres"
        //    };
        //    Datos.Append("cuatro");

        //    return Datos;
        //}


        //Metodo get donde obtenemos un usuario por ID
        //public string Get(int ID)
        //{
        //    if (ID == 1)
        //    {
        //        return "Bienvenido Boris";
        //    }
        //    else
        //    {
        //        return "Acceso Denegado";
        //    }

        //}


    }
}
