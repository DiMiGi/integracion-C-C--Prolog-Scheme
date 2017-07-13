using System;
using System.Collections.Generic;
using System.Text;
using JJC.Psharp.Lang;
using JJC.Psharp.Predicates;

namespace ClassLibraryProlog
{
    public class Laberinto
    {
        /* ATRIBUTOS */
        private int inicio;

        public int Inicio
        {
            get { return inicio; }
            set { inicio = value; }
        }
        private int final;

        public int Final
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
        private List<int> lab;

        public List<int> laberinto
        {
            get { return lab; }
            set { lab = value; }
        }

        private List<int> trofeos;

        public List<int> Trofeos
        {
            get { return trofeos; }
            set { trofeos = value; }
        }
        /* FIN ATRIBUTOS */

        /* CONSTRUCTOR */

        public Laberinto(ListTerm laberinto,ListTerm trofeos,int inicio,int final,int dimX,int dimY)
        {
            this.laberinto = new List<int>();
            Trofeos = new List<int>();

            ListTerm aux = laberinto;
            IntegerTerm car = (IntegerTerm)aux.car.Dereference();

            this.Inicio = inicio;
            this.Final = final;
            this.DimX = dimX;
            this.DimY = dimY;

            /* TRANSFORMANDO A LISTA */
            /* TRANSFORMANDO LABERINTO*/
            while (!aux.IsNil())
            {
                if (!aux.cdr.IsNil())
                    aux = (ListTerm)aux.cdr.Dereference();
                else
                {
                    lab.Add(car.IntValue());
                    break;
                }
                this.laberinto.Add(car.IntValue());
                car = (IntegerTerm)aux.car.Dereference();
            }

            /* TRANSFORMANDO TROFEOS */
            aux = trofeos;
            car = (IntegerTerm)aux.car.Dereference();

            while (!aux.IsNil())
            {
                if (!aux.cdr.IsNil())
                    aux = (ListTerm)aux.cdr.Dereference();
                else
                {
                    Trofeos.Add(car.IntValue());
                    break;
                }
                Trofeos.Add(car.IntValue());
                car = (IntegerTerm)aux.car.Dereference();
            }
        }
    }
}
