using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu.Modelos
{
    public class Resolucion : IEquatable<Resolucion>
    {
        private Size res;

        public Size resolucion
        {
            get { return res; }
            set { res = value; }
        }

        /* representa los bits de color por pixel, por ejemplo 4 bits para 16 colors,
        8 bits para 256 colors o 16 bits para 65,536 colors*/
        private int colorResolucion;

        public int ColorResolucion
        {
            get { return colorResolucion; }
            set { colorResolucion = value; }
        }

        private int frecuencia;

        public int Frecuencia
        {
            get { return frecuencia; }
            set { frecuencia = value; }
        }

        public Resolucion()
        {
            resolucion = new Size(800, 600);
            ColorResolucion = 32;
            Frecuencia = 32;
        }
        
        public Resolucion(int ancho,int alto,int bitsColor,int frecuencia)
        {
            resolucion = new Size(ancho, alto);
            ColorResolucion = bitsColor;
            Frecuencia = frecuencia;
        }

        public bool Equals(Resolucion res)
        {
            if (res == null) return false;
            else
            {
                if (this.ColorResolucion == res.ColorResolucion &&
                    this.Frecuencia == res.Frecuencia &&
                    this.resolucion.Equals(res.resolucion))
                    return true;
                else
                    return false;
            }
        }

        public override string ToString()
        {
            return this.resolucion.Width + " x " + this.resolucion.Height + " x " + this.Frecuencia + " Hz x " + this.ColorResolucion + " Colores";
        }

    }
}
