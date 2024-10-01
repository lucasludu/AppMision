namespace AppMision.Models
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public Aventura Aventura { get; set; }
        public List<string> MisionesSuperadas;
        public int PuntosExperienciaAcomulados { get; set; }
        public List<string> AccionesRealizadas; 

        // Constructor
        public Jugador()
        {
            this.MisionesSuperadas = new List<string>();
            this.AccionesRealizadas = new List<string>();
        }

        public Jugador(string nombre, int puntosExperienciaAcomulados)
        {
            this.Nombre = nombre;
            this.PuntosExperienciaAcomulados = puntosExperienciaAcomulados;
            this.MisionesSuperadas = new List<string>();
            this.AccionesRealizadas = new List<string>();
        }

        /// <summary>
        /// Método para verificar si una accion fue realizada.
        /// </summary>
        /// <param name="accion">Accíón</param>
        /// <returns>True/False</returns>
        public bool AddAccion(string accion)
        {
            if(!this.RealizoAccion(accion))
            {
                AccionesRealizadas.Add(accion);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Método para verificar si una acción fue realizada.
        /// </summary>
        /// <param name="accion">Acción</param>
        /// <returns>True/False</returns>
        public bool RealizoAccion(string accion)
        {
            return AccionesRealizadas.Contains(accion);
        }

        /// <summary>
        /// Método para agregar una mision superada.
        /// </summary>
        /// <param name="mision">Misión</param>
        public bool AddMisionSuperada(string mision)
        {
            if(!MisionesSuperadas.Contains(mision))
            {
                MisionesSuperadas.Add(mision);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Incremento la experiencia del jugador
        /// </summary>
        /// <param name="puntos">Puntos a acomular.</param>
        public void IncrementarExperiencia(int puntos)
        {
            this.PuntosExperienciaAcomulados += puntos;
        }

    }
}
