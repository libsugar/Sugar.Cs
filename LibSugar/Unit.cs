﻿#if NET7_0_OR_GREATER
using System.Numerics;
#endif
using System;

namespace LibSugar;

public readonly record struct Unit
#if NET7_0_OR_GREATER
    : IEqualityOperators<Unit, Unit, bool>
#endif
{
    public static readonly Unit Instance = default;

    public override string ToString() => "Unit";
}
