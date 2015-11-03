












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

    public partial class Time : ReqlExpr {

    
    
    
/// <summary>
/// <para>Create a time object for a specific time.</para>
/// <para>A few restrictions exist on the arguments:</para>
/// <ul>
/// <li><code>year</code> is an integer between 1400 and 9,999.</li>
/// <li><code>month</code> is an integer between 1 and 12.</li>
/// <li><code>day</code> is an integer between 1 and 31.</li>
/// <li><code>hour</code> is an integer.</li>
/// <li><code>minutes</code> is an integer.</li>
/// <li><code>seconds</code> is a double. Its value will be rounded to three decimal places
/// (millisecond-precision).</li>
/// <li><code>timezone</code> can be <code>'Z'</code> (for UTC) or a string with the format <code>±[hh]:[mm]</code>.</li>
/// </ul>
/// </summary>
/// <example><para>Example: Update the birthdate of the user "John" to November 3rd, 1986 UTC.</para>
/// <code>r.table("user").get("John").update({birthdate: r.time(1986, 11, 3, 'Z')})
///     .run(conn, callback)
/// </code></example>
        public Time (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Create a time object for a specific time.</para>
/// <para>A few restrictions exist on the arguments:</para>
/// <ul>
/// <li><code>year</code> is an integer between 1400 and 9,999.</li>
/// <li><code>month</code> is an integer between 1 and 12.</li>
/// <li><code>day</code> is an integer between 1 and 31.</li>
/// <li><code>hour</code> is an integer.</li>
/// <li><code>minutes</code> is an integer.</li>
/// <li><code>seconds</code> is a double. Its value will be rounded to three decimal places
/// (millisecond-precision).</li>
/// <li><code>timezone</code> can be <code>'Z'</code> (for UTC) or a string with the format <code>±[hh]:[mm]</code>.</li>
/// </ul>
/// </summary>
/// <example><para>Example: Update the birthdate of the user "John" to November 3rd, 1986 UTC.</para>
/// <code>r.table("user").get("John").update({birthdate: r.time(1986, 11, 3, 'Z')})
///     .run(conn, callback)
/// </code></example>
        public Time (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Create a time object for a specific time.</para>
/// <para>A few restrictions exist on the arguments:</para>
/// <ul>
/// <li><code>year</code> is an integer between 1400 and 9,999.</li>
/// <li><code>month</code> is an integer between 1 and 12.</li>
/// <li><code>day</code> is an integer between 1 and 31.</li>
/// <li><code>hour</code> is an integer.</li>
/// <li><code>minutes</code> is an integer.</li>
/// <li><code>seconds</code> is a double. Its value will be rounded to three decimal places
/// (millisecond-precision).</li>
/// <li><code>timezone</code> can be <code>'Z'</code> (for UTC) or a string with the format <code>±[hh]:[mm]</code>.</li>
/// </ul>
/// </summary>
/// <example><para>Example: Update the birthdate of the user "John" to November 3rd, 1986 UTC.</para>
/// <code>r.table("user").get("John").update({birthdate: r.time(1986, 11, 3, 'Z')})
///     .run(conn, callback)
/// </code></example>
        public Time (Arguments args, OptArgs optargs)
         : base(TermType.TIME, args, optargs) {
        }


    



    


    

    


    
    }
}
