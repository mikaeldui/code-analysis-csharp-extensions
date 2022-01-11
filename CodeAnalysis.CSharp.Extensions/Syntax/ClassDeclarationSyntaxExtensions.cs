using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using DeclarationSyntax = ClassDeclarationSyntax;

    public static class ClassDeclarationSyntaxExtensions
    {
        public static DeclarationSyntax AddBaseType(this DeclarationSyntax @this, string baseTypeName) =>
            @this.AddBaseListTypes(SimpleBaseType(ParseTypeName(baseTypeName)));

        public static DeclarationSyntax AddBaseTypes(this DeclarationSyntax @this, params string[] baseTypeNames) =>
            @this.AddBaseListTypes(baseTypeNames.Select(btn => SimpleBaseType(ParseTypeName(btn))).ToArray());

        public static DeclarationSyntax WithModifier(this DeclarationSyntax @this, SyntaxKind modifier) =>
            @this.WithModifiers(modifier.ToTokenList());

        public static DeclarationSyntax WithModifiers(this DeclarationSyntax @this, params SyntaxKind[] modifiers) =>
            @this.WithModifiers(modifiers.ToTokenList());

        public static DeclarationSyntax AddModifier(this DeclarationSyntax @this, SyntaxKind modifier) =>
            @this.AddModifiers(modifier.ToToken());

        public static DeclarationSyntax AddModifiers(this DeclarationSyntax @this, params SyntaxKind[] modifiers) =>
            @this.AddModifiers(modifiers.ToTokens());

        public static DeclarationSyntax AddAttribute(this DeclarationSyntax @this, AttributeSyntax attribute) =>
            @this.AddAttributeLists(attribute.ToAttributeList());

        public static DeclarationSyntax AddAttributes(this DeclarationSyntax @this, params AttributeSyntax[] attributes) =>
            @this.AddAttributeLists(attributes.ToAttributeList());
    }
}
