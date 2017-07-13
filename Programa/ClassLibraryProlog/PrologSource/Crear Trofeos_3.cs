/*
 * *** Please do not edit ! ***
 * @(#) CrearTrofeos_3.cs
 * @procedure crear_trofeos/3 in 189511930.pl
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

public class CrearTrofeos_3 : Predicate {
    static internal readonly SymbolTerm f1 = SymbolTerm.MakeSymbol("esTrofeo", 1);
    static internal readonly IntegerTerm s3 = new IntegerTerm(0);

    public Term arg1, arg2, arg3;

    public CrearTrofeos_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public CrearTrofeos_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4, a5, a6;
        Predicate p1, p2, p3;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();
        a3 = arg3.Dereference();

        if ( a1.IsList() ){
            a4 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(engine.makeVariable(), a4), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a5 = engine.makeVariable();
        Term[] h2 = {engine.makeVariable()};
        a6 = new StructureTerm(f1, h2);
        p1 = new Predicates.dollar_cut_1(a5, cont);
        p2 = new Predicates.CrearTrofeo_4(a4, a2, s3, a3, p1);
        p3 = new Predicates.Retractall_1(a6, p2);
        return new Predicates.dollar_getLevel_1(a5, p3);
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "crear_trofeos(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}
}

