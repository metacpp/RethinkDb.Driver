












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

    public partial class Replace : ReqlExpr {

    
    
    
/// <summary>
/// <para>Replace documents in a table. Accepts a JSON document or a ReQL expression, and replaces
/// the original document with the new one. The new document must have the same primary key
/// as the original document.</para>
/// </summary>
/// <example><para>Example: Replace the document with the primary key <code>1</code>.</para>
/// <code>r.table("posts").get(1).replace({
///     id: 1,
///     title: "Lorem ipsum",
///     content: "Aleas jacta est",
///     status: "draft"
/// }).run(conn, callback)
/// </code></example>
        public Replace (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Replace documents in a table. Accepts a JSON document or a ReQL expression, and replaces
/// the original document with the new one. The new document must have the same primary key
/// as the original document.</para>
/// </summary>
/// <example><para>Example: Replace the document with the primary key <code>1</code>.</para>
/// <code>r.table("posts").get(1).replace({
///     id: 1,
///     title: "Lorem ipsum",
///     content: "Aleas jacta est",
///     status: "draft"
/// }).run(conn, callback)
/// </code></example>
        public Replace (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Replace documents in a table. Accepts a JSON document or a ReQL expression, and replaces
/// the original document with the new one. The new document must have the same primary key
/// as the original document.</para>
/// </summary>
/// <example><para>Example: Replace the document with the primary key <code>1</code>.</para>
/// <code>r.table("posts").get(1).replace({
///     id: 1,
///     title: "Lorem ipsum",
///     content: "Aleas jacta est",
///     status: "draft"
/// }).run(conn, callback)
/// </code></example>
        public Replace (Arguments args, OptArgs optargs)
         : base(TermType.REPLACE, args, optargs) {
        }


    



    
///<summary>
/// "durability": "E_DURABILITY",
///  "return_changes": [
///    "T_BOOL",
///    "always"
///  ],
///  "non_atomic": "T_BOOL"
///</summary>
        public Replace this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new Replace (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "durability": "E_DURABILITY",
///  "return_changes": [
///    "T_BOOL",
///    "always"
///  ],
///  "non_atomic": "T_BOOL"
///</summary>
        public Replace optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new Replace (this.Args, newOptargs);
        }


    

    


    
    }
}
