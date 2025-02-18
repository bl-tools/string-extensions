namespace BlTools.StringExtensions
{
    public static class ContainsMethodExtensions
    {
        /// <summary>
        /// Returns a value indicating whether a specified string occurs within this string, using StringComparison.InvariantCultureIgnoreCase comparison rules
        /// </summary>
        /// <param name="source"></param>
        /// <param name="value"></param>
        /// <returns>True if the value occurs within the string, or if value is the empty("") string; 
        /// otherwise false also if source string contains null value(string? a = null;) or empty("") returns false.</returns>
        public static bool ContainsIgnoreCase(this string? source, string value)
        {
            return (source ?? string.Empty).Contains(value, StringComparison.InvariantCultureIgnoreCase);
        }
    }
}
