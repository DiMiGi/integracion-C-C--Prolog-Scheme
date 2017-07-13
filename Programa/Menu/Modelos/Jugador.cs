using System;

namespace Menu.Modelos
{
    public class Jugador
    {
        private String nombreUsuario;

        public String NombreUsuario
        {
            get { return nombreUsuario; }
            set { nombreUsuario = value; }
        }

        private String nombreJugador;

        public String NombreJugador
        {
            get { return nombreJugador; }
            set { nombreJugador = value; }
        }
        
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private System.Collections.Generic.List<System.Windows.Forms.KeyEventArgs> movimientosEvents;

        public System.Collections.Generic.List<System.Windows.Forms.KeyEventArgs> MovimientosEvents
        {
            get { return movimientosEvents; }
            set { movimientosEvents = value; }
        }

        private System.Collections.Generic.List<System.Drawing.Point> movimientos;

        public System.Collections.Generic.List<System.Drawing.Point> Movimientos
        {
            get { return movimientos; }
            set { movimientos = value; }
        }

        private int vida;

        public int Vida
        {
            get { return vida; }
            set { vida = value; }
        }

        private int puntaje;

        public int Puntaje
        {
            get { return puntaje; }
            set { puntaje = value; }
        }
        
        private System.Collections.Generic.List<Trofeo> trofeos;

        public System.Collections.Generic.List<Trofeo> Trofeos
        {
            get { return trofeos; }
            set { trofeos = value; }
        }
        
        private System.Collections.Generic.List<int> mejoresPuntuaciones;

        public System.Collections.Generic.List<int> MejoresPuntuaciones
        {
            get { return mejoresPuntuaciones; }
            set { mejoresPuntuaciones = value; }
        }
        
        private System.Collections.Generic.List<int> idAmigos;

        public System.Collections.Generic.List<int> IdAmigos
        {
            get { return idAmigos; }
            set { idAmigos = value; }
        }

        private System.Windows.Forms.Panel representacion;

        public System.Windows.Forms.Panel Representacion
        {
            get { return representacion; }
            set { representacion = value; }
        }


        public Jugador()
        {
            this.Vida = 100;
            this.Id = 0;
        }

        public Jugador(System.Windows.Forms.Panel representacion)
        {
            //carga un nombre nuevo (nuevo jugador) desde 0 no sera guardado.
            Representacion = representacion;
        }

        public Jugador(String alias,System.Windows.Forms.Panel representacion)
        {
           //cargar datos del jugador con alias
        }

        public Jugador(int id, string nombreUsuario, string nombreJugador, int vida, int puntaje)
        {
            // TODO: Complete member initialization
            this.id = id;
            this.nombreUsuario = nombreUsuario;
            this.nombreJugador = nombreJugador;
            this.vida = vida;
            this.puntaje = puntaje;
        }

        public Resources.dll.SaveGame toSaveGame()
        {
            Resources.dll.SaveGame save = new Resources.dll.SaveGame();
            save.Jugador = this;
            save.MapaID = 0; // no implementado
            save.NombreSave = NombreUsuario;
            return save;
        }
        
    }
}