using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibraryScheme
{
    public class Vector3
    {
        /* ATRIBUTOS */
        private int xCoord;

        public int x
        {
            get { return xCoord; }
            set { xCoord = value; }
        }
        private int yCoord;

        public int y
        {
            get { return yCoord; }
            set { yCoord = value; }
        }
        private int trofeo;

        public int t
        {
            get { return trofeo; }
            set { trofeo = value; }
        }
        /* FIN ATRIBUTOS */

        /* CONSTRUCTORES */
        public Vector3()
        {
            this.x = -1;
            this.y = -1;
            this.t = -1;
        }

        public Vector3(IronScheme.Runtime.Cons punto3)
        {
            IronScheme.Runtime.Cons aux = (IronScheme.Runtime.Cons)punto3.cdr;
            this.x = (int)punto3.car;
            this.y = (int)aux.car;
            aux = (IronScheme.Runtime.Cons)aux.cdr;
            this.t = (int)aux.car;
        }

        public Vector3(int x,int y,int t)
        {
            this.x = x;
            this.y = y;
            this.t = t;
        }

        /*FIN CONSTRUCTORES*/

        public bool Equals(Vector3 objeto){
            if (this.x == objeto.x && this.y == objeto.y && this.t == objeto.t)
                return true;
            else
                return false;
        }

        public bool Equals_Coord(Vector3 objeto)
        {
            if (this.x == objeto.x && this.y == objeto.y)
                return true;
            else
                return false;
        }
        public override string ToString()
        {
            return (this.x + " " + this.y + " " + this.t);
        }

    }
}
