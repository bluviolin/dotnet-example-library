namespace LibraryExample;

public static class StringUtils
{
    public static bool StartsWithLetter(this string str)
        => !string.IsNullOrEmpty(str) && char.IsLetter(str[0]);

    public static bool StartsWithUpper(this string str)
        => !string.IsNullOrEmpty(str) && char.IsUpper(str[0]);

    public static bool StartsWithLower(this string str)
        => !string.IsNullOrEmpty(str) && char.IsLower(str[0]);

    public static bool StartsWithDigit(this string str)
        => !string.IsNullOrEmpty(str) && char.IsDigit(str[0]);

    public static bool EndsWithLetter(this string str)
        => !string.IsNullOrEmpty(str) && char.IsLetter(str[^1]);

    public static bool EndsWithUpper(this string str)
        => !string.IsNullOrEmpty(str) && char.IsUpper(str[^1]);

    public static bool EndsWithLower(this string str)
        => !string.IsNullOrEmpty(str) && char.IsLower(str[^1]);

    public static bool EndsWithDigit(this string str)
        => !string.IsNullOrEmpty(str) && char.IsDigit(str[^1]);

    public static bool IsPalindrome(this string str)
        => str.Equals(new String(str.Reverse().ToArray()));
}