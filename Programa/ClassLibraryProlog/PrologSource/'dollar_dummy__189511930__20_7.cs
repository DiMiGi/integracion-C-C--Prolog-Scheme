/*
 * *** Please do not edit ! ***
 * @(#) dollar_dummy__189511930__20_7.cs
 * @procedure $dummy_189511930_20/7 in 189511930.pl
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

public class dollar_dummy__189511930__20_7 : Predicate {
    static internal readonly Predicate dollar_dummy__189511930__20_7_1 = new Predicates.dollar_dummy__189511930__20_7_1();
    static internal readonly Predicate dollar_dummy__189511930__20_7_2 = new Predicates.dollar_dummy__189511930__20_7_2();
    static internal readonly Predicate dollar_dummy__189511930__20_7_3 = new Predicates.dollar_dummy__189511930__20_7_3();
    static internal readonly Predicate dollar_dummy__189511930__20_7_sub_1 = new Predicates.dollar_dummy__189511930__20_7_sub_1();

    public Term arg1, arg2, arg3, arg4, arg5, arg6, arg7;

    public dollar_dummy__189511930__20_7(Term a1, Term a2, Term a3, Term a4, Term a5, Term a6, Term a7, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        arg5 = a5; 
        arg6 = a6; 
        arg7 = a7; 
        this.cont = cont;
    }

    public dollar_dummy__189511930__20_7(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        arg5 = args[4]; 
        arg6 = args[5]; 
        arg7 = args[6]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.aregs[5] = arg5;
        engine.aregs[6] = arg6;
        engine.aregs[7] = arg7;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(dollar_dummy__189511930__20_7_1, dollar_dummy__189511930__20_7_sub_1);
    }

    public override int arity() { return 7; }

    public override string ToString() {
        return "$dummy_189511930_20(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ", " + arg6 + ", " + arg7 + ")";
    }
}

sealed class dollar_dummy__189511930__20_7_sub_1 : dollar_dummy__189511930__20_7 {
    static internal readonly Predicate dollar_dummy__189511930__20_7_sub_2 = new Predicates.dollar_dummy__189511930__20_7_sub_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(dollar_dummy__189511930__20_7_2, dollar_dummy__189511930__20_7_sub_2);
    }
}

sealed class dollar_dummy__189511930__20_7_sub_2 : dollar_dummy__189511930__20_7 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(dollar_dummy__189511930__20_7_3);
    }
}

sealed class dollar_dummy__189511930__20_7_1 : dollar_dummy__189511930__20_7 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        a6 = engine.aregs[6].Dereference();
        a7 = engine.aregs[7].Dereference();
        Predicate cont = engine.cont;

        a8 = engine.makeVariable();
        a9 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a8, cont);
        p2 = new Predicates.dollar_unify_2(a1, a5, p1);
        p3 = new Predicates.dollar_multi_3(a2, a9, a5, p2);
        p4 = new Predicates.dollar_plus_3(a4, s1, a9, p3);
        return new Predicates.dollar_getLevel_1(a8, p4);
    }
}

sealed class dollar_dummy__189511930__20_7_2 : dollar_dummy__189511930__20_7 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        a6 = engine.aregs[6].Dereference();
        a7 = engine.aregs[7].Dereference();
        Predicate cont = engine.cont;

        a8 = engine.makeVariable();
        a9 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a8, cont);
        p2 = new Predicates.dollar_unify_2(a1, a6, p1);
        p3 = new Predicates.dollar_plus_3(a9, s1, a6, p2);
        p4 = new Predicates.dollar_multi_3(a2, a4, a9, p3);
        return new Predicates.dollar_getLevel_1(a8, p4);
    }
}

sealed class dollar_dummy__189511930__20_7_3 : dollar_dummy__189511930__20_7 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        a6 = engine.aregs[6].Dereference();
        a7 = engine.aregs[7].Dereference();
        Predicate cont = engine.cont;

        p1 = new Predicates.Pertenece_Borde_Lateral_4(a1, a2, a3, a7, cont);
        p2 = new Predicates.dollar_lessThan_2(a4, a3, p1);
        return new Predicates.dollar_plus_3(a4, s1, a7, p2);
    }
}
}

