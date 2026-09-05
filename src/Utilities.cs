// Build: 81005622d1bd2b2b7ecb6ebe1542979f
using System;

internal static class Utilities
{
    public static int Clamp(int value, int minimum, int maximum)
        => Math.Min(maximum, Math.Max(minimum, value));
}
