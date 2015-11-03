












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

    public partial class Args : ReqlExpr {

    
    
    
/// <summary>
/// <para><code>r.args</code> is a special term that's used to splice an array of arguments
/// into another term.  This is useful when you want to call a variadic
/// term such as <code>getAll</code> with a set of arguments produced at runtime.</para>
/// <para>This is analogous to using apply in JavaScript.</para>
/// </summary>
/// <example><para>Example: Get Alice and Bob from the table <code>people</code>.</para>
/// <code>r.table('people').getAll('Alice', 'Bob').run(conn, callback)
/// // or
/// r.table('people').getAll(r.args(['Alice', 'Bob'])).run(conn, callback)
/// </code></example>
        public Args (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para><code>r.args</code> is a special term that's used to splice an array of arguments
/// into another term.  This is useful when you want to call a variadic
/// term such as <code>getAll</code> with a set of arguments produced at runtime.</para>
/// <para>This is analogous to using apply in JavaScript.</para>
/// </summary>
/// <example><para>Example: Get Alice and Bob from the table <code>people</code>.</para>
/// <code>r.table('people').getAll('Alice', 'Bob').run(conn, callback)
/// // or
/// r.table('people').getAll(r.args(['Alice', 'Bob'])).run(conn, callback)
/// </code></example>
        public Args (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para><code>r.args</code> is a special term that's used to splice an array of arguments
/// into another term.  This is useful when you want to call a variadic
/// term such as <code>getAll</code> with a set of arguments produced at runtime.</para>
/// <para>This is analogous to using apply in JavaScript.</para>
/// </summary>
/// <example><para>Example: Get Alice and Bob from the table <code>people</code>.</para>
/// <code>r.table('people').getAll('Alice', 'Bob').run(conn, callback)
/// // or
/// r.table('people').getAll(r.args(['Alice', 'Bob'])).run(conn, callback)
/// </code></example>
        public Args (Arguments args, OptArgs optargs)
         : base(TermType.ARGS, args, optargs) {
        }


    



    


    

    


    
    }
}
