/*
 * *** Please do not edit ! ***
 * @(#) AgregarAdyacentes_2.cs
 * @procedure agregar_adyacentes/2 in 189511930.pl
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

public class AgregarAdyacentes_2 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("adyacente", 2);

    public Term arg1, arg2;

    public AgregarAdyacentes_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public AgregarAdyacentes_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2, p3, p4;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        a3 = engine.makeVariable();
        Term[] h2 = {engine.makeVariable(), engine.makeVariable()};
        a4 = new StructureTerm(f1, h2);
        a5 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.AgregarAdyacentes_3(a5, a1, a2, p1);
        p3 = new Predicates.dollar_multi_3(a1, a2, a5, p2);
        p4 = new Predicates.Retractall_1(a4, p3);
        return new Predicates.dollar_getLevel_1(a3, p4);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "agregar_adyacentes(" + arg1 + ", " + arg2 + ")";
    }
}
}

