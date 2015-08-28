



//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;

namespace RethinkDb.Driver {
    public class ReqlQueryLogicError : ReqlRuntimeError {


        public ReqlQueryLogicError () {
        }

        public ReqlQueryLogicError (Exception e) : this(e.Message, e) {
        }

        public ReqlQueryLogicError (string message) : base(message)
        {
        }

        public ReqlQueryLogicError (string message, Exception innerException) : base(message, innerException)
        {
        }
        
        
    }
}