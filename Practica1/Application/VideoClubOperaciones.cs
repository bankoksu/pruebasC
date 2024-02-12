using Microsoft.AspNetCore.Mvc;
using Practica1.Domain;
using Practica1.Domain.Interfaces;
using System.Text.Json.Nodes;

namespace Practica1.Application
{
    public class VideoClubOperaciones : IVideoClubOperaciones
    {
        private List<Pelicula> _listaPeliculas;
        public VideoClubOperaciones() { 
        
            _listaPeliculas = new List<Pelicula>();
            _listaPeliculas.Add(new Pelicula() {Nombre = "Titanic",Director= "pepito",ListaDeActores= new List<Actor>() { new Actor() { Nombre="Leonardo",Apellido= "Dicaprio", Edad=25} },precio=10 });
            Actor actor = new Actor();
            actor.Nombre = "juan";
            actor.Apellido = "sitjar";
            actor.Edad = 12;
            Actor actorSecundario = new Actor();
            actorSecundario.Nombre = "Carlos";
            actorSecundario.Apellido = "minda";
            actorSecundario.Edad = 13;
            List<Actor> listaActorDos = new List<Actor>() ;
            listaActorDos.Add(actor);
            listaActorDos.Add(actorSecundario);
            var pelicula = new Pelicula();
            pelicula.Nombre = "starwars";
            pelicula.Director = "Solidus";
            pelicula.ListaDeActores = listaActorDos;
            pelicula.precio = 12.99f;
            _listaPeliculas.Add(pelicula);


        }
        public Pelicula Alquilar(string nombrePelicula,string director)
        {
            // || or condic
            var peliculaEncontrada = _listaPeliculas.FirstOrDefault(p=>p.Nombre == nombrePelicula||p.Director==director );

            return peliculaEncontrada;
        }
        //revisar si se devuelve la peli
        public bool Devolucion1(JsonObject pelicula)
        {
            // revisar la longitud de la lista pelicula y luego comprobar si se sumo uno
            // agregar un item
            //var peliculaEncontrada;




            return true;
        }
        public bool Devolucion(Pelicula pelicula) {


            return true;        
        }

        public Pelicula Vender(string nombrePelicula)
        {
            var peliculaEncontrada = _listaPeliculas.FirstOrDefault(p =>p.Nombre == nombrePelicula);

            return peliculaEncontrada;
        }

        public List<Pelicula> ListaPelicula() {

            return _listaPeliculas;
        
        }
    }
}
