using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JJC.Psharp.Lang;
using JJC.Psharp.Predicates;


namespace ClassLibraryProlog
{
    public class PrologMain
    {
        /* ATRIBUTOS */
        private Laberinto laberinto;

        public Laberinto Laberinto
        {
            get { return laberinto; }
            set { laberinto = value; }
        }

        private Term representacionLaberinto;

        public Term RepresentacionLaberinto
        {
            get { return representacionLaberinto; }
            set { representacionLaberinto = value; }
        }

        private PrologInterface pInterface;
        /* FIN ATRIBUTOS */

        /* METODO QUE CREA UN LABERINTO DESDE PROLOG E INICIALIZA EL ATRIBUTO REPRESENTACIONLABERINTO Y LABERINTO 
           * LA CANTIDAD DE TROFEOS ESTA DADA POR EL NIVEL DE DIFICULTAD ENTRE 0 Y 10, NADA DE TROFEOS O LLENO.
         */
        public void crearLaberinto(int dimensionX,int dimensionY,int nivelDificultad)
        {
            Term nil = SymbolTerm.MakeSymbol("0");
            bool resultado;
            //laberinto(L,DimX,DimY,Dificultad,MinimosCaminosSalida(noImplementado))
            Predicate predicate;
            VariableTerm laberintoCompleto;
            Laberinto_5 lab;

            /* INSTANCIAS */
            VariableTerm laberinto = new VariableTerm();
            VariableTerm trofeos = new VariableTerm();
            VariableTerm inicio = new VariableTerm();
            VariableTerm final = new VariableTerm();
            IntegerTerm dimX = new IntegerTerm(dimensionX);
            IntegerTerm dimY = new IntegerTerm(dimensionY);
            IntegerTerm dificultad = new IntegerTerm(nivelDificultad);

            if (pInterface == null)
                pInterface = new PrologInterface();
            /* FIN */

            //MIENTRAS NO GENERE UN RESULTADO INTENTARA CREAR UN LABERINTO
            do
            {
                /* === INSTANCIAS Y EJECUCION PARA LA CREACION DEL LABERINTO MEDIANTE PROLOG === */
                laberintoCompleto = new VariableTerm();
                lab = new Laberinto_5(laberintoCompleto, dimX, dimY, dificultad, nil, new ReturnCs(pInterface));
                predicate = lab;
                pInterface.SetPredicate(predicate);
                resultado = pInterface.Call();
                /* === FINALIZA INSTANCIAS Y EJECUCIONES === */
                if (resultado)
                {
                    /* === ASIGNACION DE ATRIBUTOS DE CLASE === */
                    predicate = new Get_Lab_2(laberintoCompleto, laberinto, new ReturnCs(pInterface));
                    pInterface.SetPredicate(predicate);
                    pInterface.Call();
                    predicate = new Get_Trof_2(laberintoCompleto, trofeos, new ReturnCs(pInterface));
                    pInterface.SetPredicate(predicate);
                    pInterface.Call();
                    predicate = new Get_Inicio_2(laberintoCompleto, inicio, new ReturnCs(pInterface));
                    pInterface.SetPredicate(predicate);
                    pInterface.Call();
                    predicate = new Get_Final_2(laberintoCompleto, final, new ReturnCs(pInterface));
                    pInterface.SetPredicate(predicate);
                    pInterface.Call();
                    /* === FIN ASIGNACION === */

                    RepresentacionLaberinto = laberintoCompleto.Dereference();
                    Console.WriteLine(RepresentacionLaberinto.ToString());
                    Laberinto = new Laberinto((ListTerm)laberinto.Dereference(), (ListTerm)trofeos.Dereference(), ((IntegerTerm)inicio.Dereference()).IntValue(), ((IntegerTerm)final.Dereference()).IntValue(), dimensionX, dimensionY);
                }
            } while (!resultado);
        }
    }
}
