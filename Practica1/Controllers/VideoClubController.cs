using Microsoft.AspNetCore.Mvc;
using Practica1.Domain;
using Practica1.Domain.Interfaces;
using System.Text.Json.Nodes;

namespace Practica1.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class VideoClubController : ControllerBase
    {
        private IVideoClubOperaciones _videoClubOperaciones;
        public VideoClubController(IVideoClubOperaciones videoClubOperaciones) { 
            // alquilar, vender, devolver
            //pelicula nombre, director ,actoreslista ,precio
            _videoClubOperaciones = videoClubOperaciones;   
        
        }
        [HttpGet(Name = "Alquilar")]
        public Pelicula Alquilar(string nombre, string director) { 

            return _videoClubOperaciones.Alquilar(nombre,director);

        
        }
        [HttpPost]
        public Pelicula Devolucion([FromBody] JsonObject datosJson)
        {
            //var respuesta = _videoClubOperaciones.Devolucion(movie);
            //return movie;
            string nombrePelicula = datosJson["nombre"]?.ToString();
            string nombreDirector = datosJson["director"]?.ToString();
            string precioSinFormato = datosJson["precio"].ToString();
            float precioPelicula = float.Parse(precioSinFormato);

            var peliculaformada = new Pelicula();
            peliculaformada.Nombre = nombrePelicula;
            peliculaformada.Director = nombreDirector;
            peliculaformada.precio = precioPelicula;



            return peliculaformada;

        }


        [HttpGet(Name = "Vender")]
        public Pelicula Vender(string nombre)
        {

            return _videoClubOperaciones.Vender(nombre);


        }

        [HttpGet(Name = "listaPelicula")]
        public List<Pelicula> ListaPelicula() {

            return _videoClubOperaciones.ListaPelicula(); 
        
        }





    }
}
