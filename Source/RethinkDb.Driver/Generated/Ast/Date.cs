












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

    public partial class Date : ReqlExpr {

    
    
    
/// <summary>
/// <para>Return a new time object only based on the day, month and year (ie. the same day at 00:00).</para>
/// </summary>
/// <example><para>Example: Retrieve all the users whose birthday is today</para>
/// <code>r.table("users").filter(function(user) {
///     return user("birthdate").date().eq(r.now().date())
/// }).run(conn, callback)
/// </code></example>
        public Date (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Return a new time object only based on the day, month and year (ie. the same day at 00:00).</para>
/// </summary>
/// <example><para>Example: Retrieve all the users whose birthday is today</para>
/// <code>r.table("users").filter(function(user) {
///     return user("birthdate").date().eq(r.now().date())
/// }).run(conn, callback)
/// </code></example>
        public Date (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Return a new time object only based on the day, month and year (ie. the same day at 00:00).</para>
/// </summary>
/// <example><para>Example: Retrieve all the users whose birthday is today</para>
/// <code>r.table("users").filter(function(user) {
///     return user("birthdate").date().eq(r.now().date())
/// }).run(conn, callback)
/// </code></example>
        public Date (Arguments args, OptArgs optargs)
         : base(TermType.DATE, args, optargs) {
        }


    



    


    

    


    
    }
}
