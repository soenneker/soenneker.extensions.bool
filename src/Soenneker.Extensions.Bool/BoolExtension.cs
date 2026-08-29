using System.Diagnostics.Contracts;

namespace Soenneker.Extensions.Bool;

/// <summary>
/// Various helpful extension methods for boolean
/// </summary>
public static class BoolExtension
{
    /// <summary>
    /// Converts the Boolean value to the display text <c>Yes</c> or <c>No</c>.
    /// </summary>
    /// <param name="value">The Boolean value to format.</param>
    /// <returns><c>Yes</c> for true; otherwise <c>No</c>.</returns>
    [Pure]
    public static string ToYesNo(this bool value)
    {
        return value ? "Yes" : "No";
    }

    /// <summary>
    /// Converts the Boolean value to the lowercase text <c>yes</c> or <c>no</c>.
    /// </summary>
    /// <param name="value">The Boolean value to format.</param>
    /// <returns><c>yes</c> for true; otherwise <c>no</c>.</returns>
    [Pure]
    public static string ToYesNoLower(this bool value)
    {
        return value ? "yes" : "no";
    }
}