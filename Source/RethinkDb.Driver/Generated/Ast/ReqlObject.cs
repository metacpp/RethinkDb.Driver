












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

    public partial class ReqlObject : ReqlExpr {

    
    
    
/// <summary>
/// <para>Creates an object from a list of key-value pairs, where the keys must
/// be strings.  <code>r.object(A, B, C, D)</code> is equivalent to
/// <code>r.expr([[A, B], [C, D]]).coerce_to('OBJECT')</code>.</para>
/// </summary>
/// <example><para>Example: Create a simple object.</para>
/// <code>r.object('id', 5, 'data', ['foo', 'bar']).run(conn, callback)
/// </code></example>
        public ReqlObject (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Creates an object from a list of key-value pairs, where the keys must
/// be strings.  <code>r.object(A, B, C, D)</code> is equivalent to
/// <code>r.expr([[A, B], [C, D]]).coerce_to('OBJECT')</code>.</para>
/// </summary>
/// <example><para>Example: Create a simple object.</para>
/// <code>r.object('id', 5, 'data', ['foo', 'bar']).run(conn, callback)
/// </code></example>
        public ReqlObject (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Creates an object from a list of key-value pairs, where the keys must
/// be strings.  <code>r.object(A, B, C, D)</code> is equivalent to
/// <code>r.expr([[A, B], [C, D]]).coerce_to('OBJECT')</code>.</para>
/// </summary>
/// <example><para>Example: Create a simple object.</para>
/// <code>r.object('id', 5, 'data', ['foo', 'bar']).run(conn, callback)
/// </code></example>
        public ReqlObject (Arguments args, OptArgs optargs)
         : base(TermType.OBJECT, args, optargs) {
        }


    



    


    

    


    
    }
}
