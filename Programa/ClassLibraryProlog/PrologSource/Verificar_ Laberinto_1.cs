/*
 * *** Please do not edit ! ***
 * @(#) Verificar_Laberinto_1.cs
 * @procedure verificarLaberinto/1 in 189511930.pl
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

public class Verificar_Laberinto_1 : Predicate {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public Term arg1;

    public Verificar_Laberinto_1(Term a1, Predicate cont) {
        arg1 = a1; 
        this.cont = cont;
    }

    public Verificar_Laberinto_1(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13;
        Predicate p1, p2, p3, p4, p5, p6, p7;
        a1 = arg1.Dereference();

        if ( a1.IsList() ){
            a2 = ((ListTerm)a1).car;
            a3 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a2 = engine.makeVariable();
            a3 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a2, a3), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a4 = ((ListTerm)a2).car;
            a5 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a4.IsList() ){
            a6 = ((ListTerm)a4).car;
            a7 = ((ListTerm)a4).cdr;
        } else if ( a4.IsVariable() ){
            a6 = engine.makeVariable();
            a7 = engine.makeVariable();
            if ( !a4.Unify(new ListTerm(a6, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a7.IsList() ){
            a8 = ((ListTerm)a7).car;
            a9 = ((ListTerm)a7).cdr;
        } else if ( a7.IsVariable() ){
            a8 = engine.makeVariable();
            a9 = engine.makeVariable();
            if ( !a7.Unify(new ListTerm(a8, a9), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a9.IsList() ){
            a10 = ((ListTerm)a9).car;
            a11 = ((ListTerm)a9).cdr;
        } else if ( a9.IsVariable() ){
            a10 = engine.makeVariable();
            a11 = engine.makeVariable();
            if ( !a9.Unify(new ListTerm(a10, a11), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a11.IsList() ){
            if ( !s1.Unify(((ListTerm)a11).cdr, engine.trail) )
                return engine.fail();
        } else if ( a11.IsVariable() ){
            if ( !a11.Unify(new ListTerm(engine.makeVariable(), s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            a12 = ((ListTerm)a3).car;
            if ( !s1.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            a12 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a12, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a13 = engine.makeVariable();
        p1 = new Predicates.dollar_cut_1(a13, cont);
        p2 = new Predicates.Contiene_2(a5, a8, p1);
        p3 = new Predicates.Contiene_2(a5, a6, p2);
        p4 = new Predicates.Esta_Contenido_2(a12, a5, p3);
        p5 = new Predicates.Verificar_Adyacencias_2(a5, a10, p4);
        p6 = new Predicates.dollar_dummy__189511930__18_1(a12, p5);
        p7 = new Predicates.dollar_dummy__189511930__17_1(a5, p6);
        return new Predicates.dollar_getLevel_1(a13, p7);
    }

    public override int arity() { return 1; }

    public override string ToString() {
        return "verificarLaberinto(" + arg1 + ")";
    }
}
}

