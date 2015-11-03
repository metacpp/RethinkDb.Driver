












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public partial class Add : ReqlExpr {

    
    
    
/// <summary>
/// <para>Sum two numbers, concatenate two strings, or concatenate 2 arrays.</para>
/// </summary>
/// <example><para>Example: It's as easy as 2 + 2 = 4.</para>
/// <code>r.expr(2).add(2).run(conn, callback)
/// </code></example>
        public Add (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Sum two numbers, concatenate two strings, or concatenate 2 arrays.</para>
/// </summary>
/// <example><para>Example: It's as easy as 2 + 2 = 4.</para>
/// <code>r.expr(2).add(2).run(conn, callback)
/// </code></example>
        public Add (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Sum two numbers, concatenate two strings, or concatenate 2 arrays.</para>
/// </summary>
/// <example><para>Example: It's as easy as 2 + 2 = 4.</para>
/// <code>r.expr(2).add(2).run(conn, callback)
/// </code></example>
        public Add (Arguments args, OptArgs optargs)
         : base(TermType.ADD, args, optargs) {
        }


    



    


    

    


    
    }
}
