/*
 * *** Please do not edit ! ***
 * @(#) ElemInLista_2.cs
 * @procedure elem_in_lista/2 in 189511930.pl
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

public class ElemInLista_2 : Predicate {

    public Term arg1, arg2;

    public ElemInLista_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public ElemInLista_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        if ( a2.IsList() ){
            a3 = ((ListTerm)a2).car;
            a4 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a3 = engine.makeVariable();
            a4 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a3, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return new Predicates.dollar_dummy__189511930__27_3(a1, a3, a4, cont);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "elem_in_lista(" + arg1 + ", " + arg2 + ")";
    }
}
}

