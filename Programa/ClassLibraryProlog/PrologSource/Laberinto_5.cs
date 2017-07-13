/*
 * *** Please do not edit ! ***
 * @(#) Laberinto_5.cs
 * @procedure laberinto/5 in 189511930.pl
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

public class Laberinto_5 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("noPuedeSerMuro", 1);
    static internal readonly SymbolTerm f3 = SymbolTerm.MakeSymbol("adyacente", 2);
    static internal readonly SymbolTerm f5 = SymbolTerm.MakeSymbol("esMuro", 1);
    static internal readonly IntegerTerm s7 = new IntegerTerm(1);
    static internal readonly SymbolTerm f8 = SymbolTerm.MakeSymbol("existeCamino", 1);
    static internal readonly SymbolTerm s10 = SymbolTerm.MakeSymbol("[]");

    public Term arg1, arg2, arg3, arg4, arg5;

    public Laberinto_5(Term a1, Term a2, Term a3, Term a4, Term a5, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        arg5 = a5; 
        this.cont = cont;
    }

    public Laberinto_5(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        arg5 = args[4]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21;
        Predicate p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();
        a3 = arg3.Dereference();
        a4 = arg4.Dereference();
        a5 = arg5.Dereference();

        a6 = engine.makeVariable();
        a7 = engine.makeVariable();
        a8 = engine.makeVariable();
        a9 = engine.makeVariable();
        a10 = engine.makeVariable();
        Term[] h2 = {engine.makeVariable()};
        a11 = new StructureTerm(f1, h2);
        a12 = engine.makeVariable();
        Term[] h4 = {engine.makeVariable(), engine.makeVariable()};
        a13 = new StructureTerm(f3, h4);
        Term[] h6 = {engine.makeVariable()};
        a14 = new StructureTerm(f5, h6);
        a15 = engine.makeVariable();
        a16 = engine.makeVariable();
        Term[] h9 = {engine.makeVariable()};
        a17 = new StructureTerm(f8, h9);
        a18 = engine.makeVariable();
        a19 = engine.makeVariable();
        a20 = new ListTerm(a12, s10);
        a21 = new ListTerm(a19, s10);
        p1 = new Predicates.dollar_cut_1(a6, cont);
        p2 = new Predicates.Verificar_Laberinto_1(a1, p1);
        p3 = new Predicates.Concatenar_Arreglos_3(a20, a21, a1, p2);
        p4 = new Predicates.ObtenerArregloTrofeos_1(a19, p3);
        p5 = new Predicates.CrearTrofeos_3(a12, a8, a18, p4);
        p6 = new Predicates.Calcular_Cant_Trofeos_3(a16, a4, a18, p5);
        p7 = new Predicates.Retractall_1(a17, p6);
        p8 = new Predicates.dollar_minus_3(a15, s7, a16, p7);
        p9 = new Predicates.Contar_2(a12, a15, p8);
        p10 = new Predicates.Retractall_1(a14, p9);
        p11 = new Predicates.Retractall_1(a13, p10);
        p12 = new Predicates.GenerarCamino_5(a12, a9, a10, a2, a3, p11);
        p13 = new Predicates.Retractall_1(a11, p12);
        p14 = new Predicates.CrearCamino_5(a2, a3, a7, a9, a10, p13);
        p15 = new Predicates.dollar_multi_3(a2, a3, a8, p14);
        p16 = new Predicates.Calcular_Cant_Muros_2(a2, a7, p15);
        return new Predicates.dollar_getLevel_1(a6, p16);
    }

    public override int arity() { return 5; }

    public override string ToString() {
        return "laberinto(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ")";
    }
}
}

