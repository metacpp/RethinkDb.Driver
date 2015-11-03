












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

    public partial class DbCreate : ReqlExpr {

    
    
    
/// <summary>
/// <para>Create a database. A RethinkDB database is a collection of tables, similar to
/// relational databases.</para>
/// <para>If successful, the operation returns an object: <code>{created: 1}</code>. If a database with the
/// same name already exists the operation throws <code>RqlRuntimeError</code>.</para>
/// <para>Note: that you can only use alphanumeric characters and underscores for the database name.</para>
/// </summary>
/// <example><para>Example: Create a database named 'superheroes'.</para>
/// <code>r.dbCreate('superheroes').run(conn, callback)
/// </code></example>
        public DbCreate (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Create a database. A RethinkDB database is a collection of tables, similar to
/// relational databases.</para>
/// <para>If successful, the operation returns an object: <code>{created: 1}</code>. If a database with the
/// same name already exists the operation throws <code>RqlRuntimeError</code>.</para>
/// <para>Note: that you can only use alphanumeric characters and underscores for the database name.</para>
/// </summary>
/// <example><para>Example: Create a database named 'superheroes'.</para>
/// <code>r.dbCreate('superheroes').run(conn, callback)
/// </code></example>
        public DbCreate (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Create a database. A RethinkDB database is a collection of tables, similar to
/// relational databases.</para>
/// <para>If successful, the operation returns an object: <code>{created: 1}</code>. If a database with the
/// same name already exists the operation throws <code>RqlRuntimeError</code>.</para>
/// <para>Note: that you can only use alphanumeric characters and underscores for the database name.</para>
/// </summary>
/// <example><para>Example: Create a database named 'superheroes'.</para>
/// <code>r.dbCreate('superheroes').run(conn, callback)
/// </code></example>
        public DbCreate (Arguments args, OptArgs optargs)
         : base(TermType.DB_CREATE, args, optargs) {
        }


    



    


    

    


    
    }
}
