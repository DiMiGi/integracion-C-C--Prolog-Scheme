/*
 * *** Please do not edit ! ***
 * @(#) BuscarRepetidos_1.cs
 * @procedure buscar_repetidos/1 in 189511930.pl
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

public class BuscarRepetidos_1 : Predicate {

    public Term arg1;

    public BuscarRepetidos_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public BuscarRepetidos_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3;
        a1 = arg1.Dereference();

        if ( a1.IsList() ){
            a2 = ((ListTerm)a1).car;
            a3 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            a3 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a2, a3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return new Predicates.dollar_dummy__189511930__28_2(a2, a3, cont);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "buscar_repetidos(" + arg1 + ")";
    }
}
}

