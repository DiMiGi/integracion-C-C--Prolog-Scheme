/*
 * *** Please do not edit ! ***
 * @(#) GenerarCamino_5.cs
 * @procedure generar_camino/5 in 189511930.pl
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

public class GenerarCamino_5 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("existeCamino", 1);
    static internal readonly SymbolTerm s3 = SymbolTerm.MakeSymbol("[]");

    public Term arg1, arg2, arg3, arg4, arg5;

    public GenerarCamino_5(Term a1, Term a2, Term a3, Term a4, Term a5, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        arg5 = a5; 
        this.cont = cont;
    }

    public GenerarCamino_5(){}
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
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13;
        Predicate p1, p2, p3;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();
        a3 = arg3.Dereference();
        a4 = arg4.Dereference();
        a5 = arg5.Dereference();

        Term[] h2 = {engine.makeVariable()};
        a6 = new StructureTerm(f1, h2);
        a7 = engine.makeVariable();
        a8 = engine.makeVariable();
        a13 = new ListTerm(a5, s3);
        a12 = new ListTerm(a4, a13);
        a11 = new ListTerm(a3, a12);
        a10 = new ListTerm(a2, a11);
        a9 = new ListTerm(a10, s3);
        p1 = new Predicates.Concatenar_Arreglos_3(a9, a8, a1, cont);
        p2 = new Predicates.Concatenar_Valor_3(a7, a2, a8, p1);
        p3 = new Predicates.GenerarCamino_4(a3, a2, s3, a7, p2);
        return new Predicates.Retractall_1(a6, p3);
    }

    public override int arity() { return 5; }

    public override string ToString() {
        return "generar_camino(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ", " + arg5 + ")";
    }
}
}

