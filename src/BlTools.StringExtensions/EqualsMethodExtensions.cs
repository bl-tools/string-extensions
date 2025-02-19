namespace BlTools.StringExtensions
{
    public static class EqualsMethodExtensions
    {
        /// <summary>
        /// Uses string.Equals method - determines whether two specified string objects have the same value, using StringComparison.InvariantCultureIgnoreCase comparison rules
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns>True if the value of the first string is equal to the value of the second string, comparison ignoring case; otherwise, false.</returns>
        public static bool EqualsIgnoreCase(this string? source, string? value)
        {
            return string.Equals(source, value, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
