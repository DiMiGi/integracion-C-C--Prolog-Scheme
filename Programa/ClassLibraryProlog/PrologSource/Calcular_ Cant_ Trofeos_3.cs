/*
 * *** Please do not edit ! ***
 * @(#) Calcular_Cant_Trofeos_3.cs
 * @procedure calcularCantTrofeos/3 in 189511930.pl
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

public class Calcular_Cant_Trofeos_3 : Predicate {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly IntegerTerm s2 = new IntegerTerm(10);

    public Term arg1, arg2, arg3;

    public Calcular_Cant_Trofeos_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public Calcular_Cant_Trofeos_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2, p3, p4, p5;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();
        a3 = arg3.Dereference();

        a4 = engine.makeVariable();
        a5 = engine.makeVariable();
        p1 = new Predicates.dollar_toInteger_2(a5, a3, cont);
        p2 = new Predicates.dollar_multi_3(a1, a4, a5, p1);
        p3 = new Predicates.dollar_floatQuotient_3(a2, s2, a4, p2);
        p4 = new Predicates.dollar_lessOrEqual_2(a2, s2, p3);
        p5 = new Predicates.dollar_greaterOrEqual_2(a2, s1, p4);
        return new Predicates.dollar_greaterThan_2(a1, s1, p5);
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "calcularCantTrofeos(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}
}

