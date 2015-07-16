﻿using SharpDox.Sdk.Local;

namespace SharpDox.Plugins.Html
{
    public class HtmlStrings : ILocalStrings
    {
        private string _html = "Html";
        private string _primaryColor = "Primary Color";
        private string _secondaryColor = "Secondary Color";
        private string _theme = "Theme";
        private string _disableSequenceDiagrams = "Disable sequence diagrams";
        private string _footerLine = "Footer Line";
        private string _favIcon = "Favicon";

        private string _creatingProjectData = "Creating Project Data";
        private string _creatingStringData = "Creating String Data";
        private string _creatingNavigationData = "Creating Navigation Data";
        private string _createNamespaceData = "Creating Namespace Data: {0}";
        private string _creatingArticleData = "Creating Article Data";
        private string _copyingFile = "Copying File: {0}";

        private string _start = "Start";
        private string _by = "by";
        private string _back = "back";
        private string _description = "Description";
        private string _seeAlso = "See Also";
        private string _baseType = "Base Type";
        private string _implements = "Implements";
        private string _types = "Types";
        private string _type = "Type";
        private string _name = "Name";
        private string _assembly = "Assembly";
        private string _namespace = "Namespace";
        private string _home = "Home";
        private string _declaringType = "Declaring Type";
        private string _summary = "Summary";
        private string _syntax = "Syntax";
        private string _remarks = "Remarks";
        private string _example = "Example";
        private string _returns = "Returns";
        private string _exceptions = "Exceptions";
        private string _parameters = "Parameters";
        private string _typeParameters = "Type Parameters";
        private string _uses = "Uses";
        private string _usedBy = "Used by";
        private string _panZoom = "Drag to pan - Use Mousewheel + Ctrl to zoom";
        private string _save = "save";
        private string _reset = "reset";
        private string _article = "Article";
        private string _members = "Members";
        private string _fields = "Fields";
        private string _constructors = "Constructors";
        private string _methods = "Methods";
        private string _events = "Events";
        private string _properties = "Properties";
        private string _field = "Field";
        private string _method = "Method";
        private string _event = "Event";
        private string _property = "Property";
        private string _classDiagram = "Class Diagram";
        private string _generatedBy = "generated by";
        private string _expandAll = "expand all";
        private string _print = "print";
        private string _constValue = "Constant Value";
        
        public string DisplayName { get { return "HtmlExporter"; } }

        public string Html
        {
            get { return _html; }
            set { _html = value; }
        }

        public string PrimaryColor
        {
            get { return _primaryColor; }
            set { _primaryColor = value; }
        }

        public string SecondaryColor
        {
            get { return _secondaryColor; }
            set { _secondaryColor = value; }
        }

        public string Theme
        {
            get { return _theme; }
            set { _theme = value; }
        }

        public string DisableSequenceDiagrams
        {
            get { return _disableSequenceDiagrams; }
            set { _disableSequenceDiagrams = value; }
        }
        
        public string FooterLine
        {
            get { return _footerLine; }
            set { _footerLine = value; }
        }

        public string FavIcon
        {
            get { return _favIcon; }
            set { _favIcon = value; }
        }

        public string CreatingProjectData
        {
            get { return _creatingProjectData; }
            set { _creatingProjectData = value; }
        }

        public string CreatingStringData
        {
            get { return _creatingStringData; }
            set { _creatingStringData = value; }
        }

        public string CreatingNavigationData
        {
            get { return _creatingNavigationData; }
            set { _creatingNavigationData = value; }
        }

        public string CreatingNamespaceData
        {
            get { return _createNamespaceData; }
            set { _createNamespaceData = value; }
        }

        public string CreatingArticleData
        {
            get { return _creatingArticleData; }
            set { _creatingArticleData = value; }
        }

        public string CopyingFile
        {
            get { return _copyingFile; }
            set { _copyingFile = value; }
        }

        public string Start
        {
            get { return _start; }
            set { _start = value; }
        }

        public string By
        {
            get { return _by; }
            set { _by = value; }
        }

        public string Back
        {
            get { return _back; }
            set { _back = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string SeeAlso
        {
            get { return _seeAlso; }
            set { _seeAlso = value; }
        }

        public string BaseType
        {
            get { return _baseType; }
            set { _baseType = value; }
        }

        public string Implements
        {
            get { return _implements; }
            set { _implements = value; }
        }

        public string Types
        {
            get { return _types; }
            set { _types = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Assembly
        {
            get { return _assembly; }
            set { _assembly = value; }
        }

        public string Namespace
        {
            get { return _namespace; }
            set { _namespace = value; }
        }

        public string Home
        {
            get { return _home; }
            set { _home = value; }
        }

        public string DeclaringType
        {
            get { return _declaringType; }
            set { _declaringType = value; }
        }

        public string Summary
        {
            get { return _summary; }
            set { _summary = value; }
        }

        public string Syntax
        {
            get { return _syntax; }
            set { _syntax = value; }
        }

        public string Remarks
        {
            get { return _remarks; }
            set { _remarks = value; }
        }

        public string Example
        {
            get { return _example; }
            set { _example = value; }
        }

        public string Returns
        {
            get { return _returns; }
            set { _returns = value; }
        }

        public string Exceptions
        {
            get { return _exceptions; }
            set { _exceptions = value; }
        }

        public string Parameters
        {
            get { return _parameters; }
            set { _parameters = value; }
        }

        public string TypeParameters
        {
            get { return _typeParameters; }
            set { _typeParameters = value; }
        }

        public string Uses
        {
            get { return _uses; }
            set { _uses = value; }
        }

        public string UsedBy
        {
            get { return _usedBy; }
            set { _usedBy = value; }
        }

        public string PanZoom
        {
            get { return _panZoom; }
            set { _panZoom = value; }
        }

        public string Save
        {
            get { return _save; }
            set { _save = value; }
        }

        public string Reset
        {
            get { return _reset; }
            set { _reset = value; }
        }

        public string Article
        {
            get { return _article; }
            set { _article = value; }
        }

        public string Members
        {
            get { return _members; }
            set { _members = value; }
        }

        public string Fields
        {
            get { return _fields; }
            set { _fields = value; }
        }

        public string Constructors
        {
            get { return _constructors; }
            set { _constructors = value; }
        }

        public string Methods
        {
            get { return _methods; }
            set { _methods = value; }
        }

        public string Events
        {
            get { return _events; }
            set { _events = value; }
        }

        public string Properties
        {
            get { return _properties; }
            set { _properties = value; }
        }

        public string Field
        {
            get { return _field; }
            set { _field = value; }
        }

        public string Method
        {
            get { return _method; }
            set { _method = value; }
        }

        public string Event
        {
            get { return _event; }
            set { _event = value; }
        }

        public string Property
        {
            get { return _property; }
            set { _property = value; }
        }

        public string ClassDiagram
        {
            get { return _classDiagram; }
            set { _classDiagram = value; }
        }

        public string GeneratedBy
        {
            get { return _generatedBy; }
            set { _generatedBy = value; }
        }

        public string ExpandAll
        {
            get { return _expandAll; }
            set { _expandAll = value; }
        }

        public string Print
        {
            get { return _print; }
            set { _print = value; }
        }

        public string ConstValue
        {
            get { return _constValue; }
            set { _constValue = value; }
        }
    }
}
