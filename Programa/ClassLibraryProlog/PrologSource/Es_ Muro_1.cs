/*
 * *** Please do not edit ! ***
 * @(#) Es_Muro_1.cs
 * @procedure esMuro/1 in 189511930.pl
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

public class Es_Muro_1 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("esMuro", 1);

    public Term arg1;

    public Es_Muro_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public Es_Muro_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3;
        Predicate p1;
        a1 = arg1.Dereference();

        Term[] h2 = {a1};
        a2 = new StructureTerm(f1, h2);
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_call_1(a3, cont);
        return new Predicates.Clause_2(a2, a3, p1);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "esMuro(" + arg1 + ")";
    }
}
}

