using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = AttributeSyntax;

    public static class AttributeSyntaxExtensions
    {
        public static type WithArgumentList(this type @this, string argumentList) =>
            @this.WithArgumentList(ParseAttributeArgumentList(argumentList));

        public static type WithArgument(this type @this, string argument) =>
            @this.WithArgumentList($"({argument})");

        public static type ToAttribute(this string @this) =>
            Attribute(ParseName(@this));

        public static type ToAttribute(this string @this, string argumentList) =>
            @this.ToAttribute().WithArgumentList(argumentList);

        public static type ToAttribute(this (string identifier, string argument) @this) =>
           @this.identifier.ToAttribute().WithArgumentList($"(\"{@this.argument}\")");

        public static AttributeListSyntax ToAttributeList(this type @this) => AttributeList(SingletonSeparatedList(@this));
        
        // Arrays

        public static AttributeListSyntax ToAttributeList(this type[] @this) => AttributeList(SeparatedList(@this));
    }
}
