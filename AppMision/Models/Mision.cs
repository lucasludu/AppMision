namespace AppMision.Models
{
    public class Mision
    {
        public string Nombre { get; set; }
        public string Dificultad { get; set; }
        public int PuntosExdeRecompensa { get; set; }
        public int MinimoPuntosExRequeridos { get; set; }

        public Mision()
        {
            
        }

        public Mision(string nombre, string dificultad, int puntosExdeRecompensa, int minimoPuntosExRequeridos)
        {
            this.Nombre = nombre;
            this.Dificultad = dificultad;
            this.PuntosExdeRecompensa = puntosExdeRecompensa;
            this.MinimoPuntosExRequeridos = minimoPuntosExRequeridos;
        }

        /// <summary>
        /// Verifica si el jugador supera la misión en base a los puntos de experiencia.
        /// </summary>
        /// <param name="jugador">Jugador</param>
        /// <returns>True/False</returns>
        public virtual bool SuperaMision(Jugador jugador)
        {
            return jugador.PuntosExperienciaAcomulados >= MinimoPuntosExRequeridos;
        }

    }
}
