/*
 * *** Please do not edit ! ***
 * @(#) Contar_2.cs
 * @procedure contar/2 in 189511930.pl
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

public class Contar_2 : Predicate {
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate Contar_2_1 = new Predicates.Contar_2_1();
    static internal readonly Predicate Contar_2_2 = new Predicates.Contar_2_2();
    static internal readonly Predicate Contar_2_var = new Predicates.Contar_2_var();

    public Term arg1, arg2;

    public Contar_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public Contar_2(){}
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
                                   Contar_2_var,
                                   dollar_fail_0,
                                   Contar_2_1,
                                   dollar_fail_0,
                                   Contar_2_2
                                   );
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "contar(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class Contar_2_var : Contar_2 {
    static internal readonly Predicate Contar_2_var_1 = new Predicates.Contar_2_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Contar_2_1, Contar_2_var_1);
    }
}

sealed class Contar_2_var_1 : Contar_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Contar_2_2);
    }
}

sealed class Contar_2_1 : Contar_2 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");
    static internal readonly IntegerTerm s2 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( !s2.Unify(a2, engine.trail) ) return engine.fail();
        return cont;
    }
}

sealed class Contar_2_2 : Contar_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a3 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a3 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(engine.makeVariable(), a3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a4 = engine.makeVariable();
        a5 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a4, cont);
        p2 = new Predicates.dollar_plus_3(a5, s1, a2, p1);
        p3 = new Predicates.Contar_2(a3, a5, p2);
        return new Predicates.dollar_getLevel_1(a4, p3);
    }
}
}

