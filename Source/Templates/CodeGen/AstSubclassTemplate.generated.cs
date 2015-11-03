﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Templates.CodeGen
{
    
    #line 2 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System;
    
    #line default
    #line hidden
    
    #line 3 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System.Collections.Generic;
    
    #line default
    #line hidden
    
    #line 4 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 5 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System.Security.Cryptography;
    
    #line default
    #line hidden
    
    #line 6 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using System.Text;
    
    #line default
    #line hidden
    
    #line 7 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Humanizer;
    
    #line default
    #line hidden
    
    #line 8 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Newtonsoft.Json;
    
    #line default
    #line hidden
    
    #line 9 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Newtonsoft.Json.Linq;
    
    #line default
    #line hidden
    
    #line 10 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using RazorGenerator.Templating;
    
    #line default
    #line hidden
    
    #line 11 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Templates.CodeGen;
    
    #line default
    #line hidden
    
    #line 12 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Templates.CodeGen.Util;
    
    #line default
    #line hidden
    
    #line 13 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Templates.Metadata;
    
    #line default
    #line hidden
    
    #line 14 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    using Z.ExtensionMethods;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class AstSubclassTemplate : BaseTemplate
    {
#line hidden

        #line 18 "..\..\CodeGen\AstSubclassTemplate.cshtml"

    public string ClassName { get; set; }
    public string Superclass { get; set; }

    public string TermName { get; set; }
    public JObject TermMeta { get; set; }
    public Dictionary<string,JObject> AllTerms { get; set; }

    public override RazorTemplateBase UseParentLayout(RazorTemplateBase child)
    {
        return new AstSubclassTemplate()
        {
            ClassName = this.ClassName,
            Superclass = this.Superclass,
            TermName = this.TermName,
            TermMeta = this.TermMeta,
            AllTerms = this.AllTerms,
            ChildTemplate = child
        };
    }


        #line default
        #line hidden
#line hidden
public System.Web.WebPages.HelperResult RenderCtorXmlDoc(string term)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 42 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    
    Documentation doc;
    if( MetaDb.Docs.TryGetValue(term, out doc) )
    {

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "/// <summary>\r\n");



WriteLiteralTo(@__razor_helper_writer, "/// ");



#line 47 "..\..\CodeGen\AstSubclassTemplate.cshtml"
WriteTo(@__razor_helper_writer, doc.Description);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\r\n");



WriteLiteralTo(@__razor_helper_writer, "/// </summary>\r\n");



WriteLiteralTo(@__razor_helper_writer, "/// <example>");



#line 49 "..\..\CodeGen\AstSubclassTemplate.cshtml"
WriteTo(@__razor_helper_writer, doc.Example);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "</example>\r\n");



#line 50 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    };

#line default
#line hidden

});

}


        public override void Execute()
        {


WriteLiteral("\r\n");














WriteLiteral("\r\n");


WriteLiteral("\r\n");


WriteLiteral("\r\n\r\n");



WriteLiteral("\r\n\r\n");


DefineSection("Ctors", () => {

WriteLiteral("\r\n");


            
            #line 54 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     if( this.TermName != null )
    {
        
            
            #line default
            #line hidden
            
            #line 56 "..\..\CodeGen\AstSubclassTemplate.cshtml"
   Write(RenderCtorXmlDoc(this.TermName));

            
            #line default
            #line hidden
            
            #line 56 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                        

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 57 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (object arg) : this(new Arguments(arg), null) {\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 59 "..\..\CodeGen\AstSubclassTemplate.cshtml"

        
            
            #line default
            #line hidden
            
            #line 60 "..\..\CodeGen\AstSubclassTemplate.cshtml"
   Write(RenderCtorXmlDoc(this.TermName));

            
            #line default
            #line hidden
            
            #line 60 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                        

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 61 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (Arguments args) : this(args, null) {\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 63 "..\..\CodeGen\AstSubclassTemplate.cshtml"

        
            
            #line default
            #line hidden
            
            #line 64 "..\..\CodeGen\AstSubclassTemplate.cshtml"
   Write(RenderCtorXmlDoc(this.TermName));

            
            #line default
            #line hidden
            
            #line 64 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                        

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 65 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (Arguments args, OptArgs optargs)\r\n");



WriteLiteral("        ");

WriteLiteral(" : base(TermType.");


            
            #line 66 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                      Write(TermName);

            
            #line default
            #line hidden
WriteLiteral(", args, optargs) {\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 68 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        ");

WriteLiteral("protected ");


            
            #line 71 "..\..\CodeGen\AstSubclassTemplate.cshtml"
               Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, opta" +
"rgs)\r\n");



WriteLiteral("        ");

WriteLiteral("{\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 74 "..\..\CodeGen\AstSubclassTemplate.cshtml"
    }

            
            #line default
            #line hidden

});

WriteLiteral("\r\n\r\n");


DefineSection("StaticFactories", () => {

WriteLiteral("\r\n\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("OptArgs", () => {

WriteLiteral("\r\n");


            
            #line 82 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     if( TermMeta?["optargs"] != null )
    {
        var optArgs = TermMeta["optargs"] as JObject;

            
            #line default
            #line hidden
WriteLiteral("///<summary>\r\n");



WriteLiteral("/// ");


            
            #line 86 "..\..\CodeGen\AstSubclassTemplate.cshtml"
 Write(optArgs.ToString().Trim('{', '}').Trim().Replace("\n","\n///"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");



WriteLiteral("///</summary>\r\n");



WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 88 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" this[object optArgs] {\r\n");



WriteLiteral("        ");

WriteLiteral("    get\r\n");



WriteLiteral("        ");

WriteLiteral("    {\r\n");



WriteLiteral("        ");

WriteLiteral("        var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);\r\n");



WriteLiteral("        ");

WriteLiteral("\r\n");



WriteLiteral("        ");

WriteLiteral("        return new ");


            
            #line 93 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                        Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (this.Args, newOptargs);\r\n");



WriteLiteral("        ");

WriteLiteral("    }\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");



WriteLiteral("        ");

WriteLiteral("\r\n");



WriteLiteral("///<summary>\r\n");



WriteLiteral("/// ");


            
            #line 98 "..\..\CodeGen\AstSubclassTemplate.cshtml"
 Write(optArgs.ToString().Trim('{', '}').Trim().Replace("\n","\n///"));

            
            #line default
            #line hidden
WriteLiteral("\r\n");



WriteLiteral("///</summary>\r\n");



WriteLiteral("        ");

WriteLiteral("public ");


            
            #line 100 "..\..\CodeGen\AstSubclassTemplate.cshtml"
            Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" optArg(string key, object val){\r\n");



WriteLiteral("        ");

WriteLiteral("    \r\n");



WriteLiteral("        ");

WriteLiteral("    var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);\r\n");



WriteLiteral("        ");

WriteLiteral("\r\n");



WriteLiteral("        ");

WriteLiteral("    return new ");


            
            #line 104 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                    Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" (this.Args, newOptargs);\r\n");



WriteLiteral("        ");

WriteLiteral("}\r\n");


            
            #line 106 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     }

            
            #line default
            #line hidden

});

WriteLiteral(@"

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
");


            
            #line 121 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("add_imports"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\nnamespace RethinkDb.Driver.Ast {\r\n\r\n    public partial class ");


            
            #line 125 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                    Write(Class(ClassName));

            
            #line default
            #line hidden
WriteLiteral(" : ");


            
            #line 125 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                        Write(Superclass);

            
            #line default
            #line hidden
WriteLiteral(" {\r\n\r\n    ");


            
            #line 127 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("MemberVars"));

            
            #line default
            #line hidden
WriteLiteral("\r\n    \r\n    ");


            
            #line 129 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("Ctors"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 131 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("StaticFactories"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 133 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("OptArgs"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 135 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n    ");


            
            #line 137 "..\..\CodeGen\AstSubclassTemplate.cshtml"
Write(RenderSection("SpecialMethods"));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");


            
            #line 139 "..\..\CodeGen\AstSubclassTemplate.cshtml"
     foreach( var termInfo in AllTerms )
    {
        var term = termInfo.Key;
        var info = termInfo.Value;


        if( info["include_in"].ToObject<string[]>().Any(inc => string.Equals(inc, ClassName, StringComparison.OrdinalIgnoreCase)) )
        { // is the current term included in this class we're generating?
            foreach( var methodname in info["methodnames"].ToObject<string[]>() )
            {
                foreach( var signature in info["signatures"].ToObject<Signature[]>() )
                {
                    if( signature.FirstArg == ClassName )
                    {
                        var parameters = signature.Args.Skip(1).Select(arg => $"{ArgumentType(arg.Type)} {ArgumentVariable(arg.Var)}").ToArray();
                        
            
            #line default
            #line hidden
            
            #line 154 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                   Write(RenderCtorXmlDoc(term));

            
            #line default
            #line hidden
            
            #line 154 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                               

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("public ");


            
            #line 155 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                            Write(Class(info["classname"].ToString()));

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 155 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                                 Write(Method(methodname));

            
            #line default
            #line hidden
WriteLiteral(" ( ");


            
            #line 155 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                                                       Write(string.Join(", ", parameters.ToArray()));

            
            #line default
            #line hidden
WriteLiteral(" )\r\n");



WriteLiteral("                        ");

WriteLiteral("{\r\n");


            
            #line 157 "..\..\CodeGen\AstSubclassTemplate.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("Arguments arguments = new Arguments(this);\r\n");


            
            #line 159 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                        foreach( var param in signature.Args.Skip(1) )
                        {
                            if( param.Type.EndsWith("...") )
                            {

            
            #line default
            #line hidden
WriteLiteral("                                ");

WriteLiteral("arguments.CoerceAndAddAll(");


            
            #line 163 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                       Write(ArgumentVariable(param.Var));

            
            #line default
            #line hidden
WriteLiteral(");\r\n");


            
            #line 164 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                            }
                            else
                            {

            
            #line default
            #line hidden
WriteLiteral("                                ");

WriteLiteral("arguments.CoerceAndAdd(");


            
            #line 167 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                                    Write(ArgumentVariable(param.Var));

            
            #line default
            #line hidden
WriteLiteral(");\r\n");


            
            #line 168 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                            }
                        }

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("return new ");


            
            #line 170 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                                Write(Class(info["classname"].ToString()));

            
            #line default
            #line hidden
WriteLiteral(" (arguments );\r\n");


            
            #line 171 "..\..\CodeGen\AstSubclassTemplate.cshtml"


            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("}\r\n");


            
            #line 173 "..\..\CodeGen\AstSubclassTemplate.cshtml"
                    }
                }
            }

        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    \r\n    }\r\n}\r\n");


        }
    }
}
#pragma warning restore 1591
