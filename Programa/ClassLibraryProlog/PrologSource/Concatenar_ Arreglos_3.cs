/*
 * *** Please do not edit ! ***
 * @(#) Concatenar_Arreglos_3.cs
 * @procedure concatenarArreglos/3 in 189511930.pl
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

public class Concatenar_Arreglos_3 : Predicate, FcoPredicate {
    static internal readonly System.Type EntryCodeType = typeof( Concatenar_Arreglos_3 );
    static internal readonly Predicate dollar_fail_0 = new Predicates.dollar_fail_0();
    static internal readonly Predicate Concatenar_Arreglos_3_1 = new Predicates.Concatenar_Arreglos_3_1();
    static internal readonly Predicate Concatenar_Arreglos_3_2 = new Predicates.Concatenar_Arreglos_3_2();
    static internal readonly Predicate Concatenar_Arreglos_3_3 = new Predicates.Concatenar_Arreglos_3_3();
    static internal readonly Predicate Concatenar_Arreglos_3_con = new Predicates.Concatenar_Arreglos_3_con();
    static internal readonly Predicate Concatenar_Arreglos_3_var = new Predicates.Concatenar_Arreglos_3_var();

    public Term arg1, arg2, arg3;

    public Concatenar_Arreglos_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public Concatenar_Arreglos_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.SetEntryCode( EntryCodeType, this );
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.switch_on_term(
                                   Concatenar_Arreglos_3_var,
                                   dollar_fail_0,
                                   Concatenar_Arreglos_3_con,
                                   dollar_fail_0,
                                   Concatenar_Arreglos_3_3
                                   );
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "concatenarArreglos(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}

sealed class Concatenar_Arreglos_3_var : Concatenar_Arreglos_3 {
    static internal readonly Predicate Concatenar_Arreglos_3_var_1 = new Predicates.Concatenar_Arreglos_3_var_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Concatenar_Arreglos_3_1, Concatenar_Arreglos_3_var_1);
    }
}

sealed class Concatenar_Arreglos_3_var_1 : Concatenar_Arreglos_3 {
    static internal readonly Predicate Concatenar_Arreglos_3_var_2 = new Predicates.Concatenar_Arreglos_3_var_2();

    public override Predicate exec( Prolog engine ) {
        return engine.retry(Concatenar_Arreglos_3_2, Concatenar_Arreglos_3_var_2);
    }
}

sealed class Concatenar_Arreglos_3_var_2 : Concatenar_Arreglos_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Concatenar_Arreglos_3_3);
    }
}

sealed class Concatenar_Arreglos_3_con : Concatenar_Arreglos_3 {
    static internal readonly Predicate Concatenar_Arreglos_3_con_1 = new Predicates.Concatenar_Arreglos_3_con_1();

    public override Predicate exec( Prolog engine ) {
        return engine.jtry(Concatenar_Arreglos_3_1, Concatenar_Arreglos_3_con_1);
    }
}

sealed class Concatenar_Arreglos_3_con_1 : Concatenar_Arreglos_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(Concatenar_Arreglos_3_2);
    }
}

sealed class Concatenar_Arreglos_3_1 : Concatenar_Arreglos_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
        if ( a2.IsList() ){
            a4 = ((ListTerm)a2).car;
            if ( !s1.Unify(((ListTerm)a2).cdr, engine.trail) )
                return engine.fail();
        } else if ( a2.IsVariable() ){
            a4 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a4, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            if ( !a4.Unify(((ListTerm)a3).car, engine.trail) )
                return engine.fail();
            if ( !s1.Unify(((ListTerm)a3).cdr, engine.trail) )
                return engine.fail();
        } else if ( a3.IsVariable() ){
            if ( !a3.Unify(new ListTerm(a4, s1), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        return new Predicates.dollar_neckCut_0(cont);
    }
}

sealed class Concatenar_Arreglos_3_2 : Concatenar_Arreglos_3 {
    static internal readonly SymbolTerm s1 = SymbolTerm.MakeSymbol("[]");

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( !s1.Unify(a1, engine.trail) ) return engine.fail();
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
        if ( a3.IsList() ){
            if ( !a4.Unify(((ListTerm)a3).car, engine.trail) )
                return engine.fail();
            a6 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a6 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a6), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        engine.aregs[1] = s1;
        engine.aregs[2] = a5;
        engine.aregs[3] = a6;
        engine.cont = cont;
        return engine.GetEntryCode( EntryCodeType ).call( engine );
    }
}

sealed class Concatenar_Arreglos_3_3 : Concatenar_Arreglos_3 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4, a5, a6, a7, a8, a9;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( a1.IsList() ){
            a4 = ((ListTerm)a1).car;
            a5 = ((ListTerm)a1).cdr;
        } else if ( a1.IsVariable() ){
            a4 = engine.makeVariable();
            a5 = engine.makeVariable();
            if ( !a1.Unify(new ListTerm(a4, a5), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a2.IsList() ){
            a6 = ((ListTerm)a2).car;
            a7 = ((ListTerm)a2).cdr;
        } else if ( a2.IsVariable() ){
            a6 = engine.makeVariable();
            a7 = engine.makeVariable();
            if ( !a2.Unify(new ListTerm(a6, a7), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        if ( a3.IsList() ){
            if ( !a4.Unify(((ListTerm)a3).car, engine.trail) )
                return engine.fail();
            a8 = ((ListTerm)a3).cdr;
        } else if ( a3.IsVariable() ){
            a8 = engine.makeVariable();
            if ( !a3.Unify(new ListTerm(a4, a8), engine.trail) )
                return engine.fail();
        } else {
            return engine.fail();
        }
        a9 = new ListTerm(a6, a7);
        engine.aregs[1] = a5;
        engine.aregs[2] = a9;
        engine.aregs[3] = a8;
        engine.cont = cont;
        return engine.GetEntryCode( EntryCodeType ).call( engine );
    }
}
}

