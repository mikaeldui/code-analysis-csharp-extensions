using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using DeclarationSyntax = PropertyDeclarationSyntax;

    public static class PropertyDeclarationSyntaxExtensions
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

        public static DeclarationSyntax AddAttribute(this DeclarationSyntax @this, string identifier) =>
            @this.AddAttribute(identifier.ToAttribute());

        public static DeclarationSyntax AddAttribute(this DeclarationSyntax @this, string identifier, string argument) =>
            @this.AddAttribute((identifier, argument).ToAttribute());

        public static DeclarationSyntax WithAccessor(this DeclarationSyntax @this, AccessorDeclarationSyntax accessor) =>
            @this.WithAccessorList(accessor.ToAccessorList());

        public static DeclarationSyntax WithAccessor(this DeclarationSyntax @this, SyntaxKind kind) =>
            @this.WithAccessor(kind.ToAccessor());

        public static DeclarationSyntax WithAccessor(this DeclarationSyntax @this, SyntaxKind kind, BlockSyntax body) =>
            @this.WithAccessor(AccessorDeclaration(kind, body));

        public static DeclarationSyntax WithAccessor(this DeclarationSyntax @this, SyntaxKind kind, string bodyStatement) =>
            @this.WithAccessor(kind, bodyStatement.ToBlock());

    }
}
