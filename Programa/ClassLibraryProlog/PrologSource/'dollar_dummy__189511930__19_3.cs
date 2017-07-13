/*
 * *** Please do not edit ! ***
 * @(#) dollar_dummy__189511930__19_3.cs
 * @procedure $dummy_189511930_19/3 in 189511930.pl
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

public class dollar_dummy__189511930__19_3 : Predicate {
    static internal readonly Predicate dollar_dummy__189511930__19_3_1 = new Predicates.dollar_dummy__189511930__19_3_1();
    static internal readonly Predicate dollar_dummy__189511930__19_3_2 = new Predicates.dollar_dummy__189511930__19_3_2();
    static internal readonly Predicate dollar_dummy__189511930__19_3_3 = new Predicates.dollar_dummy__189511930__19_3_3();
    static internal readonly Predicate dollar_dummy__189511930__19_3_sub_1 = new Predicates.dollar_dummy__189511930__19_3_sub_1();

    public Term arg1, arg2, arg3;

    public dollar_dummy__189511930__19_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public dollar_dummy__189511930__19_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(dollar_dummy__189511930__19_3_1, dollar_dummy__189511930__19_3_sub_1);
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "$dummy_189511930_19(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}

sealed class dollar_dummy__189511930__19_3_sub_1 : dollar_dummy__189511930__19_3 {
    static internal readonly Predicate dollar_dummy__189511930__19_3_sub_2 = new Predicates.dollar_dummy__189511930__19_3_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(dollar_dummy__189511930__19_3_2, dollar_dummy__189511930__19_3_sub_2);
    }
}

sealed class dollar_dummy__189511930__19_3_sub_2 : dollar_dummy__189511930__19_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(dollar_dummy__189511930__19_3_3);
    }
}

sealed class dollar_dummy__189511930__19_3_1 : dollar_dummy__189511930__19_3 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        Predicate p1, p2, p3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        a4 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a4, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, a2, p1);
        p3 = new Predicates.dollar_greaterThan_2(a1, s1, p2);
        return new Predicates.dollar_getLevel_1(a4, p3);
    }
}

sealed class dollar_dummy__189511930__19_3_2 : dollar_dummy__189511930__19_3 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2, p3, p4, p5, p6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        a4 = engine.makeVariable();
        a5 = engine.makeVariable();
        a6 = engine.makeVariable();
        a7 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a4, cont);
        p2 = new Predicates.dollar_lessOrEqual_2(a1, a7, p1);
        p3 = new Predicates.dollar_multi_3(a2, a3, a7, p2);
        p4 = new Predicates.dollar_greaterThan_2(a1, a6, p3);
        p5 = new Predicates.dollar_multi_3(a2, a5, a6, p4);
        p6 = new Predicates.dollar_minus_3(a3, s1, a5, p5);
        return new Predicates.dollar_getLevel_1(a4, p6);
    }
}

sealed class dollar_dummy__189511930__19_3_3 : dollar_dummy__189511930__19_3 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(0);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        a4 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a4, cont);
        p2 = new Predicates.Pertenece_Borde_Lateral_4(a1, a2, a3, s1, p1);
        return new Predicates.dollar_getLevel_1(a4, p2);
    }
}
}

