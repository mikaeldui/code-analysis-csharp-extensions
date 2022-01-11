﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using DeclarationSyntax = MethodDeclarationSyntax;

    public static class MethodDeclarationSyntaxExtensions
    {
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

        public static DeclarationSyntax WithBody(this DeclarationSyntax @this, string bodyStatement) =>
            @this.WithBody(bodyStatement.ToBlock());

        public static ConstructorDeclarationSyntax WithParameter(this ConstructorDeclarationSyntax @this, string parameterType, string parameterIdentifier) =>
            @this.WithParameterList((parameterIdentifier, parameterType).ToParameterList());

        public static ConstructorDeclarationSyntax WithParameters(this ConstructorDeclarationSyntax @this, IEnumerable<KeyValuePair<string, string>> parameters) =>
            @this.WithParameterList(parameters.ToParameterList());
    }
}