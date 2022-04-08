﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

using Microsoft.PowerFx.Core.Localization;
using Microsoft.PowerFx.Core.Public.Types;

namespace Microsoft.PowerFx.Core.IR
{
    internal class IRContext
    {
        // This field may be null, for example when nodes are generated by the compiler
        // and do not correlate with a source location
        public Span SourceContext { get; }

        public FormulaType ResultType { get; }

        internal IRContext(Span sourceContext, FormulaType resultType)
        {
            SourceContext = sourceContext;
            ResultType = resultType;
        }

        public static IRContext NotInSource(FormulaType resultType)
        {
            return new IRContext(null, resultType);
        }
    }
}
