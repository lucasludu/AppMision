namespace AppMision.Models
{
    public class MisionCasiImposible : Mision
    {
        private List<string> accionesRequeridas;

        public MisionCasiImposible(string nombre, string dificultad, int puntosEXdeRecompensa, int minimoPuntosEXRequeridos)
            : base(nombre, dificultad, puntosEXdeRecompensa, minimoPuntosEXRequeridos)
        {
            accionesRequeridas = new List<string>();
        }

        /// <summary>
        /// Método para agregar una acción requeida
        /// </summary>
        /// <param name="accion">Acción</param>
        /// <returns></returns>
        public bool AddAccionRequerida(string accion)
        {
            if (!accionesRequeridas.Contains(accion))
            {
                accionesRequeridas.Add(accion);
                return true;
            }
            return false; 
        }

        /// <summary>
        /// Método para verificar si un jugador supera la MisionCasiImposible.
        /// </summary>
        /// <param name="jugador">Jugador</param>
        /// <returns>True/False</returns>
        public override bool SuperaMision(Jugador jugador)
        {

            // Verifico si tiene los puntos de experiencia minimos.
            if(!base.SuperaMision(jugador))
            {
                return false;
            }

            // Verifico si realizo todas las acciones requeridas.
            int accionesNoRealizadas = 0;
            foreach(var accion in accionesRequeridas)
            {
                if(!jugador.RealizoAccion(accion))
                {
                    accionesNoRealizadas++;
                }
            }

            // Supera la misión si el número de acciones noi realizadas es menor a las misiones superadas.
            return accionesNoRealizadas < jugador.MisionesSuperadas.Count;
        }

    }
}
