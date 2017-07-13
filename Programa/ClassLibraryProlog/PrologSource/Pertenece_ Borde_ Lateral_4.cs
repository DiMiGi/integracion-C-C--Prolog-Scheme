/*
 * *** Please do not edit ! ***
 * @(#) Pertenece_Borde_Lateral_4.cs
 * @procedure perteneceBordeLateral/4 in 189511930.pl
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

public class Pertenece_Borde_Lateral_4 : Predicate {

    public Term arg1, arg2, arg3, arg4;

    public Pertenece_Borde_Lateral_4(Term a1, Term a2, Term a3, Term a4, Predicate cont) {
        arg1 = a1; 
        arg2 = a2; 
        arg3 = a3; 
        arg4 = a4; 
        this.cont = cont;
    }

    public Pertenece_Borde_Lateral_4(){}
    public override void setArgument(Term[] args, Predicate cont) {
        arg1 = args[0]; 
        arg2 = args[1]; 
        arg3 = args[2]; 
        arg4 = args[3]; 
        this.cont = cont;
    }

    public override Predicate exec( Prolog engine ) {
        engine.setB0();
        Term a1, a2, a3, a4;
        a1 = arg1.Dereference();
        a2 = arg2.Dereference();
        a3 = arg3.Dereference();
        a4 = arg4.Dereference();

        return new Predicates.dollar_dummy__189511930__20_7(a1, a2, a3, a4, engine.makeVariable(), engine.makeVariable(), engine.makeVariable(), cont);
    }

    public override int arity() { return 4; }

    public override string ToString() {
        return "perteneceBordeLateral(" + arg1 + ", " + arg2 + ", " + arg3 + ", " + arg4 + ")";
    }
}
}

