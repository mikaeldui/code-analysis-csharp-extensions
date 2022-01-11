using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = AccessorDeclarationSyntax;
    using typeList = AccessorListSyntax;

    public static class AccessorDeclarationSyntaxExtensions
    {
        public static typeList ToAccessorList(this type @this) => AccessorList(SingletonList(@this));
    }
}
