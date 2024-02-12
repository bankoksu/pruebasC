namespace Practica1.Application
{
    public class PruebaDeClase
    {
        public interface IPersona {

            void ModificarNombre(string nombre);
        
        }

        public class Persona: IPersona
        {
            public string Name { get; set; }
            public string Surname { get; set; }
            public int age { get; set; }

            public void ModificarNombre(string nombre) { 
            
            
                Name = nombre;
            
            }


        }

        public class Actor : Persona {

           

        
        }

        public class Director : Persona
        {
            




        }






        public class Pelicula 
        {
            private string _MovieName;
            private Director _DirectorName;
            private List<Actor> _ActorName;
            public Pelicula _Pelicula;


            public Pelicula(string movieName, Director directorName, List<Actor> actorName)
            {

                _MovieName = movieName;
                _DirectorName = directorName;
                _ActorName = actorName;
            }

            public Pelicula DevolverInfo(string nombre) {

                return _Pelicula;
            }



        }




    }
}
