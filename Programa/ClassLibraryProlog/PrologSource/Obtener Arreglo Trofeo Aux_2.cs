/*
 * *** Please do not edit ! ***
 * @(#) ObtenerArregloTrofeoAux_2.cs
 * @procedure obtener_arreglo_trofeo_aux/2 in 189511930.pl
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

public class ObtenerArregloTrofeoAux_2 : Predicate {
    static internal readonly Predicate ObtenerArregloTrofeoAux_2_1 = new Predicates.ObtenerArregloTrofeoAux_2_1();
    static internal readonly Predicate ObtenerArregloTrofeoAux_2_2 = new Predicates.ObtenerArregloTrofeoAux_2_2();
    static internal readonly Predicate ObtenerArregloTrofeoAux_2_sub_1 = new Predicates.ObtenerArregloTrofeoAux_2_sub_1();

    public Term arg1, arg2;

    public ObtenerArregloTrofeoAux_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public ObtenerArregloTrofeoAux_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(ObtenerArregloTrofeoAux_2_1, ObtenerArregloTrofeoAux_2_sub_1);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "obtener_arreglo_trofeo_aux(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class ObtenerArregloTrofeoAux_2_sub_1 : ObtenerArregloTrofeoAux_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(ObtenerArregloTrofeoAux_2_2);
    }
}

sealed class ObtenerArregloTrofeoAux_2_1 : ObtenerArregloTrofeoAux_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !a1.Unify(a2, engine.trail) ) return engine.fail();
        return new Predicates.dollar_dummy__189511930__16_1(engine.makeVariable(), cont);
    }
}

sealed class ObtenerArregloTrofeoAux_2_2 : ObtenerArregloTrofeoAux_2 {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("esTrofeo", 1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3, p4, p5;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        a3 = engine.makeVariable();
        a4 = engine.makeVariable();
        a5 = engine.makeVariable();
        Term[] h2 = {a4};
        a6 = new StructureTerm(f1, h2);
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.ObtenerArregloTrofeoAux_2(a5, a2, p1);
        p3 = new Predicates.Retract_1(a6, p2);
        p4 = new Predicates.Concatenar_Valor_3(a1, a4, a5, p3);
        p5 = new Predicates.Es_Trofeo_1(a4, p4);
        return new Predicates.dollar_getLevel_1(a3, p5);
    }
}
}

