using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    using static SyntaxFactory;
    using type = BaseTypeSyntax;
    using typeList = BaseListSyntax;

    public static class BaseTypeSyntaxExtensions
    {
        public static typeList ToBaseList(this type @this) => BaseList(SingletonSeparatedList(@this));
    }
}
