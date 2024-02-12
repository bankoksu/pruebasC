using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;

namespace Practica1.Domain
{
    public class Pelicula
    {
        //pelicula nombre, director ,actoreslista ,precio

        public string Nombre { get; set; }
        public string Director { get; set; }
        public float precio { get; set; }
        public List<Actor> ListaDeActores { get; set; }
        
        
        

    }
}
