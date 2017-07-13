using System;
using System.Collections.Generic;
using System.Text;
using IronScheme;

namespace ClassLibraryScheme
{
    public class Laberinto
    {
        /* ATRIBUTOS */
        private Vector3 inicio;

        public Vector3 Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        private Vector3 final;

        public Vector3 Final
        {
            get { return final; }
            set { final = value; }
        }
        private int dimX;

        public int DimX
        {
            get { return dimX; }
            set { dimX = value; }
        }
        private int dimY;

        public int DimY
        {
            get { return dimY; }
            set { dimY = value; }
        }
        private List<Vector3> lab;

        public List<Vector3> laberinto
        {
            get { return lab; }
            set { lab = value; }
        }
        /* FIN ATRIBUTOS */

        /* CONSTRUCTOR */
        public Laberinto(IronScheme.Runtime.Cons laberinto)
        {
            Vector3 aniadir = new Vector3();
            IronScheme.Runtime.Cons aux;
            ("(import (SchemeLibraries laberinto))").Eval();
            String tr = "(getInicio '" + laberinto.ToPrettyString().Replace('\n',' ').Trim() + ")";
            aux = (IronScheme.Runtime.Cons)(tr).Eval();
            this.Inicio = new Vector3(aux);
            aux = (IronScheme.Runtime.Cons)("(getFinal '" + laberinto.ToPrettyString().Replace('\n', ' ').Trim() + ")").Eval();
            this.Final = new Vector3(aux);
            this.DimX = (int)("(getDimX '" + laberinto.ToPrettyString().Replace('\n', ' ').Trim() + ")").Eval();
            this.DimY = (int)("(getDimY '" + laberinto.ToPrettyString().Replace('\n', ' ').Trim() + ")").Eval();
            aux = (IronScheme.Runtime.Cons)laberinto.cdr;
            aux = (IronScheme.Runtime.Cons)aux.car;
            // GENERANDO LABERINTO LIST<VECTOR3>
            this.lab = new List<Vector3>();
            this.lab.Add(this.Final);        
            //EMPIEZA DEL FINAL, HASTA EL INICIO, EL RESTO DEL LABERINTO ESTA ENTRE ELLOS, GENERA UN CAMINO
            do
            {
                aux = (IronScheme.Runtime.Cons)aux.cdr;
                aniadir = new Vector3((IronScheme.Runtime.Cons)aux.car);
                this.lab.Add(aniadir);
            }
            while (!this.Inicio.Equals(aniadir));

        }
    }
}
