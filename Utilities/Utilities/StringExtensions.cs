namespace Utilities;

public static class StringExtensions
{
    public static string ToSnakeCase(this string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return "";
        var clean = new string(input.Where(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)).ToArray());
        return string.Join("_", clean.ToLower().Split(' ', StringSplitOptions.RemoveEmptyEntries));
    }
}