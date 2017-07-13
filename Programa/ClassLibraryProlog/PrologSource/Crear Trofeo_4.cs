/*
 * *** Please do not edit ! ***
 * @(#) CrearTrofeo_4.cs
 * @procedure crear_trofeo/4 in 189511930.pl
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

public class CrearTrofeo_4 : Predicate {
    static internal readonly Predicate CrearTrofeo_4_1 = new Predicates.CrearTrofeo_4_1();
    static internal readonly Predicate CrearTrofeo_4_2 = new Predicates.CrearTrofeo_4_2();
    static internal readonly Predicate CrearTrofeo_4_sub_1 = new Predicates.CrearTrofeo_4_sub_1();

    public Term arg1, arg2, arg3, arg4;

    public CrearTrofeo_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public CrearTrofeo_4(){}
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
        return engine.jtry(CrearTrofeo_4_1, CrearTrofeo_4_sub_1);
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "crear_trofeo(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}

sealed class CrearTrofeo_4_sub_1 : CrearTrofeo_4 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(CrearTrofeo_4_2);
    }
}

sealed class CrearTrofeo_4_1 : CrearTrofeo_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        if ( !a3.Unify(a4, engine.trail) ) return engine.fail();
        return new Predicates.dollar_neckCut_0(cont);
    }
}

sealed class CrearTrofeo_4_2 : CrearTrofeo_4 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3, a4;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        a4 = engine.aregs[4].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_dummy__189511930__14_7(a1, a2, a3, a4, engine.makeVariable(), engine.makeVariable(), engine.makeVariable(), cont);
    }
}
}

