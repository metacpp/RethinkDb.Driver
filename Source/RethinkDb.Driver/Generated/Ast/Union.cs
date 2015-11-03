












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

    public partial class Union : ReqlExpr {

    
    
    
/// <summary>
/// <para>Concatenate two or more sequences.</para>
/// </summary>
/// <example><para>Example: Construct a stream of all heroes.</para>
/// <code>r.table('marvel').union(r.table('dc')).run(conn, callback);
/// </code></example>
        public Union (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Concatenate two or more sequences.</para>
/// </summary>
/// <example><para>Example: Construct a stream of all heroes.</para>
/// <code>r.table('marvel').union(r.table('dc')).run(conn, callback);
/// </code></example>
        public Union (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Concatenate two or more sequences.</para>
/// </summary>
/// <example><para>Example: Construct a stream of all heroes.</para>
/// <code>r.table('marvel').union(r.table('dc')).run(conn, callback);
/// </code></example>
        public Union (Arguments args, OptArgs optargs)
         : base(TermType.UNION, args, optargs) {
        }


    



    


    

    


    
    }
}
