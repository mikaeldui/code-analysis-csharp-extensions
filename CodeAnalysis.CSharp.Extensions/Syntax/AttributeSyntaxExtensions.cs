using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = AttributeSyntax;

    public static class AttributeSyntaxExtensions
    {
        public static type WithArgumentList(this type @this, string text) =>
            @this.WithArgumentList(ParseAttributeArgumentList(text));

        public static type ToAttribute(this string @this) =>
            Attribute(ParseName(@this));

        public static type ToAttribute(this (string identifier, string argument) @this) =>
           @this.identifier.ToAttribute().WithArgumentList($"(\"{@this.argument}\")");

        public static AttributeListSyntax ToAttributeList(this type @this) => AttributeList(SingletonSeparatedList(@this));
        
        // Arrays

        public static AttributeListSyntax ToAttributeList(this type[] @this) => AttributeList(SeparatedList(@this));
    }
}
