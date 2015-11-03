












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

    public partial class CoerceTo : ReqlExpr {

    
    
    
/// <summary>
/// <para>Convert a value of one type into another.</para>
/// </summary>
/// <example><para>Example: Coerce a stream to an array.</para>
/// <code>r.table('posts').map(function (post) {
///     post.merge({ comments: r.table('comments').getAll(post('id'), {index: 'postId'}).coerceTo('array')});
/// }).run(conn, callback)
/// </code></example>
        public CoerceTo (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Convert a value of one type into another.</para>
/// </summary>
/// <example><para>Example: Coerce a stream to an array.</para>
/// <code>r.table('posts').map(function (post) {
///     post.merge({ comments: r.table('comments').getAll(post('id'), {index: 'postId'}).coerceTo('array')});
/// }).run(conn, callback)
/// </code></example>
        public CoerceTo (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Convert a value of one type into another.</para>
/// </summary>
/// <example><para>Example: Coerce a stream to an array.</para>
/// <code>r.table('posts').map(function (post) {
///     post.merge({ comments: r.table('comments').getAll(post('id'), {index: 'postId'}).coerceTo('array')});
/// }).run(conn, callback)
/// </code></example>
        public CoerceTo (Arguments args, OptArgs optargs)
         : base(TermType.COERCE_TO, args, optargs) {
        }


    



    


    

    


    
    }
}
