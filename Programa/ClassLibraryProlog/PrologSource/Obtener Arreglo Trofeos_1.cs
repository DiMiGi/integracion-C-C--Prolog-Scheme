/*
 * *** Please do not edit ! ***
 * @(#) ObtenerArregloTrofeos_1.cs
 * @procedure obtener_arreglo_trofeos/1 in 189511930.pl
 */

/*
 * @version P# 1.1.3, on Sept 1 2003;  Prolog Cafe 0.44, on November 12 1999
 * @author Mutsunori Banbara (banbara@pascal.seg.kobe-u.ac.jp)
 * @author Naoyuki Tamura    (tamura@kobe-u.ac.jp)
 * Modified by Jonathan Cook (jjc@dcs.ed.ac.uk)
 */
namespace JJC.Psharp.Predicates {

using JJC.Psharp.Lang;
using JJC.Psharp.Lang.Resource;
using Predicates = JJC.Psharp.Predicates;
using Resources = JJC.Psharp.Resources;

public class ObtenerArregloTrofeos_1 : Predicate {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public Term arg1;

    public ObtenerArregloTrofeos_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public ObtenerArregloTrofeos_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2;
        Predicate p1, p2;
        a1 = arg1.Dereference();

        a2 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a2, cont);
        p2 = new Predicates.ObtenerArregloTrofeoAux_2(s1, a1, p1);
        return new Predicates.dollar_getLevel_1(a2, p2);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "obtener_arreglo_trofeos(" + arg1 + ")";
    }
}
}

