using Microsoft.AspNetCore.Mvc;
using System.Text.Json.Nodes;

namespace Practica1.Domain.Interfaces
{
    public interface IVideoClubOperaciones
    {
        Pelicula Alquilar(string nombrePelicula, string director);

        Pelicula Vender(string nombrePelicula);

        bool Devolucion(JsonObject pelicula);

        List<Pelicula> ListaPelicula();
    }
}
