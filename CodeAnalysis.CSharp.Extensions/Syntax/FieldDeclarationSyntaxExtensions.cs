using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using DeclarationSyntax = FieldDeclarationSyntax;

    public static class FieldDeclarationSyntaxExtensions
    {
        public static DeclarationSyntax WithModifier(this DeclarationSyntax @this, SyntaxToken modifier) =>
            @this.WithModifiers(TokenList(modifier));

        public static DeclarationSyntax WithModifier(this DeclarationSyntax @this, SyntaxKind modifier) =>
            @this.WithModifier(modifier.ToToken());

        public static DeclarationSyntax WithModifiers(this DeclarationSyntax @this, params SyntaxKind[] modifiers) =>
            @this.WithModifiers(modifiers.ToTokenList());

        public static DeclarationSyntax WithModifiers(this DeclarationSyntax @this, IEnumerable<SyntaxKind> modifiers) =>
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
