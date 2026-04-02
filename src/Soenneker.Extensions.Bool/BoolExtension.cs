using System.Diagnostics.Contracts;

namespace Soenneker.Extensions.Bool;

/// <summary>
/// Various helpful extension methods for boolean
/// </summary>
public static class BoolExtension
{
    /// <returns>"Yes" or "No"</returns>
    [Pure]
    public static string ToYesNo(this bool value)
    {
        return value ? "Yes" : "No";
    }

    /// <returns>"yes" or "no"</returns>
    [Pure]
    public static string ToYesNoLower(this bool value)
    {
        return value ? "yes" : "no";
    }
}