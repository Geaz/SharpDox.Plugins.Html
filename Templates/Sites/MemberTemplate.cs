﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion: 12.0.0.0
//  
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace SharpDox.Plugins.Html.Templates.Sites
{
    using System.Linq;
    using System.Text;
    using System.Net;
    using System.Collections.Generic;
    using SharpDox.Model.Repository;
    using SharpDox.Model.Repository.Members;
    using SharpDox.Model.Documentation.Token;
    using SharpDox.Sdk.Config;
    using SharpDox.Sdk;
    using SharpDox.UML;
    using MarkdownSharp;
    using SharpDox.Plugins.Html.Templates.Strings;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public partial class MemberTemplate : MemberTemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write("\n");
            this.Write(" \n\n<div id=\"");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.InternalIdentifier));
            
            #line default
            #line hidden
            this.Write("\" class=\"typesite\">\n\t<div class=\"sub-header\">\n\t\t<h2 class=\"type-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDMember.Name));
            
            #line default
            #line hidden
            this.Write("</h2>\n\t\t\n\t\t<div class=\"divider\">\n\t\t<span></span>\n\t\t</div>\n\t\t\n\t\t<span class=\"names" +
                    "pace-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.DeclaringType));
            
            #line default
            #line hidden
            this.Write(": ");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(SDType.Fullname));
            
            #line default
            #line hidden
            this.Write("</span>\n\t</div>\n\n\t<div class=\"sub-content\">\n\n\t\t<h3 class=\"box-title first-heading" +
                    "\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Syntax));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\n\t\t<div class=\"syntax-box\">\n\t\t\t<pre class=\"wrap-pre\"><code>");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(WebUtility.HtmlEncode(SDMember.Syntax)));
            
            #line default
            #line hidden
            this.Write("</code></pre>\n\t\t</div>\n        \n\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 if(SDMember.Documentation.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 if(SDMember.Documentation[CurrentLanguage].Summary.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Summary));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t<div class=\"doc-box markdown\">\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(SDMember.Documentation[CurrentLanguage].Summary.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t</div>\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 if(SDMember.Documentation[CurrentLanguage].Remarks.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Remarks));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t<div class=\"doc-box markdown\">\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(SDMember.Documentation[CurrentLanguage].Remarks.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t</div>\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 if(SDMember.Documentation[CurrentLanguage].Example.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Example));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t<div class=\"doc-box markdown\">\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(SDMember.Documentation[CurrentLanguage].Example.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t</div>\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 if(SDMember.Documentation[CurrentLanguage].Returns.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Returns));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t<div class=\"doc-box\">\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(SDMember.Documentation[CurrentLanguage].Returns.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t</div>\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 if(SDMember.Documentation[CurrentLanguage].Exceptions.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Exceptions));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t<div class=\"doc-box markdown\">\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 foreach(var exception in SDMember.Documentation[CurrentLanguage].Exceptions) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t<p>");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(exception.Key));
            
            #line default
            #line hidden
            this.Write("</p>\n\t\t\t\t\t\t<div class=\"inline\">\n\t\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(exception.Value.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t</div>\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t</div>\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 if(SDMember.Documentation[CurrentLanguage].Params.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.Parameters));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t<div class=\"doc-box markdown\">\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 foreach(var parameter in SDMember.Documentation[CurrentLanguage].Params) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t<p>");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(parameter.Key));
            
            #line default
            #line hidden
            this.Write("</p>\n\t\t\t\t\t\t<div class=\"inline\">\n\t\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(parameter.Value.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t</div>\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t</div>\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 if(SDMember.Documentation[CurrentLanguage].TypeParams.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.TypeParameters));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t<div class=\"doc-box markdown\">\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 foreach(var typeParameter in SDMember.Documentation[CurrentLanguage].TypeParams) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t<p>");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(typeParameter.Key));
            
            #line default
            #line hidden
            this.Write("</p>\n\t\t\t\t\t\t<div class=\"inline\">\n\t\t\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new Markdown().Transform(typeParameter.Value.ToMarkdown())));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t\t</div>\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t</div>\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 if(SDMember.Documentation[CurrentLanguage].SeeAlsos.Count > 0) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t<h3 class=\"box-title\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.SeeAlso));
            
            #line default
            #line hidden
            this.Write("</h3>\n\t\t\t\t<div class=\"list-box\">\n\t\t\t\t\t<ul>\n\t\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 foreach(var sdToken in SDMember.Documentation[CurrentLanguage].SeeAlsos) 
					{ 
						var seeAlso = (SDSeeToken)sdToken;
						if(!string.IsNullOrEmpty(seeAlso.DeclaringType))
						{
							var identifier = string.Format("{0}.{1}", seeAlso.DeclaringType, seeAlso.Name);
							var sdMember = Repository.GetMemberByIdentifier(identifier);
							if(sdMember != null)
                            {
								
            
            #line default
            #line hidden
            this.Write(" <li><a href=\"../type/");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdMember.DeclaringType.Identifier));
            
            #line default
            #line hidden
            this.Write(".html#");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdMember.InternalIdentifier));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdMember.Name));
            
            #line default
            #line hidden
            this.Write("</a></li> ");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"

                            }
						}
						else
						{
							var identifier = string.Format("{0}.{1}", seeAlso.Namespace, seeAlso.Name);
							var sdType = Repository.GetTypeByIdentifier(identifier);
							if(sdType != null)
                            {
								
            
            #line default
            #line hidden
            this.Write(" <li><a href=\"../type/");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdType.Identifier));
            
            #line default
            #line hidden
            this.Write(".html\">");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(sdType.Fullname));
            
            #line default
            #line hidden
            this.Write("</a></li> ");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"

                            }
						} 
					} 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t\t</ul>\n\t\t\t\t</div>\n\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 if(SDMember is SDMethod && !((SDMethod)SDMember).IsSequenceDiagramEmpty()) { 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t<div id=\"sd-sequence-diagram\" class=\"svgpan\">\n\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
	var sequenceSvg = ((SDMethod)SDMember).GetSequenceDiagram(Repository.GetAllTypes()).ToSvg(530);
					var template = new Templater(Repository, sequenceSvg); 
					var helper = new Helper(Repository); 
            
            #line default
            #line hidden
            this.Write("\n\t\t\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(template.TransformText(helper.TransformLinkToken)));
            
            #line default
            #line hidden
            this.Write("\n\t\t\t</div>\n\t\t\t<div class=\"legend\"><p>");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Strings.PanZoom));
            
            #line default
            #line hidden
            this.Write("</p></div>\n\t\t");
            
            #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\n\n\t</div>\n</div>\n\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 1 "C:\Users\ZP620933\Downloads\SharpDox.Plugins.Html-dev\Templates\Sites\MemberTemplate.tt"
 public IStrings Strings { get; set; }
	public string CurrentLanguage { get; set; }
	public SDRepository Repository { get; set; }
    public SDType SDType { get; set; }
	public SDMember SDMember { get; set; } 
        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "12.0.0.0")]
    public class MemberTemplateBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
