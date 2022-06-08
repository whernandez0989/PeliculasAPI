using PeliculasAPI.Entidades;

namespace PeliculasAPI.Repositorios
{
    public class RepositorioEnMemoria
    {

        private List<Genero> _generos;

        public RepositorioEnMemoria()
        {
            _generos = new List<Genero>()
            {
                new Genero() {Id = 1, Nombre = "Comedia"},
                new Genero() {Id=2, Nombre ="Drama"}
            };
        }

    }
}
