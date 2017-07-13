using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Modelos
{
    class Enemigo : Jugador
    {
        private Jugador[] jugadores;

        public Jugador[] Jugadores
        {
            get { return jugadores; }
            set { jugadores = value; }
        }

    }
}
