/*
 * *** Please do not edit ! ***
 * @(#) CrearMuro_3.cs
 * @procedure crear_muro/3 in 189511930.pl
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

public class CrearMuro_3 : Predicate {
    static internal readonly Predicate CrearMuro_3_1 = new Predicates.CrearMuro_3_1();
    static internal readonly Predicate CrearMuro_3_2 = new Predicates.CrearMuro_3_2();
    static internal readonly Predicate CrearMuro_3_sub_1 = new Predicates.CrearMuro_3_sub_1();

    public Term arg1, arg2, arg3;

    public CrearMuro_3(Term a1, Term a2, Term a3, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        this.cont = cont;
    }

    public CrearMuro_3(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.aregs[1] = arg1;
        engine.aregs[2] = arg2;
        engine.aregs[3] = arg3;
        engine.cont = cont;
        return call( engine );
    }

    public virtual Predicate call( Prolog engine ) {
        engine.setB0();
        return engine.jtry(CrearMuro_3_1, CrearMuro_3_sub_1);
    }

    public override int arity() { return 3; }

    public override string ToString() {
        return "crear_muro(" + arg1 + ", " + arg2 + ", " + arg3 + ")";
    }
}

sealed class CrearMuro_3_sub_1 : CrearMuro_3 {

    public override Predicate exec( Prolog engine ) {
        return engine.trust(CrearMuro_3_2);
    }
}

sealed class CrearMuro_3_1 : CrearMuro_3 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        if ( !a2.Unify(a3, engine.trail) ) return engine.fail();
        return new Predicates.dollar_neckCut_0(cont);
    }
}

sealed class CrearMuro_3_2 : CrearMuro_3 {

    public override Predicate exec( Prolog engine ) {
        Term a1, a2, a3;
        a1 = engine.aregs[1].Dereference();
        a2 = engine.aregs[2].Dereference();
        a3 = engine.aregs[3].Dereference();
        Predicate cont = engine.cont;

        return new Predicates.dollar_dummy__189511930__21_5(a1, a2, a3, engine.makeVariable(), engine.makeVariable(), cont);
    }
}
}

