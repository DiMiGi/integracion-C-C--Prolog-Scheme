/*
 * *** Please do not edit ! ***
 * @(#) Get_Lab_2.cs
 * @procedure getLab/2 in 189511930.pl
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

public class Get_Lab_2 : Predicate {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public Term arg1, arg2;

    public Get_Lab_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Get_Lab_2(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();

        if ( a1.IsList() ){
            a3 = ((ListTerm)a1).car;
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a3 = engine.makeVariable();
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a3, a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a5 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a5 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(engine.makeVariable(), a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            if ( !s1.Unify(((ListTerm)a4).cdr, engine.trail) )
                return engine.fail();
        } else if ( a4.IsVariable() ){
            if ( !a4.Unify(new ListTerm(engine.makeVariable(), s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( !a5.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "getLab(" + arg1 + ", " + arg2 + ")";
    }
}
}

