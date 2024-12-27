namespace System;

public static class StringExtensions
{
    public static bool IsNullOrEmpty(this string value)
    {
        return string.IsNullOrEmpty(value);
    }

    public static bool IsNullOrWhiteSpace(this string value)
    {
        return string.IsNullOrWhiteSpace(value);
    }

    public static string NullToEmpty(this string value)
    {
        return value ?? string.Empty;
    }

    public static string Join(this IEnumerable<string> values, string separator)
    {
        return string.Join(separator, values);
    }
}
