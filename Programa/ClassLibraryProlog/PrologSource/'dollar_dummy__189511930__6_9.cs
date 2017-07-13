/*
 * *** Please do not edit ! ***
 * @(#) dollar_dummy__189511930__6_9.cs
 * @procedure $dummy_189511930_6/9 in 189511930.pl
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

public class dollar_dummy__189511930__6_9 : Predicate {
    static internal readonly Predicate dollar_dummy__189511930__6_9_1 = new Predicates.dollar_dummy__189511930__6_9_1();
    static internal readonly Predicate dollar_dummy__189511930__6_9_2 = new Predicates.dollar_dummy__189511930__6_9_2();
    static internal readonly Predicate dollar_dummy__189511930__6_9_sub_1 = new Predicates.dollar_dummy__189511930__6_9_sub_1();

    public Term arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9;

    public dollar_dummy__189511930__6_9(Term a1, Term a2, Term a3, Term a4, Term a5, Term a6, Term a7, Term a8, Term a9, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        arg5 = a5; 
        arg6 = a6; 
        arg7 = a7; 
        arg8 = a8; 
        arg9 = a9; 
        this.cont = cont;
    }

    public dollar_dummy__189511930__6_9(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        arg5 = args[4]; 
        arg6 = args[5]; 
        arg7 = args[6]; 
        arg8 = args[7]; 
        arg9 = args[8]; 
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
        engine.aregs[8] = arg8;
        engine.aregs[9] = arg9;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(dollar_dummy__189511930__6_9_1, dollar_dummy__189511930__6_9_sub_1);
    }

    public override int arity() { return 9; }

    public override string ToString() {
        return "$dummy_189511930_6(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ", " + arg6 + ", " + arg7 + ", " + arg8 + ", " + arg9 + ")";
    }
}

sealed class dollar_dummy__189511930__6_9_sub_1 : dollar_dummy__189511930__6_9 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(dollar_dummy__189511930__6_9_2);
    }
}

sealed class dollar_dummy__189511930__6_9_1 : dollar_dummy__189511930__6_9 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        Predicate p1, p2, p3, p4, p5, p6, p7, p8;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        a6 = engine.aregs[6].Dereference();
        a7 = engine.aregs[7].Dereference();
        a8 = engine.aregs[8].Dereference();
        a9 = engine.aregs[9].Dereference();
        Predicate cont = engine.cont;

        a10 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a10, cont);
        p2 = new Predicates.dollar_is_2(a4, a7, p1);
        p3 = new Predicates.dollar_is_2(a3, a6, p2);
        p4 = new Predicates.Esta_En_Bordes_3(a7, a1, a2, p3);
        p5 = new Predicates.Esta_En_Bordes_3(a6, a1, a2, p4);
        p6 = new Predicates.dollar_dummy__189511930__7_2(a6, a7, p5);
        p7 = new Predicates.Random_3(s1, a5, a7, p6);
        p8 = new Predicates.Random_3(s1, a5, a6, p7);
        return new Predicates.dollar_getLevel_1(a10, p8);
    }
}

sealed class dollar_dummy__189511930__6_9_2 : dollar_dummy__189511930__6_9 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        Predicate p1, p2, p3, p4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        a6 = engine.aregs[6].Dereference();
        a7 = engine.aregs[7].Dereference();
        a8 = engine.aregs[8].Dereference();
        a9 = engine.aregs[9].Dereference();
        Predicate cont = engine.cont;

        a10 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a10, cont);
        p2 = new Predicates.dollar_is_2(a4, a9, p1);
        p3 = new Predicates.dollar_is_2(a3, a8, p2);
        p4 = new Predicates.CrearCaminoAux_4(a1, a2, a8, a9, p3);
        return new Predicates.dollar_getLevel_1(a10, p4);
    }
}
}

