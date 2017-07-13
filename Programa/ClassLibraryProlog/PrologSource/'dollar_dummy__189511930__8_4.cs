/*
 * *** Please do not edit ! ***
 * @(#) dollar_dummy__189511930__8_4.cs
 * @procedure $dummy_189511930_8/4 in 189511930.pl
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

public class dollar_dummy__189511930__8_4 : Predicate {
    static internal readonly Predicate dollar_dummy__189511930__8_4_1 = new Predicates.dollar_dummy__189511930__8_4_1();
    static internal readonly Predicate dollar_dummy__189511930__8_4_2 = new Predicates.dollar_dummy__189511930__8_4_2();
    static internal readonly Predicate dollar_dummy__189511930__8_4_3 = new Predicates.dollar_dummy__189511930__8_4_3();
    static internal readonly Predicate dollar_dummy__189511930__8_4_4 = new Predicates.dollar_dummy__189511930__8_4_4();
    static internal readonly Predicate dollar_dummy__189511930__8_4_5 = new Predicates.dollar_dummy__189511930__8_4_5();
    static internal readonly Predicate dollar_dummy__189511930__8_4_6 = new Predicates.dollar_dummy__189511930__8_4_6();
    static internal readonly Predicate dollar_dummy__189511930__8_4_7 = new Predicates.dollar_dummy__189511930__8_4_7();
    static internal readonly Predicate dollar_dummy__189511930__8_4_8 = new Predicates.dollar_dummy__189511930__8_4_8();
    static internal readonly Predicate dollar_dummy__189511930__8_4_sub_1 = new Predicates.dollar_dummy__189511930__8_4_sub_1();

    public Term arg1, arg2, arg3, arg4;

    public dollar_dummy__189511930__8_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public dollar_dummy__189511930__8_4(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(dollar_dummy__189511930__8_4_1, dollar_dummy__189511930__8_4_sub_1);
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "$dummy_189511930_8(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}

sealed class dollar_dummy__189511930__8_4_sub_1 : dollar_dummy__189511930__8_4 {
    static internal readonly Predicate dollar_dummy__189511930__8_4_sub_2 = new Predicates.dollar_dummy__189511930__8_4_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(dollar_dummy__189511930__8_4_2, dollar_dummy__189511930__8_4_sub_2);
    }
}

sealed class dollar_dummy__189511930__8_4_sub_2 : dollar_dummy__189511930__8_4 {
    static internal readonly Predicate dollar_dummy__189511930__8_4_sub_3 = new Predicates.dollar_dummy__189511930__8_4_sub_3();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(dollar_dummy__189511930__8_4_3, dollar_dummy__189511930__8_4_sub_3);
    }
}

sealed class dollar_dummy__189511930__8_4_sub_3 : dollar_dummy__189511930__8_4 {
    static internal readonly Predicate dollar_dummy__189511930__8_4_sub_4 = new Predicates.dollar_dummy__189511930__8_4_sub_4();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(dollar_dummy__189511930__8_4_4, dollar_dummy__189511930__8_4_sub_4);
    }
}

sealed class dollar_dummy__189511930__8_4_sub_4 : dollar_dummy__189511930__8_4 {
    static internal readonly Predicate dollar_dummy__189511930__8_4_sub_5 = new Predicates.dollar_dummy__189511930__8_4_sub_5();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(dollar_dummy__189511930__8_4_5, dollar_dummy__189511930__8_4_sub_5);
    }
}

sealed class dollar_dummy__189511930__8_4_sub_5 : dollar_dummy__189511930__8_4 {
    static internal readonly Predicate dollar_dummy__189511930__8_4_sub_6 = new Predicates.dollar_dummy__189511930__8_4_sub_6();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(dollar_dummy__189511930__8_4_6, dollar_dummy__189511930__8_4_sub_6);
    }
}

sealed class dollar_dummy__189511930__8_4_sub_6 : dollar_dummy__189511930__8_4 {
    static internal readonly Predicate dollar_dummy__189511930__8_4_sub_7 = new Predicates.dollar_dummy__189511930__8_4_sub_7();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(dollar_dummy__189511930__8_4_7, dollar_dummy__189511930__8_4_sub_7);
    }
}

sealed class dollar_dummy__189511930__8_4_sub_7 : dollar_dummy__189511930__8_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(dollar_dummy__189511930__8_4_8);
    }
}

sealed class dollar_dummy__189511930__8_4_1 : dollar_dummy__189511930__8_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_minus_3(a1, s1, a4, cont);
    }
}

sealed class dollar_dummy__189511930__8_4_2 : dollar_dummy__189511930__8_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_plus_3(a1, s1, a4, cont);
    }
}

sealed class dollar_dummy__189511930__8_4_3 : dollar_dummy__189511930__8_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_minus_3(a1, a3, a4, cont);
    }
}

sealed class dollar_dummy__189511930__8_4_4 : dollar_dummy__189511930__8_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_plus_3(a1, a3, a4, cont);
    }
}

sealed class dollar_dummy__189511930__8_4_5 : dollar_dummy__189511930__8_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_minus_3(a2, s1, a4, cont);
    }
}

sealed class dollar_dummy__189511930__8_4_6 : dollar_dummy__189511930__8_4 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_plus_3(a2, s1, a4, cont);
    }
}

sealed class dollar_dummy__189511930__8_4_7 : dollar_dummy__189511930__8_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_minus_3(a2, a3, a4, cont);
    }
}

sealed class dollar_dummy__189511930__8_4_8 : dollar_dummy__189511930__8_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_plus_3(a2, a3, a4, cont);
    }
}
}

