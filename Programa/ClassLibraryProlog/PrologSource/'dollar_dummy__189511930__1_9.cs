/*
 * *** Please do not edit ! ***
 * @(#) dollar_dummy__189511930__1_9.cs
 * @procedure $dummy_189511930_1/9 in 189511930.pl
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

public class dollar_dummy__189511930__1_9 : Predicate {
    static internal readonly Predicate dollar_dummy__189511930__1_9_1 = new Predicates.dollar_dummy__189511930__1_9_1();
    static internal readonly Predicate dollar_dummy__189511930__1_9_2 = new Predicates.dollar_dummy__189511930__1_9_2();
    static internal readonly Predicate dollar_dummy__189511930__1_9_sub_1 = new Predicates.dollar_dummy__189511930__1_9_sub_1();

    public Term arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9;

    public dollar_dummy__189511930__1_9(Term a1, Term a2, Term a3, Term a4, Term a5, Term a6, Term a7, Term a8, Term a9, Predicate cont) {
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

    public dollar_dummy__189511930__1_9(){}
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
        return engine.jtry(dollar_dummy__189511930__1_9_1, dollar_dummy__189511930__1_9_sub_1);
    }

    public override int arity() { return 9; }

    public override string ToString() {
        return "$dummy_189511930_1(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ", " + arg6 + ", " + arg7 + ", " + arg8 + ", " + arg9 + ")";
    }
}

sealed class dollar_dummy__189511930__1_9_sub_1 : dollar_dummy__189511930__1_9 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(dollar_dummy__189511930__1_9_2);
    }
}

sealed class dollar_dummy__189511930__1_9_1 : dollar_dummy__189511930__1_9 {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("existeCamino", 1);
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("esMuro", 1);
    static internal readonly SymbolTerm f5 = SymbolTerm.MakeSymbol("noPuedeSerMuro", 1);

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16;
        Predicate p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12;
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
        Term[] h2 = {a6};
        a11 = new StructureTerm(f1, h2);
        Term[] h4 = {a7};
        a12 = new StructureTerm(f3, h4);
        Term[] h6 = {a8};
        a13 = new StructureTerm(f5, h6);
        Term[] h7 = {a4};
        a14 = new StructureTerm(f5, h7);
        Term[] h8 = {a5};
        a15 = new StructureTerm(f1, h8);
        Term[] h9 = {a5};
        a16 = new StructureTerm(f5, h9);
        p1 = new Predicates.dollar_cut_1(a10, cont);
        p2 = new Predicates.CrearMuros_2(a9, a3, p1);
        p3 = new Predicates.dollar_multi_3(a1, a2, a9, p2);
        p4 = new Predicates.Assert_1(a16, p3);
        p5 = new Predicates.Assert_1(a15, p4);
        p6 = new Predicates.Assert_1(a14, p5);
        p7 = new Predicates.dollar_dummy__189511930__2_4(a1, a2, a4, a5, p6);
        p8 = new Predicates.CrearCaminoAux_4(a1, a2, a4, a5, p7);
        p9 = new Predicates.AgregarAdyacentes_2(a1, a2, p8);
        p10 = new Predicates.Retractall_1(a13, p9);
        p11 = new Predicates.Retractall_1(a12, p10);
        p12 = new Predicates.Retractall_1(a11, p11);
        return new Predicates.dollar_getLevel_1(a10, p12);
    }
}

sealed class dollar_dummy__189511930__1_9_2 : dollar_dummy__189511930__1_9 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10;
        Predicate p1, p2;
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
        p2 = new Predicates.CrearCamino_5(a1, a2, a3, a4, a5, p1);
        return new Predicates.dollar_getLevel_1(a10, p2);
    }
}
}

