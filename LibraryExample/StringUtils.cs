namespace LibraryExample
{
    public static class StringUtils
    {
        public static bool StartsWithUpper(this string str)
            => !string.IsNullOrEmpty(str) && char.IsUpper(str[0]);

        public static bool StartsWithLower(this string str)
            => !string.IsNullOrEmpty(str) && char.IsLower(str[0]);

        public static bool StartsWithDigit(this string str)
            => !string.IsNullOrEmpty(str) && char.IsDigit(str[0]);
    }
}