/*
 * *** Please do not edit ! ***
 * @(#) dollar_dummy__189511930__21_5.cs
 * @procedure $dummy_189511930_21/5 in 189511930.pl
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

public class dollar_dummy__189511930__21_5 : Predicate {
    static internal readonly Predicate dollar_dummy__189511930__21_5_1 = new Predicates.dollar_dummy__189511930__21_5_1();
    static internal readonly Predicate dollar_dummy__189511930__21_5_2 = new Predicates.dollar_dummy__189511930__21_5_2();
    static internal readonly Predicate dollar_dummy__189511930__21_5_sub_1 = new Predicates.dollar_dummy__189511930__21_5_sub_1();

    public Term arg1, arg2, arg3, arg4, arg5;

    public dollar_dummy__189511930__21_5(Term a1, Term a2, Term a3, Term a4, Term a5, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        arg5 = a5; 
        this.cont = cont;
    }

    public dollar_dummy__189511930__21_5(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        arg5 = args[4]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.aregs[4] = arg4;
        engine.aregs[5] = arg5;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(dollar_dummy__189511930__21_5_1, dollar_dummy__189511930__21_5_sub_1);
    }

    public override int arity() { return 5; }

    public override string ToString() {
        return "$dummy_189511930_21(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ")";
    }
}

sealed class dollar_dummy__189511930__21_5_sub_1 : dollar_dummy__189511930__21_5 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(dollar_dummy__189511930__21_5_2);
    }
}

sealed class dollar_dummy__189511930__21_5_1 : dollar_dummy__189511930__21_5 {
    static internal readonly IntegerTerm s1 = new IntegerTerm(1);
    static internal readonly SymbolTerm f2 = SymbolTerm.MakeSymbol("esMuro", 1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7;
        Predicate p1, p2, p3, p4, p5, p6, p7, p8;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        a6 = engine.makeVariable();
        Term[] h3 = {a4};
        a7 = new StructureTerm(f2, h3);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.CrearMuro_3(a1, a5, a3, p1);
        p3 = new Predicates.dollar_plus_3(a2, s1, a5, p2);
        p4 = new Predicates.Assert_1(a7, p3);
        p5 = new Predicates.dollar_dummy__189511930__24_1(a4, p4);
        p6 = new Predicates.dollar_dummy__189511930__23_1(a4, p5);
        p7 = new Predicates.dollar_dummy__189511930__22_1(a4, p6);
        p8 = new Predicates.Random_3(s1, a1, a4, p7);
        return new Predicates.dollar_getLevel_1(a6, p8);
    }
}

sealed class dollar_dummy__189511930__21_5_2 : dollar_dummy__189511930__21_5 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        a5 = engine.aregs[5].Dereference();
        Predicate cont = engine.cont;

        a6 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.CrearMuro_3(a1, a2, a3, p1);
        return new Predicates.dollar_getLevel_1(a6, p2);
    }
}
}

