using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HolaMundo.Services
{
    public class PeliculasService
    {
        public Peliculas ObtenerPelicula()
        {
            return new Peliculas()
            {
                Titulo = "Escape Plan",
                Duracion = 115,
                Pais = "USA",
                Publicacion = new DateTime(2013, 12, 5)
            };
        }

        public List<Peliculas> ObtenerPeliculas()
        {
            var pelicula1 = new Peliculas()
            {
                Titulo = "Escape Plan",
                Duracion = 223,
                Pais = "USA",
                Publicacion = new DateTime(2013, 04, 23)
            };

            var pelicua2 = new Peliculas()
            {
                Titulo = "Capitan America: Civil War",
                Duracion = 344,
                Pais = "USA",
                Publicacion = new DateTime(2030, 03, 03)
            };

            return new List<Peliculas> { pelicula1, pelicua2 };
        }
    }
}
