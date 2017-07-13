using IronScheme;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryScheme
{
    public class IronSchemeMain
    {
        /* ATRIBUTOS */
        private Laberinto laberinto;

        public Laberinto Laberinto
        {
            get { return laberinto; }
            set { laberinto = value; }
        }

        /* METODO QUE CREA UN LABERINTO LOS TROFEOS SON CREADOS INTERNAMENTE POR IRON SCHEME
         * DADA UNA PROBABILIDAD, LOS NODOS SE REPITEN
         * INSTANCIA EL ATRIBUTO LABERINTO DE LA CLASE
         */
        public bool CrearLaberinto(int dimX,int dimY)
        {
            IronScheme.Runtime.Cons res;
            String expr = "(import (SchemeLibraries laberinto))";
            try
            {
                expr.Eval();
                expr = "(createMaze " + dimX + " " + dimY + ")";
                res = (IronScheme.Runtime.Cons)expr.Eval();
                Laberinto = new Laberinto(res);
                return true;
            }catch{
                return false;
            }
        }
    }
}
