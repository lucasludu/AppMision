namespace AppMision.Models
{
    public class Aventura
    {
        public string Nombre { get; set; }
        private List<Mision> Misiones = new List<Mision>();
        private List<Jugador> Jugadores = new List<Jugador>();


        // Constructor
        public Aventura(string nombre)
        {
            this.Nombre = nombre;
        }

        /// <summary>
        /// Método para agregar un jugador a la aventura.
        /// </summary>
        /// <param name="jugador">Jugador</param>
        /// <returns>True/False</returns>
        public bool AgregarJugador(Jugador jugador)
        {
            // Verifico que el jugador fue agregado
            if (this.Jugadores.Contains(jugador))
            {
                return false; // ya se encuentra en la aventura
            }

            this.Jugadores.Add(jugador);

            // Recorro la lista de misiones de la aventura
            foreach(var mision in this.Misiones)
            {
                // Verifico que haya superado la misión
                if(mision.SuperaMision(jugador)) 
                {
                    // Agrego la misión superada al jugador
                    if(jugador.AddMisionSuperada(mision.Nombre))
                    {
                        // Incremento puntos de experiencia del jugador.
                        jugador.IncrementarExperiencia(mision.PuntosExdeRecompensa);
                    }
                }
            }
            return true;
        }


        /// <summary>
        /// Método para agregar misiones a la aventura. (El método puede ser opcional)
        /// </summary>
        /// <param name="mision">Misión</param>
        public void AgregarMision(Mision mision)
        {
            this.Misiones.Add(mision); 
        }



        public List<string> MetodoSinNombre()
        {
            List<string> variableSinNombre = new List<string>();
            foreach (var m in this.Misiones)
            {
                var sinNombre = false;
                foreach (var j in this.Jugadores)
                {
                    if(m.SuperaMision(j))
                    {
                        sinNombre = true;

                        if (!sinNombre)
                        {
                            variableSinNombre.Add(m.Nombre);
                        }
                    } 
                }
            }
            return variableSinNombre;
        }

    }
}
