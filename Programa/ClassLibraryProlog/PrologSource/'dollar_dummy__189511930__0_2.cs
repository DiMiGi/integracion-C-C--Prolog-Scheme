/*
 * *** Please do not edit ! ***
 * @(#) dollar_dummy__189511930__0_2.cs
 * @procedure $dummy_189511930_0/2 in 189511930.pl
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

public class dollar_dummy__189511930__0_2 : Predicate {
    static internal readonly Predicate dollar_dummy__189511930__0_2_1 = new Predicates.dollar_dummy__189511930__0_2_1();
    static internal readonly Predicate dollar_dummy__189511930__0_2_2 = new Predicates.dollar_dummy__189511930__0_2_2();
    static internal readonly Predicate dollar_dummy__189511930__0_2_3 = new Predicates.dollar_dummy__189511930__0_2_3();
    static internal readonly Predicate dollar_dummy__189511930__0_2_sub_1 = new Predicates.dollar_dummy__189511930__0_2_sub_1();

    public Term arg1, arg2;

    public dollar_dummy__189511930__0_2(Term a1, Term a2, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        this.cont = cont;
    }

    public dollar_dummy__189511930__0_2(){}
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
        return engine.jtry(dollar_dummy__189511930__0_2_1, dollar_dummy__189511930__0_2_sub_1);
    }

    public override int arity() { return 2; }

    public override string ToString() {
        return "$dummy_189511930_0(" + arg1 + ", " + arg2 + ")";
    }
}

sealed class dollar_dummy__189511930__0_2_sub_1 : dollar_dummy__189511930__0_2 {
    static internal readonly Predicate dollar_dummy__189511930__0_2_sub_2 = new Predicates.dollar_dummy__189511930__0_2_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(dollar_dummy__189511930__0_2_2, dollar_dummy__189511930__0_2_sub_2);
    }
}

sealed class dollar_dummy__189511930__0_2_sub_2 : dollar_dummy__189511930__0_2 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(dollar_dummy__189511930__0_2_3);
    }
}

sealed class dollar_dummy__189511930__0_2_1 : dollar_dummy__189511930__0_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(5);
    static internal readonly IntegerTerm s2 = new IntegerTerm(4);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        a3 = engine.makeVariable();
        a4 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_multi_3(a4, s1, a2, p1);
        p3 = new Predicates.dollar_minus_3(a1, s2, a4, p2);
        p4 = new Predicates.dollar_greaterOrEqual_2(a1, s1, p3);
        return new Predicates.dollar_getLevel_1(a3, p4);
    }
}

sealed class dollar_dummy__189511930__0_2_2 : dollar_dummy__189511930__0_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(5);
    static internal readonly IntegerTerm s2 = new IntegerTerm(2);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_is_2(a2, a1, p1);
        p3 = new Predicates.dollar_greaterThan_2(a1, s2, p2);
        p4 = new Predicates.dollar_lessThan_2(a1, s1, p3);
        return new Predicates.dollar_getLevel_1(a3, p4);
    }
}

sealed class dollar_dummy__189511930__0_2_3 : dollar_dummy__189511930__0_2 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);
    static internal readonly IntegerTerm s2 = new IntegerTerm(2);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a2, engine.trail) ) return engine.fail();
        a3 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a3, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, s2, p1);
        return new Predicates.dollar_getLevel_1(a3, p2);
    }
}
}

