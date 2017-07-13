/*
 * *** Please do not edit ! ***
 * @(#) Esta_Contenido_2.cs
 * @procedure estaContenido/2 in 189511930.pl
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

public class Esta_Contenido_2 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate Esta_Contenido_2_1 = new Predicates.Esta_Contenido_2_1();
    static internal readonly Predicate Esta_Contenido_2_2 = new Predicates.Esta_Contenido_2_2();
    static internal readonly Predicate Esta_Contenido_2_var = new Predicates.Esta_Contenido_2_var();

    public Term arg1, arg2;

    public Esta_Contenido_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Esta_Contenido_2(){}
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
        return engine.switch_on_term(
                                   Esta_Contenido_2_var,
                                   dollar_fail_0,
                                   Esta_Contenido_2_1,
                                   dollar_fail_0,
                                   Esta_Contenido_2_2
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "estaContenido(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class Esta_Contenido_2_var : Esta_Contenido_2 {
    static internal readonly Predicate Esta_Contenido_2_var_1 = new Predicates.Esta_Contenido_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Esta_Contenido_2_1, Esta_Contenido_2_var_1);
    }
}

sealed class Esta_Contenido_2_var_1 : Esta_Contenido_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Esta_Contenido_2_2);
    }
}

sealed class Esta_Contenido_2_1 : Esta_Contenido_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Esta_Contenido_2_2 : Esta_Contenido_2 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        Predicate p1;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

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
        p1 = new Predicates.Esta_Contenido_2(a4, a2, cont);
        return new Predicates.Contiene_2(a2, a3, p1);
    }
}
}

