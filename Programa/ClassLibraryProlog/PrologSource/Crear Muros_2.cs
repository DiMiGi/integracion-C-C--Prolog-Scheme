/*
 * *** Please do not edit ! ***
 * @(#) CrearMuros_2.cs
 * @procedure crear_muros/2 in 189511930.pl
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

public class CrearMuros_2 : Predicate {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);

    public Term arg1, arg2;

    public CrearMuros_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public CrearMuros_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4;
        Predicate p1, p2, p3;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        a3 = engine.makeVariable();
        a4 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.CrearMuro_3(a4, s2, a2, p1);
        p3 = new Predicates.dollar_plus_3(a1, s1, a4, p2);
        return new Predicates.dollar_getLevel_1(a3, p3);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "crear_muros(" + arg1 + ", " + arg2 + ")";
    }
}
}

