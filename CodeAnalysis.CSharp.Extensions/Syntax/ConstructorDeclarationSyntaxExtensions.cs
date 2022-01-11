using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using DeclarationSyntax = ConstructorDeclarationSyntax;

    public static class ConstructorDeclarationSyntaxExtensions
    {
        public static DeclarationSyntax WithBody(this DeclarationSyntax @this, string bodyStatement) =>
            @this.WithBody(bodyStatement.ToBlock());

        public static DeclarationSyntax WithBaseConstructorInitializer(this DeclarationSyntax @this) =>
            @this.WithInitializer(ConstructorInitializer(SyntaxKind.BaseConstructorInitializer));
 
        public static DeclarationSyntax WithBaseConstructorInitializer(this DeclarationSyntax @this, params string[] argumentIdentifiers) =>
            @this.WithInitializer(ConstructorInitializer(SyntaxKind.BaseConstructorInitializer)
                    .WithArgumentList(argumentIdentifiers.ToArgumentList()));

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

        public static DeclarationSyntax WithParameter(this DeclarationSyntax @this, string parameterType, string parameterIdentifier) =>
            @this.WithParameterList((parameterIdentifier, parameterType).ToParameterList());

        public static DeclarationSyntax WithParameters(this DeclarationSyntax @this, IEnumerable<KeyValuePair<string, string>> parameters) =>
            @this.WithParameterList(parameters.ToParameterList());

    }
}
